namespace GesB
{
    partial class CreditDebit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDebiter = new System.Windows.Forms.Button();
            this.btnCrediter = new System.Windows.Forms.Button();
            this.txtMontantCrediterDebite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFremer = new System.Windows.Forms.Button();
            this.txtNumeroCompte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renseignez ce formulaire pour Créditer ou Débiter un compte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroCompte);
            this.groupBox1.Controls.Add(this.btnDebiter);
            this.groupBox1.Controls.Add(this.btnCrediter);
            this.groupBox1.Controls.Add(this.txtMontantCrediterDebite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(137, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDebiter
            // 
            this.btnDebiter.Location = new System.Drawing.Point(249, 134);
            this.btnDebiter.Name = "btnDebiter";
            this.btnDebiter.Size = new System.Drawing.Size(165, 23);
            this.btnDebiter.TabIndex = 4;
            this.btnDebiter.Text = "Débiter";
            this.btnDebiter.UseVisualStyleBackColor = true;
            this.btnDebiter.Click += new System.EventHandler(this.btnDebiter_Click);
            // 
            // btnCrediter
            // 
            this.btnCrediter.Location = new System.Drawing.Point(22, 134);
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(165, 23);
            this.btnCrediter.TabIndex = 3;
            this.btnCrediter.Text = "Créditer";
            this.btnCrediter.UseVisualStyleBackColor = true;
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // txtMontantCrediterDebite
            // 
            this.txtMontantCrediterDebite.Location = new System.Drawing.Point(178, 77);
            this.txtMontantCrediterDebite.Name = "txtMontantCrediterDebite";
            this.txtMontantCrediterDebite.Size = new System.Drawing.Size(200, 20);
            this.txtMontantCrediterDebite.TabIndex = 2;
            this.txtMontantCrediterDebite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Montant à créditer / débiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numéro de compte";
            // 
            // btnFremer
            // 
            this.btnFremer.Location = new System.Drawing.Point(459, 351);
            this.btnFremer.Name = "btnFremer";
            this.btnFremer.Size = new System.Drawing.Size(165, 23);
            this.btnFremer.TabIndex = 5;
            this.btnFremer.Text = "Fermer";
            this.btnFremer.UseVisualStyleBackColor = true;
            this.btnFremer.Click += new System.EventHandler(this.btnFremer_Click);
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.Location = new System.Drawing.Point(178, 26);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroCompte.TabIndex = 1;
            // 
            // CreditDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 494);
            this.Controls.Add(this.btnFremer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreditDebit";
            this.Text = "GesB >> Credit / Debit";
            this.Load += new System.EventHandler(this.CreditDebit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontantCrediterDebite;
        private System.Windows.Forms.Button btnDebiter;
        private System.Windows.Forms.Button btnCrediter;
        private System.Windows.Forms.Button btnFremer;
        private System.Windows.Forms.TextBox txtNumeroCompte;
    }
}