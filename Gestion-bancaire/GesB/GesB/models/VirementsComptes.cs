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

namespace GesB.models
{
    public class VirementsComptes
    {
        static int cNumeroVirement = 0;
        private string oNumeroVirement;
        private string oNumeroUser;
        private string oNumeroCompte;
        private double oMontantVirement;
        private string oDateVirement;
        private string oDestinataire;
        private bool oAutomatique;

        // Contructeur par défaut

        public VirementsComptes()
        {
        }
        
        // Constructeur surchargé

        public VirementsComptes(string pNumeroUser, string pNumeroCompte, double pMontantVirement, string pDateVirement, string pDestinataire)
        {
            if (Comptes.aVirements.Count != 0)
                cNumeroVirement = Comptes.aVirements.Count;

            this.oNumeroUser = pNumeroUser;
            this.oNumeroCompte = pNumeroCompte;
            this.oMontantVirement = pMontantVirement;
            this.oDateVirement = pDateVirement;
            this.oDestinataire = pDestinataire;
            this.oAutomatique = false;
            cNumeroVirement++;
            this.oNumeroVirement = cNumeroVirement.ToString();
        }

        // Création des accesseurs

        public string NumeroVirement
        {
            get { return this.oNumeroVirement; }
            set { this.oNumeroVirement = value; }
        }

        public string NumeroUser
        {
            get { return this.oNumeroUser; }
            set { this.oNumeroUser = value; }
        }

        public string NumeroCompte
        {
            get { return this.oNumeroCompte; }
            set { this.oNumeroCompte = value; }
        }

        public double MontantVirement
        {
            get { return this.oMontantVirement; }
            set { this.oMontantVirement = value; }
        }

        public string DateVirement
        {
            get { return this.oDateVirement; }
            set { this.oDateVirement = value; }
        }

        public string Destinataire
        {
            get { return this.oDestinataire; }
            set { this.oDestinataire = value; }
        }

        public bool Automatique
        {
            get { return this.oAutomatique; }
            set { this.oAutomatique = value; }
        }
    }
}
