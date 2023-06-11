namespace GesB.views
{
    partial class frmClient
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
            this.gpbLoginCli = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            this.txtCodeSecret = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSolde = new System.Windows.Forms.Button();
            this.btnRetrait = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.gpbLoginCli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLoginCli
            // 
            this.gpbLoginCli.Controls.Add(this.btnValider);
            this.gpbLoginCli.Controls.Add(this.txtCodeSecret);
            this.gpbLoginCli.Controls.Add(this.txtNumCompte);
            this.gpbLoginCli.Controls.Add(this.label2);
            this.gpbLoginCli.Controls.Add(this.label1);
            this.gpbLoginCli.Location = new System.Drawing.Point(12, 32);
            this.gpbLoginCli.Name = "gpbLoginCli";
            this.gpbLoginCli.Size = new System.Drawing.Size(260, 218);
            this.gpbLoginCli.TabIndex = 0;
            this.gpbLoginCli.TabStop = false;
            this.gpbLoginCli.Text = "Identification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code secret";
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Location = new System.Drawing.Point(101, 38);
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(100, 20);
            this.txtNumCompte.TabIndex = 2;
            this.txtNumCompte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodeSecret
            // 
            this.txtCodeSecret.Location = new System.Drawing.Point(101, 91);
            this.txtCodeSecret.Name = "txtCodeSecret";
            this.txtCodeSecret.Size = new System.Drawing.Size(100, 20);
            this.txtCodeSecret.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(68, 153);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interface Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeconnexion);
            this.groupBox1.Controls.Add(this.btnRetrait);
            this.groupBox1.Controls.Add(this.btnSolde);
            this.groupBox1.Location = new System.Drawing.Point(341, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // btnSolde
            // 
            this.btnSolde.Location = new System.Drawing.Point(84, 29);
            this.btnSolde.Name = "btnSolde";
            this.btnSolde.Size = new System.Drawing.Size(106, 23);
            this.btnSolde.TabIndex = 0;
            this.btnSolde.Text = "Consulter le solde";
            this.btnSolde.UseVisualStyleBackColor = true;
            this.btnSolde.Click += new System.EventHandler(this.btnSolde_Click);
            // 
            // btnRetrait
            // 
            this.btnRetrait.Location = new System.Drawing.Point(84, 79);
            this.btnRetrait.Name = "btnRetrait";
            this.btnRetrait.Size = new System.Drawing.Size(106, 23);
            this.btnRetrait.TabIndex = 1;
            this.btnRetrait.Text = "Retirer de l\'argent";
            this.btnRetrait.UseVisualStyleBackColor = true;
            this.btnRetrait.Click += new System.EventHandler(this.btnRetrait_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(84, 129);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(106, 23);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbLoginCli);
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ges_B >>GAB";
            this.Load += new System.EventHandler(this.frmclient_Load);
            this.gpbLoginCli.ResumeLayout(false);
            this.gpbLoginCli.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLoginCli;
        private System.Windows.Forms.TextBox txtNumCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeSecret;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetrait;
        private System.Windows.Forms.Button btnSolde;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}