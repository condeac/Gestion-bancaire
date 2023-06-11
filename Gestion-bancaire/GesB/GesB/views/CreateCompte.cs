using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Collections;
using GesB.models;

namespace GesB
{
    public partial class CreateCompte : Form
    {
        public CreateCompte()
        {
            InitializeComponent();
        }

        private void CreateCompte_Load(object sender, EventArgs e)
        {
            // Au chargement on coche le type de compte courant par défaut
            rdbCompteCourant.Checked = true;
            cmbTypePiece.Items.Add("Carte d'identité");
            cmbTypePiece.Items.Add("Passeport");
            cmbTypePiece.Items.Add("Carte consulaire");
            cmbTypePiece.Text = Convert.ToString(cmbTypePiece.Items[0]);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Gestion de l'accessibilité des champs si le type de compte EVP est coché

            txtPeriodeVersement.Enabled = true;
            txtSeuilDecouverture.Enabled = false;
            dtpDateDeblocage.Enabled = false;
            txtPrenomUser.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Gestion de l'accessibilité des champs si le type de compte Découvert es coché

            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouverture.Enabled = true;
            dtpDateDeblocage.Enabled = false;
            txtPrenomUser.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Gestion de l'accessibilité des champs si le type de compte bloqué est coché

            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouverture.Enabled = false;
            dtpDateDeblocage.Enabled = true;
            txtPrenomUser.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            // Gestion de l'accessibilité des champs si le type de compte entreprise est coché

            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouverture.Enabled = false;
            dtpDateDeblocage.Enabled = false;
            txtPrenomUser.Enabled = false;
        }

