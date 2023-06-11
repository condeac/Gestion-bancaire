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
    public partial class Virements : Form
    {
        public Virements()
        {
            InitializeComponent();
        }

        private void Virements_Load(object sender, EventArgs e)
        {
            // Code d'affichage des infos pour les virements

            if (Comptes.aClients.Count == 0)        //on vérifie d'abord s'il existe des clients et des comptes pour 
            {                                       //pouvoir faire des virements
                MessageBox.Show("Aucun compte n'a été créé!\nVeuillez d'abord créer un compte.", "Liste Vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Comptes.aVirements.Count >= 0)      //qu'il y ait des virements dans la liste ou pas
                {
                    foreach (Client bCli in Comptes.aClients)       //on initialise déjà certains champs pour réduire les efforts
                    {
                        this.cmbNomUser.Items.Add(bCli.NomUser);
                        this.cmbPrenomUser.Items.Add(bCli.PrenomUser);
                    }
                    this.cmbNomUser.SelectedItem = this.cmbNomUser.Items[0];
                    this.txtNumeroCompte.Enabled = true;
                    foreach (VirementsComptes bVir in Comptes.aVirements)
                    {
                        //on charge la liste des clients avec les infos des virements déjà existant dans la liste
                        this.dgvListeVirement.Rows.Add(bVir.NumeroVirement, bVir.NumeroCompte, bVir.MontantVirement, bVir.Destinataire, bVir.DateVirement);
                        //on initialise les champs du form avec les valeurs de la 1ère ligne par défaut
                        this.dgvListeVirement.Rows[0].Selected = true;
                    }
                }
            }
            this.dtpDateEmission.Value = DateTime.Now;          //normalement ce champ devrait se mettre à jour atomatiquement mais comme j'ai eu un
        }                                                       //léger bug avec, j'ai préféré le mettre à jour moi-même

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNomUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ici on gère la sélection automatique du prénom et du compte en fonction du nom choisit
            
            foreach (Client bCli in Comptes.aClients)                               //pour chaque client contenu dans la liste des clients
            {
                if (string.Equals(this.cmbNomUser.SelectedItem, bCli.NomUser))      //s'il s'agit du client sélectionné dans la combo nomUser
                {
                    for (int i = 0; i < Comptes.aComptes.Count;i++ )                //alors pour tout compte
                    {
                        if (typeof(CompteCourant) == Comptes.aComptes[i].GetType()) //s'il s'agit d'un compte courant
                        {
                            CompteCourant bCmpt = (CompteCourant)Comptes.aComptes[i];   //on instancie un compte de ce type
                            if (bCli.NumeroUser == bCmpt.NumeroUser)                    //on teste si le compte appartient au client en cours
                            {
                                this.cmbPrenomUser.SelectedItem = bCli.PrenomUser;      //si c'est le cas, on affiche son prénom dans la combo prenomUser
                                this.txtNumeroCompte.Text = bCmpt.NumeroCompte;         //et on affiche égalment son numéro de compte
                                //this.txtNumeroCompte.Enabled = false; <-------------- //on pourrait empêcher l'utilisateur de modifier le numéro de compte
                                return;                                                 //mais je laisse çà aux courageux lol!
                            }
                        }
                        if (typeof(CompteEVP) == Comptes.aComptes[i].GetType())         //bon, si vous suivez bien depuis le début vous aurez compris
                        {                                                               //qu'on fait la même chose mais là si le compte est de type 
                            CompteEVP bCmpt = (CompteEVP)Comptes.aComptes[i];           //CompteEVP (compte Epargne à Versement Périodique)
                            if (bCli.NumeroUser == bCmpt.NumeroUser)
                            {
                                this.cmbPrenomUser.SelectedItem = bCli.PrenomUser;
                                this.txtNumeroCompte.Text = bCmpt.NumeroCompte;
                                //this.txtNumeroCompte.Enabled = false;
                                return;
                            }
                        }
                        if (typeof(CompteDecouvert) == Comptes.aComptes[i].GetType())       //et caetera! jusqu'à la fin.
                        {
                            CompteDecouvert bCmpt = (CompteDecouvert)Comptes.aComptes[i];
                            if (bCli.NumeroUser == bCmpt.NumeroUser)
                            {
                                this.cmbPrenomUser.SelectedItem = bCli.PrenomUser;
                                this.txtNumeroCompte.Text = bCmpt.NumeroCompte;
                                //this.txtNumeroCompte.Enabled = false;
                                return;
                            }
                        }
                        if (typeof(CompteBloque) == Comptes.aComptes[i].GetType())
                        {
                            CompteBloque bCmpt = (CompteBloque)Comptes.aComptes[i];
                            if (bCli.NumeroUser == bCmpt.NumeroUser)
                            {
                                this.cmbPrenomUser.SelectedItem = bCli.PrenomUser;
                                this.txtNumeroCompte.Text = bCmpt.NumeroCompte;
                                //this.txtNumeroCompte.Enabled = false;
                                return;
                            }
                        }
                        if (typeof(CompteEntreprise) == Comptes.aComptes[i].GetType())
                        {
                            CompteEntreprise bCmpt = (CompteEntreprise)Comptes.aComptes[i];
                            if (bCli.NumeroUser == bCmpt.NumeroUser)
                            {                                                               //              --------
                                this.cmbPrenomUser.SelectedItem = bCli.PrenomUser;          //                  |
                                this.txtNumeroCompte.Text = bCmpt.NumeroCompte;             //                  |
                                //this.txtNumeroCompte.Enabled = false;                     //                  |
                                return;                                                     //                  |
                            }                                                               //              \   |   /
                        }                                                                   //               \  |  /
                    }                                                                       //                \___/
                }                                                                           //
            }                                                                               //Et la fin dont je parlais est ici!!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Controle de validation des saisies virement

            if (string.IsNullOrEmpty(txtMontantVirement.Text))
            {
                MessageBox.Show("Le champ montant est obligatoire!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDestinataire.Text))
            {
                MessageBox.Show("Le champ destinataire est obligatoire!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDateEmission.Value < DateTime.Today)
            {
                MessageBox.Show("La date d'émission ne peut pas être \n inférieure à la date du jour!!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.Equals(txtNumeroCompte.Text,txtDestinataire.Text))
            {
                MessageBox.Show("Les numéros de l'émetteur et du destinataire\ndoivent être différents!!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Convert.ToDouble(txtMontantVirement.Text);
            }
            catch
            {
                MessageBox.Show("Le champ montant ne doit contenir que des nombres!","Erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            try
            {
                Convert.ToInt32(txtDestinataire.Text);
            }
            catch
            {
                MessageBox.Show("Le champ destinataire ne doit contenir que des nombres!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            // Création de l'objet virement et ajout dans la liste des virements.

            foreach (Client bCli in Comptes.aClients)       //on parcourt la liste des clients
            {
                if (bCli.NomUser == this.cmbNomUser.SelectedItem.ToString())    //si on trouve le client dont le nom est celui sélectionné
                {
                    for (int i = 0; i < Comptes.aComptes.Count; i++)        //on regarde le type de compte
                    {
                        if (typeof(CompteCourant) == Comptes.aComptes[i].GetType())     //si c'est un compte courant
                        {
                            bool bTrouve1 = false;         //variable qui indique si on a trouvé le compte émetteur du virement
                            bool bTrouve2 = false;         //variable qui indique si on a trouvé le destinataire du virement
                            foreach (CompteCourant bCmpt in Comptes.aComptes)                                                //pour chaque compte courant
                            {
                                if (bCmpt.NumeroCompte == txtNumeroCompte.Text)            //si on trouve le numéro de compte emetteur
                                {
                                    bool lOk = false;
                                    lOk = bCmpt.Debiter(double.Parse(txtMontantVirement.Text));                //on lui débite le montant du virement
                                    if (lOk == true)
                                        bTrouve1 = true;            //on a trouvé l'émetteur
                                }
                                if (bCmpt.NumeroCompte == txtDestinataire.Text)            //si on trouve le numéro de compte destinataire
                                {
                                    bCmpt.Crediter(double.Parse(txtMontantVirement.Text));               //on lui crédite le montant
                                    bTrouve2 = true;                //on a trouvé le récepteur
                                }
                                if ((bTrouve1 == true) && (bTrouve2 == true))
                                {
                                    try
                                    {
                                        //on crée l'objet et on l'ajoute dans la liste des virements et dans la grille
                                        VirementsComptes lVirement = new VirementsComptes(bCli.NumeroUser, txtNumeroCompte.Text, double.Parse(txtMontantVirement.Text), dtpDateEmission.Text, txtDestinataire.Text.ToString());
                                        if (ckbVirementAuto.Checked)
                                            lVirement.Automatique = true;
                                        this.dgvListeVirement.Rows.Add(lVirement.NumeroVirement, this.txtNumeroCompte.Text, double.Parse(this.txtMontantVirement.Text), this.txtDestinataire.Text, this.dtpDateEmission.Value.ToString());
                                        Comptes.aVirements.Add(lVirement);
                                        return;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Une erreur s'est produite \n et a empêché le virement!!", "Erreur virement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        if (typeof(CompteEVP) == Comptes.aComptes[i].GetType())     //si c'est un compte courant
                        {
                            bool bTrouve1 = false;
                            bool bTrouve2 = false;
                            foreach (CompteEVP bCmpt in Comptes.aComptes)           //pour chaque compte courant
                            {
                                if (bCmpt.NumeroCompte == txtNumeroCompte.Text)            //si on trouve le numéro de compte emetteur
                                {
                                    bool lOk = false;
                                    lOk = bCmpt.Debiter(double.Parse(txtMontantVirement.Text));                //on lui débite le montant du virement
                                    if (lOk == true)
                                        bTrouve1 = true;
                                    else
                                    {
                                        MessageBox.Show("Le solde est insuffisant!!", "Solde insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (bCmpt.NumeroCompte == txtDestinataire.Text)            //si on trouve le numéro de compte destinataire
                                {
                                    bCmpt.Crediter(double.Parse(txtMontantVirement.Text));               //on lui crédite le montant
                                    bTrouve2 = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((bTrouve1 == true) && (bTrouve2 == true))
                                {
                                    try
                                    {
                                        //on crée l'objet et on l'ajoute dans la liste des virements et dans la grille
                                        VirementsComptes lVirement = new VirementsComptes(bCli.NumeroUser, txtNumeroCompte.Text, double.Parse(txtMontantVirement.Text), dtpDateEmission.Text, txtDestinataire.Text.ToString());
                                        if (ckbVirementAuto.Checked)
                                            lVirement.Automatique = true;
                                        this.dgvListeVirement.Rows.Add(lVirement.NumeroVirement, this.txtNumeroCompte.Text, double.Parse(this.txtMontantVirement.Text), this.txtDestinataire.Text, this.dtpDateEmission.Value.ToString());
                                        Comptes.aVirements.Add(lVirement);
                                        return;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Une erreur s'est produite \n et a empêché le virement!!", "Erreur virement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        if (typeof(CompteBloque) == Comptes.aComptes[i].GetType())     //si c'est un compte bloqué
                        {
                            bool bTrouve1 = false;
                            bool bTrouve2 = false;
                            foreach (CompteBloque bCmpt in Comptes.aComptes)           //pour chaque compte bloqué
                            {
                                if (bCmpt.NumeroCompte == txtNumeroCompte.Text)            //si on trouve le numéro de compte emetteur
                                {
                                    bool lOk = false;
                                    lOk = bCmpt.Debiter(double.Parse(txtMontantVirement.Text));                //on lui débite le montant du virement
                                    if (lOk == true)
                                        bTrouve1 = true;
                                    else
                                    {
                                        MessageBox.Show("Le solde est insuffisant!!", "Solde insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (bCmpt.NumeroCompte == txtDestinataire.Text)            //si on trouve le numéro de compte destinataire
                                {
                                    bCmpt.Crediter(double.Parse(txtMontantVirement.Text));               //on lui crédite le montant
                                    bTrouve2 = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((bTrouve1 == true) && (bTrouve2 == true))
                                {
                                    try
                                    {
                                        //on crée l'objet et on l'ajoute dans la liste des virements et dans la grille
                                        VirementsComptes lVirement = new VirementsComptes(bCli.NumeroUser, txtNumeroCompte.Text, double.Parse(txtMontantVirement.Text), dtpDateEmission.Text, txtDestinataire.Text.ToString());
                                        if (ckbVirementAuto.Checked)
                                            lVirement.Automatique = true;
                                        this.dgvListeVirement.Rows.Add(lVirement.NumeroVirement, this.txtNumeroCompte.Text, double.Parse(this.txtMontantVirement.Text), this.txtDestinataire.Text, this.dtpDateEmission.Value.ToString());
                                        Comptes.aVirements.Add(lVirement);
                                        return;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Une erreur s'est produite \n et a empêché le virement!!", "Erreur virement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        if (typeof(CompteDecouvert) == Comptes.aComptes[i].GetType())     //si c'est un compte courant
                        {
                            bool bTrouve1 = false;
                            bool bTrouve2 = false;
                            foreach (CompteDecouvert bCmpt in Comptes.aComptes)           //pour chaque compte courant
                            {
                                if (bCmpt.NumeroCompte == txtNumeroCompte.Text)            //si on trouve le numéro de compte emetteur
                                {
                                    bool lOk = false;
                                    lOk = bCmpt.Debiter(double.Parse(txtMontantVirement.Text));                //on lui débite le montant du virement
                                    if (lOk == true)
                                        bTrouve1 = true;
                                    else
                                    {
                                        MessageBox.Show("Le solde est insuffisant!!", "Solde insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (bCmpt.NumeroCompte == txtDestinataire.Text)            //si on trouve le numéro de compte destinataire
                                {
                                    bCmpt.Crediter(double.Parse(txtMontantVirement.Text));               //on lui crédite le montant
                                    bTrouve2 = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((bTrouve1 == true) && (bTrouve2 == true))
                                {
                                    try
                                    {
                                        //on crée l'objet et on l'ajoute dans la liste des virements et dans la grille
                                        VirementsComptes lVirement = new VirementsComptes(bCli.NumeroUser, txtNumeroCompte.Text, double.Parse(txtMontantVirement.Text), dtpDateEmission.Text, txtDestinataire.Text.ToString());
                                        if (ckbVirementAuto.Checked)
                                            lVirement.Automatique = true;
                                        this.dgvListeVirement.Rows.Add(lVirement.NumeroVirement, this.txtNumeroCompte.Text, double.Parse(this.txtMontantVirement.Text), this.txtDestinataire.Text, this.dtpDateEmission.Value.ToString());
                                        Comptes.aVirements.Add(lVirement);
                                        return;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Une erreur s'est produite \n et a empêché le virement!!", "Erreur virement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        if (typeof(CompteEntreprise) == Comptes.aComptes[i].GetType())     //si c'est un compte courant
                        {
                            bool bTrouve1 = false;
                            bool bTrouve2 = false;
                            foreach (CompteEntreprise bCmpt in Comptes.aComptes)           //pour chaque compte courant
                            {
                                if (bCmpt.NumeroCompte == txtNumeroCompte.Text)            //si on trouve le numéro de compte emetteur
                                {
                                    bool lOk = false;
                                    lOk = bCmpt.Debiter(double.Parse(txtMontantVirement.Text));                //on lui débite le montant du virement
                                    if (lOk == true)
                                        bTrouve1 = true;
                                    else
                                    {
                                        MessageBox.Show("Le solde est insuffisant!!", "Solde insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (bCmpt.NumeroCompte == txtDestinataire.Text)            //si on trouve le numéro de compte destinataire
                                {
                                    bCmpt.Crediter(double.Parse(txtMontantVirement.Text));               //on lui crédite le montant
                                    bTrouve2 = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de compte n'existe pas!!", "Numéro de compte inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((bTrouve1 == true) && (bTrouve2 == true))
                                {
                                    try
                                    {
                                        //on crée l'objet et on l'ajoute dans la liste des virements et dans la grille
                                        VirementsComptes lVirement = new VirementsComptes(bCli.NumeroUser, txtNumeroCompte.Text, double.Parse(txtMontantVirement.Text), dtpDateEmission.Text, txtDestinataire.Text.ToString());
                                        if (ckbVirementAuto.Checked)
                                            lVirement.Automatique = true;
                                        this.dgvListeVirement.Rows.Add(lVirement.NumeroVirement, this.txtNumeroCompte.Text, double.Parse(this.txtMontantVirement.Text), this.txtDestinataire.Text, this.dtpDateEmission.Value.ToString());
                                        Comptes.aVirements.Add(lVirement);
                                        return;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Une erreur s'est produite \n et a empêché le virement!!", "Erreur virement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dgvListeVirement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRechercherVirement_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvListeVirement.RowCount - 1; i++)      //au changement de valeur dans le txtbox recherche on désélectionne la ligne sélectionnée
            {
                if (this.dgvListeVirement.Rows[i].Selected)
                {
                    this.dgvListeVirement.Rows[i].Selected = false;
                    return;
                }
            }
        }

        private void btnAfficherVirement_Click(object sender, EventArgs e)
        {
            // Code de gestion d'accès direct à un élément de la grille

            for (int nbRow = 0; nbRow < this.dgvListeVirement.RowCount; nbRow++)        //boucle de parcours des lignes
            {
                for (int nbCol = 0; nbCol < this.dgvListeVirement.ColumnCount; nbCol++)   //boucle de parcous des colonnes
                {
                    if (string.Equals(this.dgvListeVirement[nbCol, nbRow].Value.ToString(), this.txtRechercherVirement.Text))     //si la cellule parcourue contient
                    {
                        try
                        {
                            this.dgvListeVirement.Rows[nbRow].Selected = true;        //le texte recherché, alors on sélectionne la ligne contenant la cellulle
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("La valeur demandée n'a pas été trouvée!!","Valeur introuvable",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
