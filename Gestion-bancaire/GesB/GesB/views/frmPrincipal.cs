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
using GesB.views;

namespace GesB
{
    public partial class frmPrincipal : Form
    {
        public static string numGuichet;
        public static bool isDataSaved;         //variable d'initialisation de sauvegarde
                                                //au chargement du logiciel, on suppose qu'aucune sauvegarde n'a été faite
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Comptes.chargerDonnees();
            isDataSaved = false;
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {                                                                           //bon allez, je l'explique une fois et vous faites le reste après lol!
            CreateCompte frmCreateCompte = new CreateCompte();                      //ici j'instancie un objet form de type createcompte que je nomme frmCreateCompte(manque d'inspiration)
            frmCreateCompte.MdiParent = this;                                       //je lui présente sa maman c-a-d je définis que frmCreateComptes en une fille du formulaire actuelle "this"
            frmCreateCompte.WindowState = FormWindowState.Maximized;                //ou que le formulaire actuel est un parent du frmCreateCompte puis je fixe la taille maximale
            frmCreateCompte.Show();                                                 //et là...je l'affiche!!
        }

        private void ssMenuModierSupprimerCompte_Click(object sender, EventArgs e)
        {                                                                           //c'est exatement la même chose dans tous les sous-menu sauf enregistrer et quitter
            ShowComptes frmShowCompte = new ShowComptes();
            frmShowCompte.MdiParent = this;
            frmShowCompte.WindowState = FormWindowState.Maximized;
            frmShowCompte.Show();
        }

        private void ongletCreationAffichageVirement_Click(object sender, EventArgs e)
        {
            Virements frmVirement = new Virements();
            frmVirement.MdiParent = this;
            frmVirement.WindowState = FormWindowState.Maximized;
            frmVirement.Show();
        }

        private void ssMenuCrediterCompte_Click(object sender, EventArgs e)
        {
            CreditDebit frmCreditDebit = new CreditDebit();
            frmCreditDebit.MdiParent = this;
            frmCreditDebit.WindowState = FormWindowState.Maximized;
            frmCreditDebit.Show();
        }

        private void ssMenuGestionVirement_Click(object sender, EventArgs e)
        {

        }

        private void menuGestionCompte_Click(object sender, EventArgs e)
        {

        }

        private void ssMenuEnregistrer_Click(object sender, EventArgs e)
        {
            //quand l'user clique sur le sous-menu Enregistrer, on appelle la méthode correspondante
            Comptes.sauvegarderDonnees();
            isDataSaved = true;             //et on précise que l'user a déjà saved les datas. (i'm an english man in C#)lol
        }
            
        private void menuGestionTransaction_Click(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //à la fermeture on demande à l'utisisateur s'il veut faire une savegarde
            //des données avant de quitter l'application

            if (!isDataSaved)
            {
               DialogResult dR = MessageBox.Show("Vous avez demandé la fermeture du logiciel.\nSi vous quittez sans enregistrer les récentes opérations\neffectuées ne seront pas prises en compte.\nVoulez-vous les enregistrer?", "Fermeture de Ges_B", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                //MessageBox.Show(dR.ToString());
               if (dR.ToString() == "Yes")
                   Comptes.sauvegarderDonnees();
               isDataSaved = true;
            }
        }

        private void ssMenuQuitter_Click(object sender, EventArgs e)
        {
            //je répète la même procédure que celle du dessus

            if (!isDataSaved)
            {
                DialogResult dR = MessageBox.Show("Vous avez demandé la fermeture du logiciel.\nSi vous quittez sans enregistrer les récentes opérations\neffectuées ne seront pas prises en compte.\nVoulez-vous les enregistrer?", "Fermeture de Ges_B", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                //MessageBox.Show(dR.ToString());
                if (dR.ToString() == "Yes")
                    Comptes.sauvegarderDonnees();
                isDataSaved = true;
            }
        }

        private void menuApropos_Click(object sender, EventArgs e)
        {
           
        }
     }
  }