        private void rdbCompteCourant_CheckedChanged(object sender, EventArgs e)
        {
            // Gestion de l'accessibilité des champs si le type de compte courant est coché

            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouverture.Enabled = false;
            dtpDateDeblocage.Enabled = false;
            txtPrenomUser.Enabled = true;
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            // Controle de validation de saisie pour les comptes courant et entreprise ;<-----------  ici j'espère que tout le monde comprendra
                                                                                                   //bon j'explique quand même on sait jamias
            if (rdbCompteCourant.Checked == true || rdbCompteEntreprise.Checked == true)           //si le compte courant ou entreprise est choisi
            {
                if (string.IsNullOrEmpty(txtNumPieceUser.Text))                                    //on fait les vérifs
                {
                    MessageBox.Show("Le champ numero de pièce est obligatoire!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTypePiece.Items.Count == 0)
                {
                    MessageBox.Show("Le champ type de pièce est obligtoire!!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNomUser.Text))
                {
                    MessageBox.Show("Le champ nom est obligtoire!!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtTelephoneUser.Text))
                {
                    MessageBox.Show("Le champ téléphone est obligtoire!!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtSoldeInitialCompte.Text))
                {
                    MessageBox.Show("Le champ solde initial est obligtoire!!!", "Erreeur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Convert.ToInt64(txtNumPieceUser.Text);
                }
                catch
                {
                    MessageBox.Show("Le champ Numéro de pièce ne doit contenir que des entiers!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Convert.ToInt64(txtTelephoneUser.Text);
                }
                catch
                {
                    MessageBox.Show("Le champ Téléphone ne doit contenir que des entiers!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Convert.ToInt32(txtNumGuichet.Text);
                }
                catch
                {
                    MessageBox.Show("Le champ Numéro de guichet ne doit contenir que des entiers!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Convert.ToInt64(txtSoldeInitialCompte.Text);
                }
                catch
                {
                    MessageBox.Show("Le champ Solde initial ne doit contenir que des entiers!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            
                //------------------------FIN------------------------

                // Création des objets comptes courant ou entreprise
                if (rdbCompteCourant.Checked)                           //si le compte est de type courant
                {
                    try
                    {       //on crée un nouveau client et un nouveau compte, et on les met chacun dans sa liste
                        Client lClient = new Client(int.Parse(txtNumPieceUser.Text), cmbTypePiece.SelectedItem.ToString(), txtNomUser.Text, txtPrenomUser.Text, txtTelephoneUser.Text, txtAdresseUser.Text);
                        CompteCourant lCompteCourant = new CompteCourant(lClient.NumeroUser, rdbCompteCourant.Text, txtNumGuichet.Text, double.Parse(txtSoldeInitialCompte.Text), txtCodeSecretCompte.Text);
                        Comptes.aClients.Add(lClient);
                        Comptes.aComptes.Add(lCompteCourant);
                        if (Comptes.aComptes.Count != 0)        //si l'ajout dans la liste s'est bien passé
                        {
                            MessageBox.Show("Le compte a été créé avec succès!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else            //sinon
                            MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //dans tous les cas, on vide les champs (Note:on aurait pu mettre çà dans le finally mais bon...)
                        //MessageBox.Show(lClient.NumeroUser.ToString());
                        rdbCompteCourant.Checked = true;
                        txtNumPieceUser.Text = "";
                        cmbTypePiece.Text = Convert.ToString(cmbTypePiece.Items[0]);
                        txtNomUser.Text = "";
                        txtPrenomUser.Text = "";
                        txtTelephoneUser.Text = "";
                        txtAdresseUser.Text = "";
                        txtNumGuichet.Text = "";
                        txtSoldeInitialCompte.Text = "";
                        txtCodeSecretCompte.Text = "";
                        txtCodeSecretCompte.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rdbCompteEntreprise.Checked)            //idem que pour le compte courant
                {
                    try
                    {
                        Client lClient = new Client(int.Parse(txtNumPieceUser.Text), cmbTypePiece.SelectedItem.ToString(), txtNomUser.Text, txtPrenomUser.Text, txtTelephoneUser.Text, txtAdresseUser.Text);
                        CompteEntreprise lCompteEntreprise = new CompteEntreprise(lClient.NumeroUser, rdbCompteEntreprise.Text, txtNumGuichet.Text, double.Parse(txtSoldeInitialCompte.Text), txtCodeSecretCompte.Text);
                        Comptes.aClients.Add(lClient);
                        Comptes.aComptes.Add(lCompteEntreprise);
                        if (Comptes.aComptes.Count != 0)
                        {
                            MessageBox.Show("Le compte a été créé avec succès!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(lClient.NumeroUser.ToString());
                        rdbCompteCourant.Checked = true;
                        txtNumPieceUser.Text = "";
                        cmbTypePiece.Text = Convert.ToString(cmbTypePiece.Items[0]);
                        txtNomUser.Text = "";
                        txtPrenomUser.Text = "";
                        txtTelephoneUser.Text = "";
                        txtAdresseUser.Text = "";
                        txtNumGuichet.Text = "";
                        txtSoldeInitialCompte.Text = "";
                        txtCodeSecretCompte.Text = "";
                        txtCodeSecretCompte.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }

            // Controle de validation de saisie pour les comptes EVP

            if (rdbCompteEVP.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNumPieceUser.Text))
                {
                    MessageBox.Show("Le champ numéro de pièce est obligatoire!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTypePiece.Items.Count == 0)
                {
                    MessageBox.Show("Le champ type de pièce est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNomUser.Text))
                {
                    MessageBox.Show("Le champ nom est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtTelephoneUser.Text))
                {
                    MessageBox.Show("Le champ téléphone est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtSoldeInitialCompte.Text))
                {
                    MessageBox.Show("Le champ solde initial est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if  (string.IsNullOrEmpty(txtPeriodeVersement.Text))
                {
                    MessageBox.Show("Le champ période de versement est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(txtNumPieceUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Numéro de pièce ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtTelephoneUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Téléphone ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtSoldeInitialCompte.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Solde initial ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtPeriodeVersement.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Période de versement ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //------------------------FIN------------------------

                // Création des objets comptes EVP
                try
                {
                    Client lClient = new Client(int.Parse(txtNumPieceUser.Text), cmbTypePiece.SelectedItem.ToString(), txtNomUser.Text, txtPrenomUser.Text, txtTelephoneUser.Text, txtAdresseUser.Text);
                    CompteEVP lCompteEVP = new CompteEVP(lClient.NumeroUser, rdbCompteEVP.Text, txtNumGuichet.Text, double.Parse(txtSoldeInitialCompte.Text), txtCodeSecretCompte.Text, txtPeriodeVersement.Text);
                    Comptes.aClients.Add(lClient);
                    Comptes.aComptes.Add(lCompteEVP);
                    if (Comptes.aComptes.Count != 0)
                    {
                        MessageBox.Show("Le compte a été créé avec succès!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(lClient.NumeroUser.ToString());
                    rdbCompteCourant.Checked = true;
                    txtNumPieceUser.Text = "";
                    cmbTypePiece.Text = Convert.ToString(cmbTypePiece.Items[0]);
                    txtNomUser.Text = "";
                    txtPrenomUser.Text = "";
                    txtTelephoneUser.Text = "";
                    txtAdresseUser.Text = "";
                    txtNumGuichet.Text = "";
                    txtSoldeInitialCompte.Text = "";
                    txtPeriodeVersement.Text = "";
                    txtCodeSecretCompte.Text = "";
                    txtCodeSecretCompte.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!","Erreur de création",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            // Controle de validation de saisie pour les comptes découverts

            if (rdbCompteDecouvert.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNumPieceUser.Text))
                {
                    MessageBox.Show("Le champ numéro de pièce est obligatoire!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTypePiece.Items.Count == 0)
                {
                    MessageBox.Show("Le champ type de pièce est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNomUser.Text))
                {
                    MessageBox.Show("Le champ nom est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtTelephoneUser.Text))
                {
                    MessageBox.Show("Le champ téléphone est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtSoldeInitialCompte.Text))
                {
                    MessageBox.Show("Le champ solde initial est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if  (string.IsNullOrEmpty(txtSeuilDecouverture.Text))
                {
                    MessageBox.Show("Le champ sueil de découverture est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(txtNumPieceUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Numéro de pièce ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtTelephoneUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Téléphone ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtSoldeInitialCompte.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Solde initial ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtSeuilDecouverture.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Seuil de décourture ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //------------------------FIN------------------------

                // Création des objets comptes découverts
                try
                {
                    Client lClient = new Client(int.Parse(txtNumPieceUser.Text), cmbTypePiece.SelectedItem.ToString(), txtNomUser.Text, txtPrenomUser.Text, txtTelephoneUser.Text, txtAdresseUser.Text);
                    CompteDecouvert lCompteDecouvert = new CompteDecouvert(lClient.NumeroUser, rdbCompteDecouvert.Text, txtNumGuichet.Text, double.Parse(txtSoldeInitialCompte.Text), txtCodeSecretCompte.Text, double.Parse(txtSeuilDecouverture.Text));
                    Comptes.aClients.Add(lClient);
                    Comptes.aComptes.Add(lCompteDecouvert);
                    if (Comptes.aComptes.Count != 0)
                    {
                        MessageBox.Show("Le compte a été créé avec succès!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(lClient.NumeroUser.ToString());
                    rdbCompteCourant.Checked = true;
                    txtNumPieceUser.Text = "";
                    cmbTypePiece.Text = Convert.ToString(cmbTypePiece.Items[0]);
                    txtNomUser.Text = "";
                    txtPrenomUser.Text = "";
                    txtTelephoneUser.Text = "";
                    txtAdresseUser.Text = "";
                    txtNumGuichet.Text = "";
                    txtSoldeInitialCompte.Text = "";
                    txtSeuilDecouverture.Text = "";
                    txtCodeSecretCompte.Text = "";
                    dtpDateDeblocage.Text = DateTime.Now.ToString();
                    txtCodeSecretCompte.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!","Erreur de création",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            // Controle de validation de saisie pour les comptes bloqués

            if (rdbCompteBloque.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNumPieceUser.Text))
                {
                    MessageBox.Show("Le champ numéro de pièce est obligatoire!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTypePiece.Items.Count == 0)
                {
                    MessageBox.Show("Le champ type de pièce est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNomUser.Text))
                {
                    MessageBox.Show("Le champ nom est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtTelephoneUser.Text))
                {
                    MessageBox.Show("Le champ téléphone est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtSoldeInitialCompte.Text))
                {
                    MessageBox.Show("Le champ solde initial est obligtoire!!!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (dtpDateDeblocage.Value < DateTime.Today)
                {
                    MessageBox.Show("La date de déblocage ne peut pas être \n inférieure à la date du jour!!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(txtNumPieceUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Numéro de pièce ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtTelephoneUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Téléphone ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                    {
                        Convert.ToInt32(txtSoldeInitialCompte.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Le champ Solde initial ne doit contenir que des entiers!!", "Errur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //------------------------FIN------------------------

                // Création des objets comptes bloqués
                try
                {
                    Client lClient = new Client(int.Parse(txtNumPieceUser.Text), cmbTypePiece.SelectedItem.ToString(), txtNomUser.Text, txtPrenomUser.Text, txtTelephoneUser.Text, txtAdresseUser.Text);
                    CompteBloque lCompteBloque = new CompteBloque(lClient.NumeroUser, rdbCompteBloque.Text, txtNumGuichet.Text, double.Parse(txtSoldeInitialCompte.Text), txtCodeSecretCompte.Text, dtpDateDeblocage.Text);
                    Comptes.aClients.Add(lClient);
                    Comptes.aComptes.Add(lCompteBloque);
                    if (Comptes.aComptes.Count != 0)
                    {
                        MessageBox.Show("Le compte a été créé avec succès!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(lClient.NumeroUser.ToString());
                    rdbCompteCourant.Checked = true;
                    txtNumPieceUser.Text = "";
                    cmbTypePiece.Text = Convert.ToString(cmbTypePiece.Items[0]);
                    txtNomUser.Text = "";
                    txtPrenomUser.Text = "";
                    txtTelephoneUser.Text = "";
                    txtAdresseUser.Text = "";
                    txtNumGuichet.Text = "";
                    txtSoldeInitialCompte.Text = "";
                    txtCodeSecretCompte.Text = "";
                    txtCodeSecretCompte.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Une erreur s\'est produite lors de la création du compte!!","Erreur de création",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }            
        }

        private void txtSoldeInitialCompte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeSecretCompte_Enter(object sender, EventArgs e)
        { //Ah! j'aime bien ce petit code très efficace qui permet juste de générer un code secret pour les comptes de manière aléatoire
          //bien le seul problème: il existe toujours une chance que deux personnes aient le même code mais...  
            txtCodeSecretCompte.Focus();
            Random aleatoire = new Random();
            string codeSecret = "";
            for (int i = 0; i < 4; i++)
                codeSecret = codeSecret + aleatoire.Next(9).ToString();
            txtCodeSecretCompte.Text = codeSecret;
            txtCodeSecretCompte.Enabled = false;
        }

        private void bntFermer_Click(object sender, EventArgs e)
        {
            this.Close();       //je vous laisse deviner à quoi sert cette instruction!...lol
        }

        private void txtCodeSecretCompte_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
