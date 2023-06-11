using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections;
using GesB.models;
using System.IO;
using Microsoft.VisualBasic;

namespace GesB.views
{
    public partial class frmClient : Form
    {
        private string lNumCompte;
        public frmClient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmclient_Load(object sender, EventArgs e)
        {
            // Ici j'initialise la taille de la fenêtre 
            this.Width = 300;
            this.Height = 300;
            Comptes.chargerDonnees();           //et je charge les informations
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Code de vérification des infos de connexion
            if (string.IsNullOrEmpty(txtNumCompte.Text) || string.IsNullOrEmpty(txtCodeSecret.Text))        //on fait le test de validité
            {
                MessageBox.Show("Tous les champs doivent être remplis!!", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                for (int i = 0; i < Comptes.aComptes.Count; i++)        //si tous les champs sont pleins
                {                                                       //mais que les informations sont erronnées...
                    if (Comptes.aComptes[i].NumeroCompte != txtNumCompte.Text || Comptes.aComptes[i].CodeSecret != txtCodeSecret.Text)
                    {
                        MessageBox.Show("Numéro de compte ou code secret incorrect!!\nVeuillez recommencer.", "Erreur identification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {                                                   //dans le cas contraire...
                        lNumCompte = Comptes.aComptes[i].NumeroCompte;  //on retient la valeur de du compte du user
                        this.Width = 632;                               //on redimensionne la fenêtre
                        this.Height = 300;
                        txtNumCompte.Enabled = false;                   //par sécurité on protège les infos d'indentification...on sait jamais
                        txtCodeSecret.Enabled = false;
                        btnValider.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void btnSolde_Click(object sender, EventArgs e)
        {
            //Code d'affichage du solde
            for (int i = 0; i < Comptes.aComptes.Count; i++)        //on parcourt d'abord la liste
            {
                if (Comptes.aComptes[i].NumeroCompte == lNumCompte)     //si on trouve le bon compte
                {
                    MessageBox.Show("Votre solde est de :"+Comptes.aComptes[i].Solde.ToString()+" FCFA", "Affichage du solde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            //Code pour retirer de l'argent
            bool lEtat = false;              //variable booléenne qui nous permet de dire si le débit s'est bien passé;(false:on a pas encore fait de retrait).
            string lMontantRetrait = Interaction.InputBox("Combien voulez-vous retrirer?","Ges_B >> Retrait");      //on affiche une une boite de dialogue pour le retrait
            if (!string.IsNullOrEmpty(lMontantRetrait))     //si l'user entre un montant
            {
                for (int i = 0; i < Comptes.aComptes.Count; i++)        //on boucle pour trouver le bon compte
                {
                    if (Comptes.aComptes[i].NumeroCompte == lNumCompte) //et quand on l'a trouvé......
                    {
                        lEtat = Comptes.aComptes[i].Debiter(double.Parse(lMontantRetrait));     //......on débite!
                        if (lEtat)                                                              //et si le débit s'est bien passé...
                        {
                            Comptes.sauvegarderDonnees();                           //on enregistre le tout et on affiche un petit message
                            MessageBox.Show("Vous venez de retirer la somme de:\n" + lMontantRetrait + " FCFA de votre compte", "Opération reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        else                    //on affiche un message et on sort.
                            MessageBox.Show("La somme demandée n'a pas pu être retirée!", "Opération echouee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            //Code du bouton déconnexion
            //je pense que tout le monde, en faisant un petit effort pourra comprendre ce code

            txtNumCompte.Enabled = true;
            txtCodeSecret.Enabled = true;
            btnValider.Enabled = true;
            this.Width = 300;
            this.Height = 300;
            txtNumCompte.Text = "";
            txtCodeSecret.Text = "";
        }
    }
}
