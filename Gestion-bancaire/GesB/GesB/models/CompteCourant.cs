using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GesB.models
{
    [XmlInclude(typeof(CompteEVP))]
    [XmlInclude(typeof(CompteBloque))]
    [XmlInclude(typeof(CompteDecouvert))]
    [XmlInclude(typeof(CompteEntreprise))]
    public class CompteCourant
    {
        static int cNumeroCompte = 1;
        protected string oNumeroCompte;
        protected string oNumeroGuichet;
        protected double oSolde;
        protected string oCodeSecret;
        protected string oTypeCompte;
        protected string oNumeroUser;
        
        // Constructeur par défaut

        public CompteCourant()
        {
        }

        // Constructeur surchargé d'initialisation

        public CompteCourant(string pNumeroUser ,string pTypeCompte, string pNumeroGuichet, double pSolde, string pCodeSecret)
        {
            if (Comptes.aClients.Count != 0)
                cNumeroCompte = Comptes.aComptes.Count + 1;

            this.oNumeroCompte = cNumeroCompte++.ToString();
            this.oNumeroUser = pNumeroUser;
            this.oNumeroGuichet = pNumeroGuichet;
            this.oSolde = pSolde;
            this.oCodeSecret = pCodeSecret;
            this.oTypeCompte = pTypeCompte;
        }

        // Création des propriétés

        public string NumeroCompte
        {
            get { return this.oNumeroCompte; }
            set { this.oNumeroCompte = value; }
        }

        public string NumeroUser
        {
            get { return this.oNumeroUser; }
            set { this.oNumeroUser = value; }
        }

        public string NumeroGuichet
        {
            get { return this.oNumeroGuichet; }
            set { this.oNumeroGuichet = value; }
        }

        public double Solde
        {
            get { return this.oSolde; }
            set { this.oSolde = value; }
        }

        public string CodeSecret
        {
            get { return this.oCodeSecret; }
            set { this.oCodeSecret = value; }
        }

        public string TypeCompte
        {
            get { return this.oTypeCompte; }
            set { this.oTypeCompte = value; }
        }

        // Méthode créditer pour créditer le solde du compte

        public void Crediter(double pMontant)
        {
            this.oSolde += pMontant;
        }

        // Méthode débiter pour débiter les solde du compte

        public virtual bool Debiter(double pMontant)
        {
            if (this.oSolde - pMontant > 0)
            {
                this.oSolde -= pMontant;
                return true;
            }
            else
                return false;
        }
    }
}
