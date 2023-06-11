using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesB.models
{
    public class CompteEntreprise : CompteCourant
    {
        // Constructeur par défaut
        public CompteEntreprise()
        {
        }

        // Constructeur surchargé

        public CompteEntreprise(string pNumeroUser, string pTypeCompte, string pNumeroGuichet, double pSolde, string pCodeSecret)
            : base(pNumeroUser , pTypeCompte, pNumeroGuichet, pSolde, pCodeSecret)
        {
        }
    }
}
