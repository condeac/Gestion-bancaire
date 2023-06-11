namespace GesB
{
    partial class Virements
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpbCreationVirement = new System.Windows.Forms.GroupBox();
            this.txtDestinataire = new System.Windows.Forms.TextBox();
            this.ckbVirementAuto = new System.Windows.Forms.CheckBox();
            this.cmbPrenomUser = new System.Windows.Forms.ComboBox();
            this.cmbNomUser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDateEmission = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontantVirement = new System.Windows.Forms.TextBox();
            this.txtNumeroCompte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbListeVirement = new System.Windows.Forms.GroupBox();
            this.btnAfficherVirement = new System.Windows.Forms.Button();
            this.txtRechercherVirement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListeVirement = new System.Windows.Forms.DataGridView();
            this.numVir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantVir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destVir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFermer = new System.Windows.Forms.Button();
            this.gpbCreationVirement.SuspendLayout();
            this.gpbListeVirement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeVirement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renseignez ce formulaire pour Créer / Afficher des virements";
            // 
            // gpbCreationVirement
            // 
            this.gpbCreationVirement.Controls.Add(this.txtDestinataire);
            this.gpbCreationVirement.Controls.Add(this.ckbVirementAuto);
            this.gpbCreationVirement.Controls.Add(this.cmbPrenomUser);
            this.gpbCreationVirement.Controls.Add(this.cmbNomUser);
            this.gpbCreationVirement.Controls.Add(this.button1);
            this.gpbCreationVirement.Controls.Add(this.dtpDateEmission);
            this.gpbCreationVirement.Controls.Add(this.label7);
            this.gpbCreationVirement.Controls.Add(this.txtMontantVirement);
            this.gpbCreationVirement.Controls.Add(this.txtNumeroCompte);
            this.gpbCreationVirement.Controls.Add(this.label6);
            this.gpbCreationVirement.Controls.Add(this.label5);
            this.gpbCreationVirement.Controls.Add(this.label4);
            this.gpbCreationVirement.Controls.Add(this.label3);
            this.gpbCreationVirement.Controls.Add(this.label2);
            this.gpbCreationVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCreationVirement.Location = new System.Drawing.Point(30, 40);
            this.gpbCreationVirement.Name = "gpbCreationVirement";
            this.gpbCreationVirement.Size = new System.Drawing.Size(312, 368);
            this.gpbCreationVirement.TabIndex = 1;
            this.gpbCreationVirement.TabStop = false;
            this.gpbCreationVirement.Text = "Création d\'un virement";
            // 
            // txtDestinataire
            // 
            this.txtDestinataire.Location = new System.Drawing.Point(109, 242);
            this.txtDestinataire.Name = "txtDestinataire";
            this.txtDestinataire.Size = new System.Drawing.Size(174, 22);
            this.txtDestinataire.TabIndex = 5;
            // 
            // ckbVirementAuto
            // 
            this.ckbVirementAuto.AutoSize = true;
            this.ckbVirementAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVirementAuto.Location = new System.Drawing.Point(9, 326);
            this.ckbVirementAuto.Name = "ckbVirementAuto";
            this.ckbVirementAuto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbVirementAuto.Size = new System.Drawing.Size(85, 17);
            this.ckbVirementAuto.TabIndex = 16;
            this.ckbVirementAuto.Text = "Automatique";
            this.ckbVirementAuto.UseVisualStyleBackColor = true;
            // 
            // cmbPrenomUser
            // 
            this.cmbPrenomUser.FormattingEnabled = true;
            this.cmbPrenomUser.Location = new System.Drawing.Point(109, 84);
            this.cmbPrenomUser.Name = "cmbPrenomUser";
            this.cmbPrenomUser.Size = new System.Drawing.Size(174, 24);
            this.cmbPrenomUser.TabIndex = 2;
            // 
            // cmbNomUser
            // 
            this.cmbNomUser.FormattingEnabled = true;
            this.cmbNomUser.Location = new System.Drawing.Point(109, 34);
            this.cmbNomUser.Name = "cmbNomUser";
            this.cmbNomUser.Size = new System.Drawing.Size(174, 24);
            this.cmbNomUser.TabIndex = 1;
            this.cmbNomUser.SelectedIndexChanged += new System.EventHandler(this.cmbNomUser_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDateEmission
            // 
            this.dtpDateEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEmission.Location = new System.Drawing.Point(109, 286);
            this.dtpDateEmission.Name = "dtpDateEmission";
            this.dtpDateEmission.Size = new System.Drawing.Size(174, 20);
            this.dtpDateEmission.TabIndex = 7;
            this.dtpDateEmission.Value = new System.DateTime(2011, 3, 20, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date d\'émission *";
            // 
            // txtMontantVirement
            // 
            this.txtMontantVirement.Location = new System.Drawing.Point(109, 192);
            this.txtMontantVirement.Name = "txtMontantVirement";
            this.txtMontantVirement.Size = new System.Drawing.Size(174, 22);
            this.txtMontantVirement.TabIndex = 4;
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.Location = new System.Drawing.Point(109, 138);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.Size = new System.Drawing.Size(174, 22);
            this.txtNumeroCompte.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Destinataire *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Montant *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numéro de compte *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom *";
            // 
            // gpbListeVirement
            // 
            this.gpbListeVirement.Controls.Add(this.btnAfficherVirement);
            this.gpbListeVirement.Controls.Add(this.txtRechercherVirement);
            this.gpbListeVirement.Controls.Add(this.label8);
            this.gpbListeVirement.Controls.Add(this.dgvListeVirement);
            this.gpbListeVirement.Location = new System.Drawing.Point(369, 32);
            this.gpbListeVirement.Name = "gpbListeVirement";
            this.gpbListeVirement.Size = new System.Drawing.Size(400, 382);
            this.gpbListeVirement.TabIndex = 2;
            this.gpbListeVirement.TabStop = false;
            // 
            // btnAfficherVirement
            // 
            this.btnAfficherVirement.Location = new System.Drawing.Point(229, 49);
            this.btnAfficherVirement.Name = "btnAfficherVirement";
            this.btnAfficherVirement.Size = new System.Drawing.Size(165, 23);
            this.btnAfficherVirement.TabIndex = 11;
            this.btnAfficherVirement.Text = "Afficher";
            this.btnAfficherVirement.UseVisualStyleBackColor = true;
            this.btnAfficherVirement.Click += new System.EventHandler(this.btnAfficherVirement_Click);
            // 
            // txtRechercherVirement
            // 
            this.txtRechercherVirement.Location = new System.Drawing.Point(12, 51);
            this.txtRechercherVirement.Name = "txtRechercherVirement";
            this.txtRechercherVirement.Size = new System.Drawing.Size(183, 20);
            this.txtRechercherVirement.TabIndex = 10;
            this.txtRechercherVirement.TextChanged += new System.EventHandler(this.txtRechercherVirement_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pour afficher les données d\'un client, entrez son numéro de compte";
            // 
            // dgvListeVirement
            // 
            this.dgvListeVirement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeVirement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numVir,
            this.numCompte,
            this.montantVir,
            this.destVir,
            this.dateVir});
            this.dgvListeVirement.Location = new System.Drawing.Point(12, 94);
            this.dgvListeVirement.Name = "dgvListeVirement";
            this.dgvListeVirement.Size = new System.Drawing.Size(382, 282);
            this.dgvListeVirement.TabIndex = 8;
            this.dgvListeVirement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeVirement_CellContentClick);
            // 
            // numVir
            // 
            this.numVir.HeaderText = "Numéro Vir.";
            this.numVir.Name = "numVir";
            this.numVir.ToolTipText = "Numéro du virement";
            // 
            // numCompte
            // 
            this.numCompte.HeaderText = "Compte Emet.";
            this.numCompte.Name = "numCompte";
            this.numCompte.ToolTipText = "Numéro de compte de l\'émetteur";
            // 
            // montantVir
            // 
            this.montantVir.HeaderText = "Montant";
            this.montantVir.Name = "montantVir";
            this.montantVir.ToolTipText = "Montant viré par l\'émetteur";
            // 
            // destVir
            // 
            this.destVir.HeaderText = "Compte Dest.";
            this.destVir.Name = "destVir";
            this.destVir.ToolTipText = "Numéro de compte du destinataire du virement";
            // 
            // dateVir
            // 
            this.dateVir.HeaderText = "Date";
            this.dateVir.Name = "dateVir";
            this.dateVir.ToolTipText = "Date d\'émission du virement";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(598, 420);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(165, 23);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // Virements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 498);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.gpbListeVirement);
            this.Controls.Add(this.gpbCreationVirement);
            this.Controls.Add(this.label1);
            this.Name = "Virements";
            this.Text = "GesB >> Virements";
            this.Load += new System.EventHandler(this.Virements_Load);
            this.gpbCreationVirement.ResumeLayout(false);
            this.gpbCreationVirement.PerformLayout();
            this.gpbListeVirement.ResumeLayout(false);
            this.gpbListeVirement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeVirement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbCreationVirement;
        private System.Windows.Forms.TextBox txtMontantVirement;
        private System.Windows.Forms.TextBox txtNumeroCompte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateEmission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbListeVirement;
        private System.Windows.Forms.DataGridView dgvListeVirement;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtRechercherVirement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAfficherVirement;
        private System.Windows.Forms.ComboBox cmbPrenomUser;
        private System.Windows.Forms.ComboBox cmbNomUser;
        private System.Windows.Forms.CheckBox ckbVirementAuto;
        private System.Windows.Forms.TextBox txtDestinataire;
        private System.Windows.Forms.DataGridViewTextBoxColumn numVir;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantVir;
        private System.Windows.Forms.DataGridViewTextBoxColumn destVir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVir;
    }
}