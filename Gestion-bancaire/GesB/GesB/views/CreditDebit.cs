using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GesB.models;

namespace GesB
{
    public partial class CreditDebit : Form
    {
        public CreditDebit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrediter_Click(object sender, EventArgs e)
        {
            //Code du bouton créditer
            //bon là je suis fatigué donc j'espère que tout le monde a compris qu'on doit toujour faire le controle des user input(conformément à la N.T.U.I = Never Trust User Input)
            if (string.IsNullOrEmpty(this.txtNumeroCompte.Text))
            {
                MessageBox.Show("Le champ numéro de compte ne peut être vide!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(this.txtMontantCrediterDebite.Text))
            {
                MessageBox.Show("Le champ montant ne peut être vide!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Convert.ToInt32(this.txtNumeroCompte.Text);
            }
            catch
            {
                MessageBox.Show("Le champ Numéro de compte ne doit contenir que des entiers!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Convert.ToInt32(this.txtMontantCrediterDebite.Text);
            }
            catch
            {
                MessageBox.Show("Le champ montant ne doit contenir que des entiers!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool lTrouve = false;
            for (int i = 0; i < Comptes.aComptes.Count; i++)    //pour un compte contenu dans la liste des comptes
            {
                if (Comptes.aComptes[i] is CompteCourant)       //si ce compte hérite de compte courant
                {
                    CompteCourant cc = (CompteCourant) Comptes.aComptes[i]; //on déclare un objet compte courant
                    if (cc.NumeroCompte == this.txtNumeroCompte.Text)   //si le numéro de compte est bien celui du client
                    {
                        lTrouve = true;         //alors on a trouvé le client
                        try
                        {       //et on réalise l'opération de créditation
                            cc.Crediter(double.Parse(this.txtMontantCrediterDebite.Text));
                            MessageBox.Show("Montant crédité!!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtNumeroCompte.Text = "";
                            this.txtMontantCrediterDebite.Text = "";
                            this.txtNumeroCompte.Focus();
                            return;     //on sort de la boucle
                        }
                        catch
                        {
                            MessageBox.Show("Une erreur est survenue pendant l'opération.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                   }
               }
           }
           if(!lTrouve)  //si aucun client ne cor
                MessageBox.Show("Montant non crédité!!\nVérifiez que le numéro de compte est correct.", "Opération échouée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CreditDebit_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFremer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDebiter_Click(object sender, EventArgs e)
        {           //même processus que pour le btn crédit
            bool lTrouve = false;
            foreach (Client bCli in Comptes.aClients)
            {
                for (int i = 0; i < Comptes.aComptes.Count; i++)
                {
                    if (Comptes.aComptes[i] is CompteCourant)
                    {
                        CompteCourant cc = (CompteCourant)Comptes.aComptes[i];
                        if (bCli.NumeroUser == cc.NumeroUser)
                        {
                            try
                            {
                                bool lresult = false;
                                if (cc.NumeroCompte == this.txtNumeroCompte.Text)
                                {
                                    lTrouve = true;
                                    lresult = cc.Debiter(double.Parse(this.txtMontantCrediterDebite.Text));
                                }
                                if (lresult)
                                {
                                    MessageBox.Show("Montant débité!!", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                               // else
                                 //   MessageBox.Show("Montant non débité!!", "Opération échouée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Une erreur est survenue pendant l'opération.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            if (!lTrouve)
                MessageBox.Show("Montant non débité!!\nVérifiez que le numéro de compte est correct.", "Opération échouée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
