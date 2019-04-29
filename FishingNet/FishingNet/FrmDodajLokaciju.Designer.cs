namespace FishingNet
{
    partial class FrmDodajLokaciju
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
            this.LstLokacija = new System.Windows.Forms.ListBox();
            this.LblPopisLokacija = new System.Windows.Forms.Label();
            this.BtnDodajLokaciju = new System.Windows.Forms.Button();
            this.BtnObrisiLokaciju = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtNazivRijeke = new System.Windows.Forms.TextBox();
            this.LblNazivRijeke = new System.Windows.Forms.Label();
            this.LblDuljinaRijeke = new System.Windows.Forms.Label();
            this.LblGradLokacija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstLokacija
            // 
            this.LstLokacija.FormattingEnabled = true;
            this.LstLokacija.Location = new System.Drawing.Point(29, 98);
            this.LstLokacija.Name = "LstLokacija";
            this.LstLokacija.Size = new System.Drawing.Size(180, 264);
            this.LstLokacija.TabIndex = 0;
            // 
            // LblPopisLokacija
            // 
            this.LblPopisLokacija.AutoSize = true;
            this.LblPopisLokacija.Location = new System.Drawing.Point(26, 82);
            this.LblPopisLokacija.Name = "LblPopisLokacija";
            this.LblPopisLokacija.Size = new System.Drawing.Size(75, 13);
            this.LblPopisLokacija.TabIndex = 1;
            this.LblPopisLokacija.Text = "Popis lokacija:";
            // 
            // BtnDodajLokaciju
            // 
            this.BtnDodajLokaciju.Location = new System.Drawing.Point(435, 224);
            this.BtnDodajLokaciju.Name = "BtnDodajLokaciju";
            this.BtnDodajLokaciju.Size = new System.Drawing.Size(107, 23);
            this.BtnDodajLokaciju.TabIndex = 2;
            this.BtnDodajLokaciju.Text = "Dodaj lokaciju";
            this.BtnDodajLokaciju.UseVisualStyleBackColor = true;
            // 
            // BtnObrisiLokaciju
            // 
            this.BtnObrisiLokaciju.Location = new System.Drawing.Point(215, 98);
            this.BtnObrisiLokaciju.Name = "BtnObrisiLokaciju";
            this.BtnObrisiLokaciju.Size = new System.Drawing.Size(107, 23);
            this.BtnObrisiLokaciju.TabIndex = 3;
            this.BtnObrisiLokaciju.Text = "Obriši lokaciju";
            this.BtnObrisiLokaciju.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 5;
            // 
            // TxtNazivRijeke
            // 
            this.TxtNazivRijeke.Location = new System.Drawing.Point(382, 100);
            this.TxtNazivRijeke.Name = "TxtNazivRijeke";
            this.TxtNazivRijeke.Size = new System.Drawing.Size(160, 20);
            this.TxtNazivRijeke.TabIndex = 6;
            // 
            // LblNazivRijeke
            // 
            this.LblNazivRijeke.AutoSize = true;
            this.LblNazivRijeke.Location = new System.Drawing.Point(379, 84);
            this.LblNazivRijeke.Name = "LblNazivRijeke";
            this.LblNazivRijeke.Size = new System.Drawing.Size(65, 13);
            this.LblNazivRijeke.TabIndex = 7;
            this.LblNazivRijeke.Text = "Naziv rijeke:";
            // 
            // LblDuljinaRijeke
            // 
            this.LblDuljinaRijeke.AutoSize = true;
            this.LblDuljinaRijeke.Location = new System.Drawing.Point(379, 133);
            this.LblDuljinaRijeke.Name = "LblDuljinaRijeke";
            this.LblDuljinaRijeke.Size = new System.Drawing.Size(70, 13);
            this.LblDuljinaRijeke.TabIndex = 8;
            this.LblDuljinaRijeke.Text = "Duljina rijeke:";
            // 
            // LblGradLokacija
            // 
            this.LblGradLokacija.AutoSize = true;
            this.LblGradLokacija.Location = new System.Drawing.Point(379, 182);
            this.LblGradLokacija.Name = "LblGradLokacija";
            this.LblGradLokacija.Size = new System.Drawing.Size(33, 13);
            this.LblGradLokacija.TabIndex = 9;
            this.LblGradLokacija.Text = "Grad:";
            // 
            // FrmDodajLokaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblGradLokacija);
            this.Controls.Add(this.LblDuljinaRijeke);
            this.Controls.Add(this.LblNazivRijeke);
            this.Controls.Add(this.TxtNazivRijeke);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnObrisiLokaciju);
            this.Controls.Add(this.BtnDodajLokaciju);
            this.Controls.Add(this.LblPopisLokacija);
            this.Controls.Add(this.LstLokacija);
            this.Name = "FrmDodajLokaciju";
            this.Text = "FrmDodajLokaciju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstLokacija;
        private System.Windows.Forms.Label LblPopisLokacija;
        private System.Windows.Forms.Button BtnDodajLokaciju;
        private System.Windows.Forms.Button BtnObrisiLokaciju;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtNazivRijeke;
        private System.Windows.Forms.Label LblNazivRijeke;
        private System.Windows.Forms.Label LblDuljinaRijeke;
        private System.Windows.Forms.Label LblGradLokacija;
    }
}