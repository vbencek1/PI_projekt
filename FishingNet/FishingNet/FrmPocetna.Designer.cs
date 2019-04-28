namespace FishingNet
{
    partial class FrmPocetna
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
            this.BtnRibickiKlub = new System.Windows.Forms.Button();
            this.BtnClanovi = new System.Windows.Forms.Button();
            this.BtnNatjecanja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRibickiKlub
            // 
            this.BtnRibickiKlub.Location = new System.Drawing.Point(55, 41);
            this.BtnRibickiKlub.Name = "BtnRibickiKlub";
            this.BtnRibickiKlub.Size = new System.Drawing.Size(75, 23);
            this.BtnRibickiKlub.TabIndex = 0;
            this.BtnRibickiKlub.Text = "Ribički klub";
            this.BtnRibickiKlub.UseVisualStyleBackColor = true;
            // 
            // BtnClanovi
            // 
            this.BtnClanovi.Location = new System.Drawing.Point(55, 81);
            this.BtnClanovi.Name = "BtnClanovi";
            this.BtnClanovi.Size = new System.Drawing.Size(75, 23);
            this.BtnClanovi.TabIndex = 1;
            this.BtnClanovi.Text = "Članovi";
            this.BtnClanovi.UseVisualStyleBackColor = true;
            // 
            // BtnNatjecanja
            // 
            this.BtnNatjecanja.Location = new System.Drawing.Point(55, 122);
            this.BtnNatjecanja.Name = "BtnNatjecanja";
            this.BtnNatjecanja.Size = new System.Drawing.Size(75, 23);
            this.BtnNatjecanja.TabIndex = 2;
            this.BtnNatjecanja.Text = "Natjecanja";
            this.BtnNatjecanja.UseVisualStyleBackColor = true;
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNatjecanja);
            this.Controls.Add(this.BtnClanovi);
            this.Controls.Add(this.BtnRibickiKlub);
            this.Name = "FrmPocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRibickiKlub;
        private System.Windows.Forms.Button BtnClanovi;
        private System.Windows.Forms.Button BtnNatjecanja;
    }
}