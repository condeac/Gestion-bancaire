namespace GesB
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuCreerCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuModierSupprimerCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuGestionVirement = new System.Windows.Forms.ToolStripMenuItem();
            this.ongletCreationAffichageVirement = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuCrediterCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.menuGestionCompte,
            this.menuGestionTransaction});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(812, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMenuEnregistrer,
            this.ssMenuQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "&Fichier";
            // 
            // ssMenuEnregistrer
            // 
            this.ssMenuEnregistrer.Name = "ssMenuEnregistrer";
            this.ssMenuEnregistrer.Size = new System.Drawing.Size(152, 22);
            this.ssMenuEnregistrer.Text = "Enregistrer";
            this.ssMenuEnregistrer.Click += new System.EventHandler(this.ssMenuEnregistrer_Click);
            // 
            // ssMenuQuitter
            // 
            this.ssMenuQuitter.Name = "ssMenuQuitter";
            this.ssMenuQuitter.Size = new System.Drawing.Size(152, 22);
            this.ssMenuQuitter.Text = "Quitter";
            this.ssMenuQuitter.Click += new System.EventHandler(this.ssMenuQuitter_Click);
            // 
            // menuGestionCompte
            // 
            this.menuGestionCompte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMenuCreerCompte,
            this.ssMenuModierSupprimerCompte});
            this.menuGestionCompte.Name = "menuGestionCompte";
            this.menuGestionCompte.Size = new System.Drawing.Size(129, 20);
            this.menuGestionCompte.Text = "&Gestion des comptes";
            this.menuGestionCompte.Click += new System.EventHandler(this.menuGestionCompte_Click);
            // 
            // ssMenuCreerCompte
            // 
            this.ssMenuCreerCompte.Name = "ssMenuCreerCompte";
            this.ssMenuCreerCompte.Size = new System.Drawing.Size(226, 22);
            this.ssMenuCreerCompte.Text = "Créer";
            this.ssMenuCreerCompte.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // ssMenuModierSupprimerCompte
            // 
            this.ssMenuModierSupprimerCompte.Name = "ssMenuModierSupprimerCompte";
            this.ssMenuModierSupprimerCompte.Size = new System.Drawing.Size(226, 22);
            this.ssMenuModierSupprimerCompte.Text = "Afficher/Modifier/Supprimer";
            this.ssMenuModierSupprimerCompte.Click += new System.EventHandler(this.ssMenuModierSupprimerCompte_Click);
            // 
            // menuGestionTransaction
            // 
            this.menuGestionTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMenuGestionVirement,
            this.ssMenuCrediterCompte});
            this.menuGestionTransaction.Name = "menuGestionTransaction";
            this.menuGestionTransaction.Size = new System.Drawing.Size(150, 20);
            this.menuGestionTransaction.Text = "Gestion des &Transactions";
            this.menuGestionTransaction.Click += new System.EventHandler(this.menuGestionTransaction_Click);
            // 
            // ssMenuGestionVirement
            // 
            this.ssMenuGestionVirement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ongletCreationAffichageVirement});
            this.ssMenuGestionVirement.Name = "ssMenuGestionVirement";
            this.ssMenuGestionVirement.Size = new System.Drawing.Size(226, 22);
            this.ssMenuGestionVirement.Text = "Gestion des virements";
            this.ssMenuGestionVirement.Click += new System.EventHandler(this.ssMenuGestionVirement_Click);
            // 
            // ongletCreationAffichageVirement
            // 
            this.ongletCreationAffichageVirement.Name = "ongletCreationAffichageVirement";
            this.ongletCreationAffichageVirement.Size = new System.Drawing.Size(175, 22);
            this.ongletCreationAffichageVirement.Text = "Création/Affichage";
            this.ongletCreationAffichageVirement.Click += new System.EventHandler(this.ongletCreationAffichageVirement_Click);
            // 
            // ssMenuCrediterCompte
            // 
            this.ssMenuCrediterCompte.Name = "ssMenuCrediterCompte";
            this.ssMenuCrediterCompte.Size = new System.Drawing.Size(226, 22);
            this.ssMenuCrediterCompte.Text = "Créditer / Débiter un compte";
            this.ssMenuCrediterCompte.Click += new System.EventHandler(this.ssMenuCrediterCompte_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 529);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "GesB >> Application de gestion bancaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuGestionCompte;
        private System.Windows.Forms.ToolStripMenuItem ssMenuEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem ssMenuQuitter;
        private System.Windows.Forms.ToolStripMenuItem ssMenuCreerCompte;
        private System.Windows.Forms.ToolStripMenuItem ssMenuModierSupprimerCompte;
        private System.Windows.Forms.ToolStripMenuItem menuGestionTransaction;
        private System.Windows.Forms.ToolStripMenuItem ssMenuGestionVirement;
        private System.Windows.Forms.ToolStripMenuItem ongletCreationAffichageVirement;
        private System.Windows.Forms.ToolStripMenuItem ssMenuCrediterCompte;
    }
}

