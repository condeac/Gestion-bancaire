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
    public partial class ShowComptes : Form
    {
        static string lOldValue;
        public ShowComptes()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowComptes_Load(object sender, EventArgs e)
        {
            // Affichage de tous les comptes 

            if (Comptes.aClients.Count != 0 && Comptes.aComptes.Count != 0)     //teste s'il existe des clients et des comptes
            {
                foreach (Client bCLi in Comptes.aClients)       //pour chaque client
                {
                    for (int i = 0; i < Comptes.aComptes.Count; i++)    //on teste
                    {
                        if (typeof(CompteCourant) == Comptes.aComptes[i].GetType())
                        {
                            CompteCourant cc = new CompteCourant();     //on crée un objet de ce type
                            cc = (CompteCourant)Comptes.aComptes[i];    //on récupère le compte
                            if (bCLi.NumeroUser == cc.NumeroUser)       //et si le numero de compte correspond au numéro du client on ajoute dans le tableau
                                this.dgvListeCompte.Rows.Add(bCLi.NumeroUser, bCLi.NumeroPiece, bCLi.TypePiece, bCLi.NomUser, bCLi.PrenomUser, bCLi.TelephoneUser, cc.NumeroCompte, cc.NumeroGuichet, cc.Solde, cc.TypeCompte);
                            //return;
                        }
                        if (typeof(CompteEVP) == Comptes.aComptes[i].GetType())
                        {
                            CompteEVP cevp = new CompteEVP();     //on crée un objet de ce type
                            cevp = (CompteEVP)Comptes.aComptes[i];    //on récupère le compte
                            if (bCLi.NumeroUser == cevp.NumeroUser)       //et si le numero de compte correspond au numéro du client on ajoute dans le tableau
                            {
                                //this.dgvListeCompte.Columns.Add("periodeVersement", "Periode de versement");
                                this.dgvListeCompte.Columns["periodeVersement"].Visible = true;
                                this.dgvListeCompte.Rows.Add(bCLi.NumeroUser, bCLi.NumeroPiece, bCLi.TypePiece, bCLi.NomUser, bCLi.PrenomUser, bCLi.TelephoneUser, cevp.NumeroCompte, cevp.NumeroGuichet, cevp.Solde, cevp.TypeCompte);
                                DataGridViewRow dgvRow = dgvListeCompte.Rows[i];
                                DataGridViewCell dgvCell = dgvRow.Cells["periodeVersement"];
                                dgvCell.Value = cevp.PeriodeVersement;
                                
                            }
                        }
                        if (typeof(CompteDecouvert) == Comptes.aComptes[i].GetType())
                        {
                            CompteDecouvert cd = new CompteDecouvert();     //on crée un objet de ce type
                            cd = (CompteDecouvert)Comptes.aComptes[i];    //on récupère le compte
                            if (bCLi.NumeroUser == cd.NumeroUser)       //et si le numero de compte correspond au numéro du client on ajoute dans le tableau
                            {
                                //this.dgvListeCompte.Columns.Add("seuilDecouverture", "Seuil de découverture");
                                this.dgvListeCompte.Columns["seuilDecouverture"].Visible = true;
                                this.dgvListeCompte.Rows.Add(bCLi.NumeroUser, bCLi.NumeroPiece, bCLi.TypePiece, bCLi.NomUser, bCLi.PrenomUser, bCLi.TelephoneUser, cd.NumeroCompte, cd.NumeroGuichet, cd.Solde, cd.TypeCompte);
                                DataGridViewRow dgvRow = dgvListeCompte.Rows[i];
                                DataGridViewCell dgvCell = dgvRow.Cells["seuilDecouverture"];
                                dgvCell.Value = cd.Decouvert;
                            }
                        }
                        if (typeof(CompteBloque) == Comptes.aComptes[i].GetType())
                        {
                            CompteBloque cb = new CompteBloque();     //on crée un objet de ce type
                            cb = (CompteBloque)Comptes.aComptes[i];    //on récupère le compte
                            if (bCLi.NumeroUser == cb.NumeroUser)       //et si le numero de compte correspond au numéro du client on ajoute dans le tableau
                            {
                                //this.dgvListeCompte.Columns.Add("dateDeblocage", "Date de déblocage");
                                this.dgvListeCompte.Columns["dateDeblocage"].Visible = true;
                                this.dgvListeCompte.Rows.Add(bCLi.NumeroUser, bCLi.NumeroPiece, bCLi.TypePiece, bCLi.NomUser, bCLi.PrenomUser, bCLi.TelephoneUser, cb.NumeroCompte, cb.NumeroGuichet, cb.Solde, cb.TypeCompte);
                                DataGridViewRow dgvRow = dgvListeCompte.Rows[i];
                                DataGridViewCell dgvCell = dgvRow.Cells["dateDeblocage"];
                                dgvCell.Value = cb.DateDeblocage;
                            }
                        }
                        if (typeof(CompteEntreprise) == Comptes.aComptes[i].GetType())
                        {
                            CompteEntreprise ce = new CompteEntreprise();     //on crée un objet de ce type
                            ce = (CompteEntreprise)Comptes.aComptes[i];    //on récupère le compte
                            if (bCLi.NumeroUser == ce.NumeroUser)       //et si le numero de compte correspond au numéro du client on ajoute dans le tableau
                            {
                                this.dgvListeCompte.Rows.Add(bCLi.NumeroUser, bCLi.NumeroPiece, bCLi.TypePiece, bCLi.NomUser, bCLi.PrenomUser, bCLi.TelephoneUser, ce.NumeroCompte, ce.NumeroGuichet, ce.Solde, ce.TypeCompte);
                            }
                        }
                    }
                }
                this.dgvListeCompte.CurrentCell.Selected = false;       //désélection de la cellule courante
            }
            else
            {
                MessageBox.Show("Aucun compte n'a été créé!\nVeuillez d'abord créer un compte.", "Liste Vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            
        }

        //Cette procédure devait servir à effectuer la recherche dans la grille mais j'ai supprimé cette option pour un bug que je voulais pas gérer
        //faute de temps.
       /* private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvListeCompte.RowCount - 1; i++)      //au changement de valeur dans le txtbox recherche on désélectionne la ligne sélectionnée
            {
                if (this.dgvListeCompte.Rows[i].Selected)
                {
                    this.dgvListeCompte.Rows[i].Selected = false;
                    return;
                }
            }
        }*/

        private void dgvListeCompte_CellClick(object sender, DataGridViewCellEventArgs e)
        {    //quand on clique sur une cellule on récupère sa valeur actuelle
            if (this.dgvListeCompte.CurrentCell.Value != null)               //lOldValue:variable qui sert à retenir la valeur précédente de la cellule
                lOldValue = this.dgvListeCompte.CurrentCell.Value.ToString();   //qui va être modifiée
        }

        private void dgvListeCompte_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Code pour la modification

            string lNomcol = this.dgvListeCompte.CurrentCell.OwningColumn.Name;     //on obtient le nom de la colonne de la cellule en cours pour le

            if (string.Equals(lNomcol, "numeroPiece"))                             //comparer aux attributs des objets de la liste
            {
                foreach (Client bCli in Comptes.aClients)                          //ensuite on parcourt la liste des clients
                {
                    if (bCli.NumeroPiece.ToString() == lOldValue)                  //si la valeur avant changement et la valeur de l'objet dans la liste sont égales
                    {
                        bCli.NumeroPiece = Convert.ToInt32(this.dgvListeCompte.CurrentCell.Value);      //on lui affecte la new valeur!
                        break;                                                                          //et on sort de la boucle
                    }
                }
            }
            else if (string.Equals(lNomcol, "typePiece"))                           //bon, le reste vous l'aurez compris est identique pour toutes les colonnes
            {                                                                       //(et qui a dit que la vie était facile pour les programmeurs?)
                foreach (Client bCli in Comptes.aClients)
                {
                    if (bCli.TypePiece == lOldValue)
                    {
                        bCli.TypePiece = this.dgvListeCompte.CurrentCell.Value.ToString();
                        break;
                    }
                }
            }
            else if (string.Equals(lNomcol, "nom"))
            {
                foreach (Client bCli in Comptes.aClients)
                {
                    if (bCli.NomUser == lOldValue)
                    {
                        bCli.NomUser = this.dgvListeCompte.CurrentCell.Value.ToString();
                        break;
                    }
                }
            }
            else if (string.Equals(lNomcol, "prenom"))
            {
                foreach (Client bCli in Comptes.aClients)
                {
                    if (bCli.PrenomUser == lOldValue)
                    {
                        bCli.PrenomUser = this.dgvListeCompte.CurrentCell.Value.ToString();
                        break;
                    }
                }
            }
            else if (string.Equals(lNomcol, "telephone"))
            {
                foreach (Client bCli in Comptes.aClients)
                {
                    if (bCli.TelephoneUser == lOldValue)
                    {
                        bCli.TelephoneUser = this.dgvListeCompte.CurrentCell.Value.ToString();
                        break;
                    }
                }
            }
            else if (string.Equals(lNomcol, "numGuichet"))                  //ici je suppose que ce n'est pas nécessaire d'en dire long tout le monde comprends, non?
            {                                                               //bon, pour le numéro de guichet, c'est la même chose sauf que comme c'est attribut de compte
                for (int i = 0; i < Comptes.aComptes.Count; i++)            //on parcourt la liste des comptes(évidament!)
                {
                    if (i == this.dgvListeCompte.CurrentCell.RowIndex)      //si l'index de la ligne de la grille est le même que celui de l'objet dans la liste(pfiou!)
                    {
                        if (typeof(CompteCourant) == Comptes.aComptes[i].GetType())     //on regarde si c'est un compte de type courant et si oui, on fait comme précédament
                        {                                                               //et on le fait pour chaque type de compte.
                            CompteCourant cc = new CompteCourant();         //mais dans ce cas, on aurait pu utiliser l'oérateur de type "IS" et dire:
                            cc = (CompteCourant)Comptes.aComptes[i];        //if(Comptes.aComptes[i].GetType is CompteCourant) blablabla... mais attention à la facilité...!
                            if (cc.NumeroGuichet == lOldValue)
                            {
                                cc.NumeroGuichet = this.dgvListeCompte.CurrentCell.Value.ToString();
                            }
                        }
                        if (typeof(CompteEVP) == Comptes.aComptes[i].GetType())
                        {
                            CompteEVP cevp = new CompteEVP();     
                            cevp = (CompteEVP)Comptes.aComptes[i];
                            if (cevp.NumeroGuichet == lOldValue)
                            {
                                cevp.NumeroGuichet = this.dgvListeCompte.CurrentCell.Value.ToString();                                
                            }
                        }
                        if (typeof(CompteDecouvert) == Comptes.aComptes[i].GetType())
                        {
                            CompteDecouvert cd = new CompteDecouvert();     
                            cd = (CompteDecouvert)Comptes.aComptes[i];    
                            if (cd.NumeroGuichet == lOldValue)
                            {
                                cd.NumeroGuichet = this.dgvListeCompte.CurrentCell.Value.ToString();                                
                            }
                        }
                        if (typeof(CompteBloque) == Comptes.aComptes[i].GetType())
                        {
                            CompteBloque cb = new CompteBloque();     
                            cb = (CompteBloque)Comptes.aComptes[i];   
                            if (cb.NumeroGuichet == lOldValue)
                            {
                                cb.NumeroGuichet = this.dgvListeCompte.CurrentCell.Value.ToString();                                
                            }
                        }
                        if (typeof(CompteEntreprise) == Comptes.aComptes[i].GetType())
                        {
                            CompteEntreprise ce = new CompteEntreprise();    
                            ce = (CompteEntreprise)Comptes.aComptes[i];    
                            if (ce.NumeroGuichet == lOldValue)
                            {
                                ce.NumeroGuichet = this.dgvListeCompte.CurrentCell.Value.ToString();                               
                            }
                        }
                    }
                }
            }
            else if (string.Equals(lNomcol, "soldeInitial"))
            {
                for (int i = 0; i < Comptes.aComptes.Count; i++)
                {
                    if (i == this.dgvListeCompte.CurrentCell.RowIndex)
                    {
                        if (typeof(CompteCourant) == Comptes.aComptes[i].GetType())
                        {
                            CompteCourant cc = new CompteCourant();
                            cc = (CompteCourant)Comptes.aComptes[i];
                            if (cc.Solde == double.Parse(lOldValue))
                            {
                                cc.Solde = double.Parse(this.dgvListeCompte.CurrentCell.Value.ToString());                                
                            }
                        }
                        if (typeof(CompteEVP) == Comptes.aComptes[i].GetType())
                        {
                            CompteEVP cevp = new CompteEVP();
                            cevp = (CompteEVP)Comptes.aComptes[i];
                            if (cevp.Solde == double.Parse(lOldValue))
                            {
                                cevp.Solde = double.Parse(this.dgvListeCompte.CurrentCell.Value.ToString());                               
                            }
                        }
                        if (typeof(CompteDecouvert) == Comptes.aComptes[i].GetType())
                        {
                            CompteDecouvert cd = new CompteDecouvert();     //on crée un objet de ce type
                            cd = (CompteDecouvert)Comptes.aComptes[i];    //on récupère le compte
                            if (cd.Solde == double.Parse(lOldValue))
                            {
                                cd.Solde = double.Parse(this.dgvListeCompte.CurrentCell.Value.ToString());                                
                            }
                        }
                        if (typeof(CompteBloque) == Comptes.aComptes[i].GetType())
                        {
                            CompteBloque cb = new CompteBloque();     //on crée un objet de ce type
                            cb = (CompteBloque)Comptes.aComptes[i];    //on récupère le compte
                            if (cb.Solde == double.Parse(lOldValue))
                            {
                                cb.Solde = double.Parse(this.dgvListeCompte.CurrentCell.Value.ToString());                                
                            }
                        }
                        if (typeof(CompteEntreprise) == Comptes.aComptes[i].GetType())
                        {
                            CompteEntreprise ce = new CompteEntreprise();     //on crée un objet de ce type
                            ce = (CompteEntreprise)Comptes.aComptes[i];    //on récupère le compte
                            if (ce.Solde == double.Parse(lOldValue))
                            {
                                ce.Solde = double.Parse(this.dgvListeCompte.CurrentCell.Value.ToString());                                
                            }
                        }
                    }
                }
            }   
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Code du bouton supprimer
            //celui-là aussi j'ai une affection particulière pour ce petit code!
            //comparez-le avec la méthode sowComptes_Load(); on se rend bien compte que ce qu'on met 78 LIGNES DE CODE à construire
            //peut être détruit en SEULEMENT 10 LIGNES. ah la vie! çà me dégoute tellement que je ne le commenterai pas.
            //bon restons professionnel
            for (int i = 0; i < this.dgvListeCompte.RowCount; i++)                  //on parcourt les lignes de la grille
            {
                if (this.dgvListeCompte.CurrentRow == this.dgvListeCompte.Rows[i])  //si on trouve la ligne sélectionnée(la ligne active)
                {
                    this.dgvListeCompte.Rows.RemoveAt(i);                           //et bien on la supprime
                    Comptes.aComptes.RemoveAt(i);                                   //on supprime aussi le compte dont il s'agit
                    Comptes.aClients.RemoveAt(i);                                   //et puisqu'on y est, on supprime aussi le client qui lui est associé
                }
            }
        }
    }
}
