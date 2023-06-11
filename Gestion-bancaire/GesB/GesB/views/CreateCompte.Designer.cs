namespace GesB
{
    partial class CreateCompte
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
            this.gpbIdentiteTitulaire = new System.Windows.Forms.GroupBox();
            this.cmbTypePiece = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdresseUser = new System.Windows.Forms.TextBox();
            this.txtTelephoneUser = new System.Windows.Forms.TextBox();
            this.txtPrenomUser = new System.Windows.Forms.TextBox();
            this.txtNomUser = new System.Windows.Forms.TextBox();
            this.txtNumPieceUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbTypeCompte = new System.Windows.Forms.GroupBox();
            this.rdbCompteEntreprise = new System.Windows.Forms.RadioButton();
            this.rdbCompteBloque = new System.Windows.Forms.RadioButton();
            this.rdbCompteDecouvert = new System.Windows.Forms.RadioButton();
            this.rdbCompteEVP = new System.Windows.Forms.RadioButton();
            this.rdbCompteCourant = new System.Windows.Forms.RadioButton();
            this.gpbInfoCompte = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDateDeblocage = new System.Windows.Forms.DateTimePicker();
            this.txtCodeSecretCompte = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSeuilDecouverture = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPeriodeVersement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoldeInitialCompte = new System.Windows.Forms.TextBox();
            this.txtNumGuichet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.bntFermer = new System.Windows.Forms.Button();
            this.gpbIdentiteTitulaire.SuspendLayout();
            this.gpbTypeCompte.SuspendLayout();
            this.gpbInfoCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remplissez le formulaire  suivant";
            // 
            // gpbIdentiteTitulaire
            // 
            this.gpbIdentiteTitulaire.Controls.Add(this.cmbTypePiece);
            this.gpbIdentiteTitulaire.Controls.Add(this.label12);
            this.gpbIdentiteTitulaire.Controls.Add(this.txtAdresseUser);
            this.gpbIdentiteTitulaire.Controls.Add(this.txtTelephoneUser);
            this.gpbIdentiteTitulaire.Controls.Add(this.txtPrenomUser);
            this.gpbIdentiteTitulaire.Controls.Add(this.txtNomUser);
            this.gpbIdentiteTitulaire.Controls.Add(this.txtNumPieceUser);
            this.gpbIdentiteTitulaire.Controls.Add(this.label6);
            this.gpbIdentiteTitulaire.Controls.Add(this.label5);
            this.gpbIdentiteTitulaire.Controls.Add(this.label4);
            this.gpbIdentiteTitulaire.Controls.Add(this.label3);
            this.gpbIdentiteTitulaire.Controls.Add(this.label2);
            this.gpbIdentiteTitulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbIdentiteTitulaire.Location = new System.Drawing.Point(12, 111);
            this.gpbIdentiteTitulaire.Name = "gpbIdentiteTitulaire";
            this.gpbIdentiteTitulaire.Size = new System.Drawing.Size(284, 273);
            this.gpbIdentiteTitulaire.TabIndex = 1;
            this.gpbIdentiteTitulaire.TabStop = false;
            this.gpbIdentiteTitulaire.Text = "Identité du titulaire";
            // 
            // cmbTypePiece
            // 
            this.cmbTypePiece.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbTypePiece.FormattingEnabled = true;
            this.cmbTypePiece.Location = new System.Drawing.Point(122, 69);
            this.cmbTypePiece.Name = "cmbTypePiece";
            this.cmbTypePiece.Size = new System.Drawing.Size(139, 24);
            this.cmbTypePiece.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Type de pièce *";
            // 
            // txtAdresseUser
            // 
            this.txtAdresseUser.Location = new System.Drawing.Point(122, 231);
            this.txtAdresseUser.Name = "txtAdresseUser";
            this.txtAdresseUser.Size = new System.Drawing.Size(139, 22);
            this.txtAdresseUser.TabIndex = 10;
            // 
            // txtTelephoneUser
            // 
            this.txtTelephoneUser.Location = new System.Drawing.Point(122, 193);
            this.txtTelephoneUser.Name = "txtTelephoneUser";
            this.txtTelephoneUser.Size = new System.Drawing.Size(139, 22);
            this.txtTelephoneUser.TabIndex = 9;
            // 
            // txtPrenomUser
            // 
            this.txtPrenomUser.Location = new System.Drawing.Point(122, 152);
            this.txtPrenomUser.Name = "txtPrenomUser";
            this.txtPrenomUser.Size = new System.Drawing.Size(139, 22);
            this.txtPrenomUser.TabIndex = 8;
            // 
            // txtNomUser
            // 
            this.txtNomUser.Location = new System.Drawing.Point(122, 110);
            this.txtNomUser.Name = "txtNomUser";
            this.txtNomUser.Size = new System.Drawing.Size(139, 22);
            this.txtNomUser.TabIndex = 7;
            // 
            // txtNumPieceUser
            // 
            this.txtNumPieceUser.Location = new System.Drawing.Point(122, 33);
            this.txtNumPieceUser.Name = "txtNumPieceUser";
            this.txtNumPieceUser.Size = new System.Drawing.Size(139, 22);
            this.txtNumPieceUser.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adresse *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Téléphone *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numéro de pièce *";
            // 
            // gpbTypeCompte
            // 
            this.gpbTypeCompte.Controls.Add(this.rdbCompteEntreprise);
            this.gpbTypeCompte.Controls.Add(this.rdbCompteBloque);
            this.gpbTypeCompte.Controls.Add(this.rdbCompteDecouvert);
            this.gpbTypeCompte.Controls.Add(this.rdbCompteEVP);
            this.gpbTypeCompte.Controls.Add(this.rdbCompteCourant);
            this.gpbTypeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTypeCompte.Location = new System.Drawing.Point(21, 32);
            this.gpbTypeCompte.Name = "gpbTypeCompte";
            this.gpbTypeCompte.Size = new System.Drawing.Size(635, 62);
            this.gpbTypeCompte.TabIndex = 2;
            this.gpbTypeCompte.TabStop = false;
            this.gpbTypeCompte.Text = "Type de compte";
            // 
            // rdbCompteEntreprise
            // 
            this.rdbCompteEntreprise.AutoSize = true;
            this.rdbCompteEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteEntreprise.Location = new System.Drawing.Point(506, 30);
            this.rdbCompteEntreprise.Name = "rdbCompteEntreprise";
            this.rdbCompteEntreprise.Size = new System.Drawing.Size(110, 17);
            this.rdbCompteEntreprise.TabIndex = 4;
            this.rdbCompteEntreprise.TabStop = true;
            this.rdbCompteEntreprise.Text = "Compte entreprise";
            this.rdbCompteEntreprise.UseVisualStyleBackColor = true;
            this.rdbCompteEntreprise.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdbCompteBloque
            // 
            this.rdbCompteBloque.AutoSize = true;
            this.rdbCompteBloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteBloque.Location = new System.Drawing.Point(385, 30);
            this.rdbCompteBloque.Name = "rdbCompteBloque";
            this.rdbCompteBloque.Size = new System.Drawing.Size(96, 17);
            this.rdbCompteBloque.TabIndex = 3;
            this.rdbCompteBloque.TabStop = true;
            this.rdbCompteBloque.Text = "Compte bloqué";
            this.rdbCompteBloque.UseVisualStyleBackColor = true;
            this.rdbCompteBloque.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdbCompteDecouvert
            // 
            this.rdbCompteDecouvert.AutoSize = true;
            this.rdbCompteDecouvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteDecouvert.Location = new System.Drawing.Point(268, 30);
            this.rdbCompteDecouvert.Name = "rdbCompteDecouvert";
            this.rdbCompteDecouvert.Size = new System.Drawing.Size(112, 17);
            this.rdbCompteDecouvert.TabIndex = 2;
            this.rdbCompteDecouvert.TabStop = true;
            this.rdbCompteDecouvert.Text = "Compte découvert";
            this.rdbCompteDecouvert.UseVisualStyleBackColor = true;
            this.rdbCompteDecouvert.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbCompteEVP
            // 
            this.rdbCompteEVP.AutoSize = true;
            this.rdbCompteEVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteEVP.Location = new System.Drawing.Point(150, 30);
            this.rdbCompteEVP.Name = "rdbCompteEVP";
            this.rdbCompteEVP.Size = new System.Drawing.Size(91, 17);
            this.rdbCompteEVP.TabIndex = 1;
            this.rdbCompteEVP.TabStop = true;
            this.rdbCompteEVP.Text = "Compte E.V.P";
            this.rdbCompteEVP.UseVisualStyleBackColor = true;
            this.rdbCompteEVP.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbCompteCourant
            // 
            this.rdbCompteCourant.AutoSize = true;
            this.rdbCompteCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteCourant.Location = new System.Drawing.Point(40, 30);
            this.rdbCompteCourant.Name = "rdbCompteCourant";
            this.rdbCompteCourant.Size = new System.Drawing.Size(100, 17);
            this.rdbCompteCourant.TabIndex = 0;
            this.rdbCompteCourant.TabStop = true;
            this.rdbCompteCourant.Text = "Compte courant";
            this.rdbCompteCourant.UseVisualStyleBackColor = true;
            this.rdbCompteCourant.CheckedChanged += new System.EventHandler(this.rdbCompteCourant_CheckedChanged);
            // 
            // gpbInfoCompte
            // 
            this.gpbInfoCompte.Controls.Add(this.label14);
            this.gpbInfoCompte.Controls.Add(this.dtpDateDeblocage);
            this.gpbInfoCompte.Controls.Add(this.txtCodeSecretCompte);
            this.gpbInfoCompte.Controls.Add(this.label13);
            this.gpbInfoCompte.Controls.Add(this.txtSeuilDecouverture);
            this.gpbInfoCompte.Controls.Add(this.label11);
            this.gpbInfoCompte.Controls.Add(this.txtPeriodeVersement);
            this.gpbInfoCompte.Controls.Add(this.label7);
            this.gpbInfoCompte.Controls.Add(this.txtSoldeInitialCompte);
            this.gpbInfoCompte.Controls.Add(this.txtNumGuichet);
            this.gpbInfoCompte.Controls.Add(this.label10);
            this.gpbInfoCompte.Controls.Add(this.label9);
            this.gpbInfoCompte.Controls.Add(this.label8);
            this.gpbInfoCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoCompte.Location = new System.Drawing.Point(383, 111);
            this.gpbInfoCompte.Name = "gpbInfoCompte";
            this.gpbInfoCompte.Size = new System.Drawing.Size(273, 302);
            this.gpbInfoCompte.TabIndex = 3;
            this.gpbInfoCompte.TabStop = false;
            this.gpbInfoCompte.Text = "Informations de compte";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "(en mois)";
            // 
            // dtpDateDeblocage
            // 
            this.dtpDateDeblocage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDeblocage.Location = new System.Drawing.Point(144, 225);
            this.dtpDateDeblocage.Name = "dtpDateDeblocage";
            this.dtpDateDeblocage.Size = new System.Drawing.Size(110, 22);
            this.dtpDateDeblocage.TabIndex = 16;
            this.dtpDateDeblocage.Value = new System.DateTime(2011, 3, 20, 0, 0, 0, 0);
            // 
            // txtCodeSecretCompte
            // 
            this.txtCodeSecretCompte.Location = new System.Drawing.Point(144, 117);
            this.txtCodeSecretCompte.Name = "txtCodeSecretCompte";
            this.txtCodeSecretCompte.Size = new System.Drawing.Size(110, 22);
            this.txtCodeSecretCompte.TabIndex = 13;
            this.txtCodeSecretCompte.TextChanged += new System.EventHandler(this.txtCodeSecretCompte_TextChanged);
            this.txtCodeSecretCompte.Enter += new System.EventHandler(this.txtCodeSecretCompte_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Date de déblocage";
            // 
            // txtSeuilDecouverture
            // 
            this.txtSeuilDecouverture.Location = new System.Drawing.Point(144, 188);
            this.txtSeuilDecouverture.Name = "txtSeuilDecouverture";
            this.txtSeuilDecouverture.Size = new System.Drawing.Size(110, 22);
            this.txtSeuilDecouverture.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Seuil de découverture";
            // 
            // txtPeriodeVersement
            // 
            this.txtPeriodeVersement.Location = new System.Drawing.Point(144, 152);
            this.txtPeriodeVersement.Name = "txtPeriodeVersement";
            this.txtPeriodeVersement.Size = new System.Drawing.Size(110, 22);
            this.txtPeriodeVersement.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Période de versement";
            // 
            // txtSoldeInitialCompte
            // 
            this.txtSoldeInitialCompte.Location = new System.Drawing.Point(144, 76);
            this.txtSoldeInitialCompte.Name = "txtSoldeInitialCompte";
            this.txtSoldeInitialCompte.Size = new System.Drawing.Size(110, 22);
            this.txtSoldeInitialCompte.TabIndex = 12;
            this.txtSoldeInitialCompte.TextChanged += new System.EventHandler(this.txtSoldeInitialCompte_TextChanged);
            // 
            // txtNumGuichet
            // 
            this.txtNumGuichet.Location = new System.Drawing.Point(144, 37);
            this.txtNumGuichet.Name = "txtNumGuichet";
            this.txtNumGuichet.Size = new System.Drawing.Size(110, 22);
            this.txtNumGuichet.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Code secret";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Solde initial *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numéro de guichet";
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Location = new System.Drawing.Point(289, 419);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(169, 23);
            this.btnCreerCompte.TabIndex = 17;
            this.btnCreerCompte.Text = "Creer";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // bntFermer
            // 
            this.bntFermer.Location = new System.Drawing.Point(488, 419);
            this.bntFermer.Name = "bntFermer";
            this.bntFermer.Size = new System.Drawing.Size(169, 23);
            this.bntFermer.TabIndex = 18;
            this.bntFermer.Text = "Fermer";
            this.bntFermer.UseVisualStyleBackColor = true;
            this.bntFermer.Click += new System.EventHandler(this.bntFermer_Click);
            // 
            // CreateCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 489);
            this.Controls.Add(this.bntFermer);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.gpbInfoCompte);
            this.Controls.Add(this.gpbTypeCompte);
            this.Controls.Add(this.gpbIdentiteTitulaire);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateCompte";
            this.Text = "GestB >> Création de compte";
            this.Load += new System.EventHandler(this.CreateCompte_Load);
            this.gpbIdentiteTitulaire.ResumeLayout(false);
            this.gpbIdentiteTitulaire.PerformLayout();
            this.gpbTypeCompte.ResumeLayout(false);
            this.gpbTypeCompte.PerformLayout();
            this.gpbInfoCompte.ResumeLayout(false);
            this.gpbInfoCompte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbIdentiteTitulaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresseUser;
        private System.Windows.Forms.TextBox txtTelephoneUser;
        private System.Windows.Forms.TextBox txtPrenomUser;
        private System.Windows.Forms.TextBox txtNomUser;
        private System.Windows.Forms.TextBox txtNumPieceUser;
        private System.Windows.Forms.GroupBox gpbTypeCompte;
        private System.Windows.Forms.RadioButton rdbCompteBloque;
        private System.Windows.Forms.RadioButton rdbCompteDecouvert;
        private System.Windows.Forms.RadioButton rdbCompteEVP;
        private System.Windows.Forms.RadioButton rdbCompteCourant;
        private System.Windows.Forms.RadioButton rdbCompteEntreprise;
        private System.Windows.Forms.GroupBox gpbInfoCompte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoldeInitialCompte;
        private System.Windows.Forms.TextBox txtNumGuichet;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Button bntFermer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTypePiece;
        private System.Windows.Forms.TextBox txtPeriodeVersement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeuilDecouverture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodeSecretCompte;
        private System.Windows.Forms.DateTimePicker dtpDateDeblocage;
        private System.Windows.Forms.Label label14;
    }
}