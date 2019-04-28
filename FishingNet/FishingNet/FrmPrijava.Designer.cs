namespace FishingNet
{
    partial class FrmPrijava
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
            this.LblKorisnickoIme = new System.Windows.Forms.Label();
            this.LblLozinka = new System.Windows.Forms.Label();
            this.TxtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.BtnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKorisnickoIme
            // 
            this.LblKorisnickoIme.AutoSize = true;
            this.LblKorisnickoIme.Location = new System.Drawing.Point(209, 68);
            this.LblKorisnickoIme.Name = "LblKorisnickoIme";
            this.LblKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.LblKorisnickoIme.TabIndex = 0;
            this.LblKorisnickoIme.Text = "Korisničko ime:\r\n";
            // 
            // LblLozinka
            // 
            this.LblLozinka.AutoSize = true;
            this.LblLozinka.Location = new System.Drawing.Point(209, 119);
            this.LblLozinka.Name = "LblLozinka";
            this.LblLozinka.Size = new System.Drawing.Size(47, 13);
            this.LblLozinka.TabIndex = 1;
            this.LblLozinka.Text = "Lozinka:";
            // 
            // TxtKorisnickoIme
            // 
            this.TxtKorisnickoIme.Location = new System.Drawing.Point(212, 84);
            this.TxtKorisnickoIme.Name = "TxtKorisnickoIme";
            this.TxtKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.TxtKorisnickoIme.TabIndex = 2;
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.Location = new System.Drawing.Point(212, 135);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.Size = new System.Drawing.Size(100, 20);
            this.TxtLozinka.TabIndex = 3;
            // 
            // BtnPrijava
            // 
            this.BtnPrijava.Location = new System.Drawing.Point(212, 173);
            this.BtnPrijava.Name = "BtnPrijava";
            this.BtnPrijava.Size = new System.Drawing.Size(100, 23);
            this.BtnPrijava.TabIndex = 4;
            this.BtnPrijava.Text = "Prijava";
            this.BtnPrijava.UseVisualStyleBackColor = true;
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 290);
            this.Controls.Add(this.BtnPrijava);
            this.Controls.Add(this.TxtLozinka);
            this.Controls.Add(this.TxtKorisnickoIme);
            this.Controls.Add(this.LblLozinka);
            this.Controls.Add(this.LblKorisnickoIme);
            this.Name = "FrmPrijava";
            this.Text = "FrmPrijava";
            this.Load += new System.EventHandler(this.FrmPrijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKorisnickoIme;
        private System.Windows.Forms.Label LblLozinka;
        private System.Windows.Forms.TextBox TxtKorisnickoIme;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.Button BtnPrijava;
    }
}

