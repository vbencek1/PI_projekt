namespace FishingNet
{
    partial class FrmClanovi
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
            this.LblClanovi = new System.Windows.Forms.Label();
            this.LstClanova = new System.Windows.Forms.ListBox();
            this.LblPopisClanova = new System.Windows.Forms.Label();
            this.BtnDodajClana = new System.Windows.Forms.Button();
            this.LblPretraziClanove = new System.Windows.Forms.Label();
            this.TxtPretraziClanove = new System.Windows.Forms.TextBox();
            this.BtnPretraziClanove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnObrisiClana = new System.Windows.Forms.Button();
            this.BtnAzurirajClana = new System.Windows.Forms.Button();
            this.BtnOsvjezi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClanovi
            // 
            this.LblClanovi.AutoSize = true;
            this.LblClanovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClanovi.Location = new System.Drawing.Point(198, 32);
            this.LblClanovi.Name = "LblClanovi";
            this.LblClanovi.Size = new System.Drawing.Size(112, 31);
            this.LblClanovi.TabIndex = 0;
            this.LblClanovi.Text = "Članovi";
            // 
            // LstClanova
            // 
            this.LstClanova.FormattingEnabled = true;
            this.LstClanova.Location = new System.Drawing.Point(45, 121);
            this.LstClanova.Name = "LstClanova";
            this.LstClanova.Size = new System.Drawing.Size(165, 225);
            this.LstClanova.TabIndex = 1;
            this.LstClanova.SelectedIndexChanged += new System.EventHandler(this.LstClanova_SelectedIndexChanged);
            // 
            // LblPopisClanova
            // 
            this.LblPopisClanova.AutoSize = true;
            this.LblPopisClanova.Location = new System.Drawing.Point(42, 105);
            this.LblPopisClanova.Name = "LblPopisClanova";
            this.LblPopisClanova.Size = new System.Drawing.Size(77, 13);
            this.LblPopisClanova.TabIndex = 2;
            this.LblPopisClanova.Text = "Popis članova:";
            // 
            // BtnDodajClana
            // 
            this.BtnDodajClana.Location = new System.Drawing.Point(265, 247);
            this.BtnDodajClana.Name = "BtnDodajClana";
            this.BtnDodajClana.Size = new System.Drawing.Size(159, 29);
            this.BtnDodajClana.TabIndex = 3;
            this.BtnDodajClana.Text = "Dodaj člana";
            this.BtnDodajClana.UseVisualStyleBackColor = true;
            this.BtnDodajClana.Click += new System.EventHandler(this.BtnDodajClana_Click);
            // 
            // LblPretraziClanove
            // 
            this.LblPretraziClanove.AutoSize = true;
            this.LblPretraziClanove.Location = new System.Drawing.Point(13, 20);
            this.LblPretraziClanove.Name = "LblPretraziClanove";
            this.LblPretraziClanove.Size = new System.Drawing.Size(86, 13);
            this.LblPretraziClanove.TabIndex = 4;
            this.LblPretraziClanove.Text = "Pretraži članove:";
            // 
            // TxtPretraziClanove
            // 
            this.TxtPretraziClanove.Location = new System.Drawing.Point(16, 36);
            this.TxtPretraziClanove.Name = "TxtPretraziClanove";
            this.TxtPretraziClanove.Size = new System.Drawing.Size(166, 20);
            this.TxtPretraziClanove.TabIndex = 5;
            // 
            // BtnPretraziClanove
            // 
            this.BtnPretraziClanove.Location = new System.Drawing.Point(107, 62);
            this.BtnPretraziClanove.Name = "BtnPretraziClanove";
            this.BtnPretraziClanove.Size = new System.Drawing.Size(75, 23);
            this.BtnPretraziClanove.TabIndex = 6;
            this.BtnPretraziClanove.Text = "Pretraži";
            this.BtnPretraziClanove.UseVisualStyleBackColor = true;
            this.BtnPretraziClanove.Click += new System.EventHandler(this.BtnPretraziClanove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPretraziClanove);
            this.groupBox1.Controls.Add(this.TxtPretraziClanove);
            this.groupBox1.Controls.Add(this.LblPretraziClanove);
            this.groupBox1.Location = new System.Drawing.Point(242, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // BtnObrisiClana
            // 
            this.BtnObrisiClana.Location = new System.Drawing.Point(265, 317);
            this.BtnObrisiClana.Name = "BtnObrisiClana";
            this.BtnObrisiClana.Size = new System.Drawing.Size(159, 29);
            this.BtnObrisiClana.TabIndex = 8;
            this.BtnObrisiClana.Text = "Obriši člana";
            this.BtnObrisiClana.UseVisualStyleBackColor = true;
            this.BtnObrisiClana.Click += new System.EventHandler(this.BtnObrisiClana_Click);
            // 
            // BtnAzurirajClana
            // 
            this.BtnAzurirajClana.Location = new System.Drawing.Point(265, 282);
            this.BtnAzurirajClana.Name = "BtnAzurirajClana";
            this.BtnAzurirajClana.Size = new System.Drawing.Size(159, 29);
            this.BtnAzurirajClana.TabIndex = 9;
            this.BtnAzurirajClana.Text = "Ažuriraj člana";
            this.BtnAzurirajClana.UseVisualStyleBackColor = true;
            // 
            // BtnOsvjezi
            // 
            this.BtnOsvjezi.Location = new System.Drawing.Point(45, 352);
            this.BtnOsvjezi.Name = "BtnOsvjezi";
            this.BtnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.BtnOsvjezi.TabIndex = 7;
            this.BtnOsvjezi.Text = "Osvježi";
            this.BtnOsvjezi.UseVisualStyleBackColor = true;
            this.BtnOsvjezi.Click += new System.EventHandler(this.BtnOsvjezi_Click);
            // 
            // FrmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 437);
            this.Controls.Add(this.BtnOsvjezi);
            this.Controls.Add(this.BtnAzurirajClana);
            this.Controls.Add(this.BtnObrisiClana);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDodajClana);
            this.Controls.Add(this.LblPopisClanova);
            this.Controls.Add(this.LstClanova);
            this.Controls.Add(this.LblClanovi);
            this.Name = "FrmClanovi";
            this.Text = "FrmClanovi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClanovi;
        private System.Windows.Forms.ListBox LstClanova;
        private System.Windows.Forms.Label LblPopisClanova;
        private System.Windows.Forms.Button BtnDodajClana;
        private System.Windows.Forms.Label LblPretraziClanove;
        private System.Windows.Forms.TextBox TxtPretraziClanove;
        private System.Windows.Forms.Button BtnPretraziClanove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnObrisiClana;
        private System.Windows.Forms.Button BtnAzurirajClana;
        private System.Windows.Forms.Button BtnOsvjezi;
    }
}