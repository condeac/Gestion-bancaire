namespace GesB
{
    partial class PretEmprunt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbListePretEmprunt = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dgvListePretEmprunt = new System.Windows.Forms.DataGridView();
            this.numPret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbCreationPretEmprunt = new System.Windows.Forms.GroupBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.dtpDateEcheance = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateAttribution = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTauxEmprunt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontantEmprunte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrenomUser = new System.Windows.Forms.ComboBox();
            this.cmbNomUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbListePretEmprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePretEmprunt)).BeginInit();
            this.gpbCreationPretEmprunt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renseignez ce formulaire pour Créer / Afficher les prets / emprunts";
            // 
            // gpbListePretEmprunt
            // 
            this.gpbListePretEmprunt.Controls.Add(this.btnSupprimer);
            this.gpbListePretEmprunt.Controls.Add(this.btnModifier);
            this.gpbListePretEmprunt.Controls.Add(this.btnFermer);
            this.gpbListePretEmprunt.Controls.Add(this.dgvListePretEmprunt);
            this.gpbListePretEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbListePretEmprunt.Location = new System.Drawing.Point(12, 260);
            this.gpbListePretEmprunt.Name = "gpbListePretEmprunt";
            this.gpbListePretEmprunt.Size = new System.Drawing.Size(715, 226);
            this.gpbListePretEmprunt.TabIndex = 1;
            this.gpbListePretEmprunt.TabStop = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(297, 178);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(165, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(84, 178);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(165, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(513, 178);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(165, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // dgvListePretEmprunt
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListePretEmprunt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListePretEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePretEmprunt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPret,
            this.nomCli,
            this.prenomCli,
            this.montantEmp,
            this.tauxEmp,
            this.dateEmp,
            this.dateFinEmp});
            this.dgvListePretEmprunt.Location = new System.Drawing.Point(9, 21);
            this.dgvListePretEmprunt.Name = "dgvListePretEmprunt";
            this.dgvListePretEmprunt.Size = new System.Drawing.Size(700, 133);
            this.dgvListePretEmprunt.TabIndex = 0;
            // 
            // numPret
            // 
            this.numPret.HeaderText = "Num. prêt";
            this.numPret.Name = "numPret";
            this.numPret.ReadOnly = true;
            this.numPret.ToolTipText = "Numéro du prêt";
            // 
            // nomCli
            // 
            this.nomCli.HeaderText = "Nom";
            this.nomCli.Name = "nomCli";
            // 
            // prenomCli
            // 
            this.prenomCli.HeaderText = "Prénom";
            this.prenomCli.Name = "prenomCli";
            this.prenomCli.ToolTipText = "Prénom du client";
            // 
            // montantEmp
            // 
            this.montantEmp.HeaderText = "Montant";
            this.montantEmp.Name = "montantEmp";
            this.montantEmp.ToolTipText = "Montant emprunté";
            // 
            // tauxEmp
            // 
            this.tauxEmp.HeaderText = "Taux";
            this.tauxEmp.Name = "tauxEmp";
            this.tauxEmp.ToolTipText = "Taux d\'emprunt";
            // 
            // dateEmp
            // 
            this.dateEmp.HeaderText = "Date attrib.";
            this.dateEmp.Name = "dateEmp";
            this.dateEmp.ToolTipText = "Date d\'attribution du prêt";
            // 
            // dateFinEmp
            // 
            this.dateFinEmp.HeaderText = "Date éch.";
            this.dateFinEmp.Name = "dateFinEmp";
            this.dateFinEmp.ToolTipText = "Date d\'échéance de l\'emprunt";
            // 
            // gpbCreationPretEmprunt
            // 
            this.gpbCreationPretEmprunt.Controls.Add(this.btnCreer);
            this.gpbCreationPretEmprunt.Controls.Add(this.dtpDateEcheance);
            this.gpbCreationPretEmprunt.Controls.Add(this.label7);
            this.gpbCreationPretEmprunt.Controls.Add(this.dtpDateAttribution);
            this.gpbCreationPretEmprunt.Controls.Add(this.label6);
            this.gpbCreationPretEmprunt.Controls.Add(this.txtTauxEmprunt);
            this.gpbCreationPretEmprunt.Controls.Add(this.label5);
            this.gpbCreationPretEmprunt.Controls.Add(this.txtMontantEmprunte);
            this.gpbCreationPretEmprunt.Controls.Add(this.label4);
            this.gpbCreationPretEmprunt.Controls.Add(this.cmbPrenomUser);
            this.gpbCreationPretEmprunt.Controls.Add(this.cmbNomUser);
            this.gpbCreationPretEmprunt.Controls.Add(this.label3);
            this.gpbCreationPretEmprunt.Controls.Add(this.label2);
            this.gpbCreationPretEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCreationPretEmprunt.Location = new System.Drawing.Point(12, 50);
            this.gpbCreationPretEmprunt.Name = "gpbCreationPretEmprunt";
            this.gpbCreationPretEmprunt.Size = new System.Drawing.Size(715, 204);
            this.gpbCreationPretEmprunt.TabIndex = 2;
            this.gpbCreationPretEmprunt.TabStop = false;
            this.gpbCreationPretEmprunt.Text = "Création du prêt / emprunt";
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(393, 168);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(143, 23);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // dtpDateEcheance
            // 
            this.dtpDateEcheance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEcheance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEcheance.Location = new System.Drawing.Point(548, 123);
            this.dtpDateEcheance.Name = "dtpDateEcheance";
            this.dtpDateEcheance.Size = new System.Drawing.Size(130, 20);
            this.dtpDateEcheance.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date d\'échéance";
            // 
            // dtpDateAttribution
            // 
            this.dtpDateAttribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAttribution.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAttribution.Location = new System.Drawing.Point(128, 128);
            this.dtpDateAttribution.Name = "dtpDateAttribution";
            this.dtpDateAttribution.Size = new System.Drawing.Size(130, 20);
            this.dtpDateAttribution.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date d\'attribution";
            // 
            // txtTauxEmprunt
            // 
            this.txtTauxEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTauxEmprunt.Location = new System.Drawing.Point(548, 74);
            this.txtTauxEmprunt.Name = "txtTauxEmprunt";
            this.txtTauxEmprunt.Size = new System.Drawing.Size(130, 20);
            this.txtTauxEmprunt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Taux d\'emprunt";
            // 
            // txtMontantEmprunte
            // 
            this.txtMontantEmprunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontantEmprunte.Location = new System.Drawing.Point(128, 79);
            this.txtMontantEmprunte.Name = "txtMontantEmprunte";
            this.txtMontantEmprunte.Size = new System.Drawing.Size(130, 20);
            this.txtMontantEmprunte.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Montant emprunté";
            // 
            // cmbPrenomUser
            // 
            this.cmbPrenomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrenomUser.FormattingEnabled = true;
            this.cmbPrenomUser.Location = new System.Drawing.Point(548, 28);
            this.cmbPrenomUser.Name = "cmbPrenomUser";
            this.cmbPrenomUser.Size = new System.Drawing.Size(130, 21);
            this.cmbPrenomUser.TabIndex = 3;
            // 
            // cmbNomUser
            // 
            this.cmbNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomUser.FormattingEnabled = true;
            this.cmbNomUser.Location = new System.Drawing.Point(128, 33);
            this.cmbNomUser.Name = "cmbNomUser";
            this.cmbNomUser.Size = new System.Drawing.Size(130, 21);
            this.cmbNomUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prénom du client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom du client";
            // 
            // PretEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 529);
            this.Controls.Add(this.gpbCreationPretEmprunt);
            this.Controls.Add(this.gpbListePretEmprunt);
            this.Controls.Add(this.label1);
            this.Name = "PretEmprunt";
            this.Text = "GesB >> Prêts / Emprunts";
            this.gpbListePretEmprunt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePretEmprunt)).EndInit();
            this.gpbCreationPretEmprunt.ResumeLayout(false);
            this.gpbCreationPretEmprunt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbListePretEmprunt;
        private System.Windows.Forms.GroupBox gpbCreationPretEmprunt;
        private System.Windows.Forms.ComboBox cmbPrenomUser;
        private System.Windows.Forms.ComboBox cmbNomUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontantEmprunte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTauxEmprunt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateAttribution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateEcheance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.DataGridView dgvListePretEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPret;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinEmp;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
    }
}