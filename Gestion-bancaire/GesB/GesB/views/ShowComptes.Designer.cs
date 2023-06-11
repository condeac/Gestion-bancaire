namespace GesB
{
    partial class ShowComptes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListeCompte = new System.Windows.Forms.DataGridView();
            this.identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numGuichet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbListeCompte = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.periodeVersement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuilDecouverture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeblocage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCompte)).BeginInit();
            this.gpbListeCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renseignez le formulaire suivant pour Afficher / Modifier / Supprimer un compte";
            // 
            // dgvListeCompte
            // 
            this.dgvListeCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCompte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifiant,
            this.numeroPiece,
            this.typePiece,
            this.nom,
            this.prenom,
            this.telephone,
            this.numCompte,
            this.numGuichet,
            this.soldeInitial,
            this.typeCompte,
            this.periodeVersement,
            this.seuilDecouverture,
            this.dateDeblocage});
            this.dgvListeCompte.Location = new System.Drawing.Point(30, 19);
            this.dgvListeCompte.Name = "dgvListeCompte";
            this.dgvListeCompte.Size = new System.Drawing.Size(728, 271);
            this.dgvListeCompte.TabIndex = 2;
            this.dgvListeCompte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeCompte_CellClick);
            this.dgvListeCompte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvListeCompte.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeCompte_CellValidated);
            // 
            // identifiant
            // 
            this.identifiant.HeaderText = "Identifiant";
            this.identifiant.Name = "identifiant";
            this.identifiant.ToolTipText = "Contient le numéro d\'enregistrement du compte dans la base de données";
            // 
            // numeroPiece
            // 
            this.numeroPiece.HeaderText = "Numéro pièce";
            this.numeroPiece.Name = "numeroPiece";
            this.numeroPiece.ToolTipText = "Numéro de pièce d\'identité";
            // 
            // typePiece
            // 
            this.typePiece.HeaderText = "Type de pièce";
            this.typePiece.Name = "typePiece";
            this.typePiece.ToolTipText = "Type de pièce d\'identité utilisée pour la création du compte";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ToolTipText = "Nom du titulaire du compte";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ToolTipText = "Prénom du titulaire du compte";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Téléphone";
            this.telephone.Name = "telephone";
            this.telephone.ToolTipText = "Téléphone du titulaire du compte";
            // 
            // numCompte
            // 
            this.numCompte.HeaderText = "Numéro compte";
            this.numCompte.Name = "numCompte";
            this.numCompte.ToolTipText = "Numéro de compte";
            // 
            // numGuichet
            // 
            this.numGuichet.HeaderText = "Numéro guichet";
            this.numGuichet.Name = "numGuichet";
            this.numGuichet.ToolTipText = "Numéro de guichet d\'ouverture du compte";
            // 
            // soldeInitial
            // 
            this.soldeInitial.HeaderText = "Solde Initial";
            this.soldeInitial.Name = "soldeInitial";
            this.soldeInitial.ToolTipText = "Montant du dépôt initial lors de l\'ouverture du compte";
            // 
            // typeCompte
            // 
            this.typeCompte.HeaderText = "Type Compte";
            this.typeCompte.Name = "typeCompte";
            this.typeCompte.ToolTipText = "Type de compe";
            // 
            // gpbListeCompte
            // 
            this.gpbListeCompte.Controls.Add(this.btnFermer);
            this.gpbListeCompte.Controls.Add(this.btnSupprimer);
            this.gpbListeCompte.Controls.Add(this.dgvListeCompte);
            this.gpbListeCompte.Location = new System.Drawing.Point(12, 51);
            this.gpbListeCompte.Name = "gpbListeCompte";
            this.gpbListeCompte.Size = new System.Drawing.Size(791, 365);
            this.gpbListeCompte.TabIndex = 3;
            this.gpbListeCompte.TabStop = false;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(612, 314);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(121, 23);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(406, 314);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(165, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // periodeVersement
            // 
            this.periodeVersement.HeaderText = "Periode de versement";
            this.periodeVersement.Name = "periodeVersement";
            this.periodeVersement.Visible = false;
            // 
            // seuilDecouverture
            // 
            this.seuilDecouverture.HeaderText = "Seuil de découverture";
            this.seuilDecouverture.Name = "seuilDecouverture";
            this.seuilDecouverture.Visible = false;
            // 
            // dateDeblocage
            // 
            this.dateDeblocage.HeaderText = "Date de déblocage";
            this.dateDeblocage.Name = "dateDeblocage";
            this.dateDeblocage.Visible = false;
            // 
            // comptesBindingSource
            // 
            this.comptesBindingSource.DataSource = typeof(GesB.models.Comptes);
            // 
            // ShowComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 428);
            this.Controls.Add(this.gpbListeCompte);
            this.Controls.Add(this.label1);
            this.Name = "ShowComptes";
            this.Text = "GesB >> Affichage de comptes";
            this.Load += new System.EventHandler(this.ShowComptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCompte)).EndInit();
            this.gpbListeCompte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListeCompte;
        private System.Windows.Forms.GroupBox gpbListeCompte;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource comptesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn numGuichet;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeVersement;
        private System.Windows.Forms.DataGridViewTextBoxColumn seuilDecouverture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeblocage;
    }
}