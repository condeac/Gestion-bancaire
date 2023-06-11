using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GesB.models
{
    public class CompteDecouvert : CompteCourant
    {
        private double oDecouvert;

        // Constructeur par défaut

        public CompteDecouvert()
        {
        }

        // Constructeur qui initialise le découvert à 15

        public CompteDecouvert(string pNumeroUser, string pTypeCompte, string pNumeroGuichet, double pSolde, string pCodeSecret, double pDecouvert)
            : base(pNumeroUser, pTypeCompte, pNumeroGuichet, pSolde, pCodeSecret)
        {
            this.oDecouvert = pDecouvert;
        }

        // Création des propriétés

        public double Decouvert
        {
            get { return this.oDecouvert; }
            set { this.oDecouvert = value ;}
        }

        // Surchage de la méthode debiter

        public override bool Debiter(double pMontant)
        {
            if ((this.oSolde - pMontant) < this.oDecouvert)
            {
                return false;
            }
            else
            {
                this.Solde -= pMontant;
                return true;
            }
        }
    }
}
