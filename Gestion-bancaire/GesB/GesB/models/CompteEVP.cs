using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesB.models
{
    public class CompteEVP : CompteCourant
    {
        private string oPeriodeVersement;

        // Constructeur par défaut

        public CompteEVP() 
        {
        }

        // Constructeur surchargé qui initialise la période de versement

        public CompteEVP(string pNumeroUser, string pTypeCompte, string pNumeroGuichet, double pSolde, string pCodeSecret, string pPeriodeVersement)
            : base(pNumeroUser, pTypeCompte, pNumeroGuichet, pSolde, pCodeSecret)
        {
            this.oPeriodeVersement = pPeriodeVersement;
        }

        // Création des propriétés

        public string PeriodeVersement
        {
            get { return this.oPeriodeVersement; }
            set { this.oPeriodeVersement = value; }
        }
    }
}
