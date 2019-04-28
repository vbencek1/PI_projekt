namespace FishingNet
{
    partial class FrmProglasiPobjednika
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
            this.LblProglasenjePobjednika = new System.Windows.Forms.Label();
            this.LblOdabirNatjecanja = new System.Windows.Forms.Label();
            this.ComboOdabirNatjecanja = new System.Windows.Forms.ComboBox();
            this.LblOdaberiPobjednika = new System.Windows.Forms.Label();
            this.ComboOdaberiPobjednika = new System.Windows.Forms.ComboBox();
            this.BtnObavijestiPobjednika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblProglasenjePobjednika
            // 
            this.LblProglasenjePobjednika.AutoSize = true;
            this.LblProglasenjePobjednika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProglasenjePobjednika.Location = new System.Drawing.Point(112, 44);
            this.LblProglasenjePobjednika.Name = "LblProglasenjePobjednika";
            this.LblProglasenjePobjednika.Size = new System.Drawing.Size(317, 31);
            this.LblProglasenjePobjednika.TabIndex = 0;
            this.LblProglasenjePobjednika.Text = "Proglašenje pobjednika";
            // 
            // LblOdabirNatjecanja
            // 
            this.LblOdabirNatjecanja.AutoSize = true;
            this.LblOdabirNatjecanja.Location = new System.Drawing.Point(170, 115);
            this.LblOdabirNatjecanja.Name = "LblOdabirNatjecanja";
            this.LblOdabirNatjecanja.Size = new System.Drawing.Size(99, 13);
            this.LblOdabirNatjecanja.TabIndex = 1;
            this.LblOdabirNatjecanja.Text = "Odaberi natjecanje:";
            // 
            // ComboOdabirNatjecanja
            // 
            this.ComboOdabirNatjecanja.FormattingEnabled = true;
            this.ComboOdabirNatjecanja.Location = new System.Drawing.Point(173, 131);
            this.ComboOdabirNatjecanja.Name = "ComboOdabirNatjecanja";
            this.ComboOdabirNatjecanja.Size = new System.Drawing.Size(169, 21);
            this.ComboOdabirNatjecanja.TabIndex = 2;
            // 
            // LblOdaberiPobjednika
            // 
            this.LblOdaberiPobjednika.AutoSize = true;
            this.LblOdaberiPobjednika.Location = new System.Drawing.Point(170, 175);
            this.LblOdaberiPobjednika.Name = "LblOdaberiPobjednika";
            this.LblOdaberiPobjednika.Size = new System.Drawing.Size(102, 13);
            this.LblOdaberiPobjednika.TabIndex = 3;
            this.LblOdaberiPobjednika.Text = "Odaberi pobjednika:";
            // 
            // ComboOdaberiPobjednika
            // 
            this.ComboOdaberiPobjednika.FormattingEnabled = true;
            this.ComboOdaberiPobjednika.Location = new System.Drawing.Point(173, 191);
            this.ComboOdaberiPobjednika.Name = "ComboOdaberiPobjednika";
            this.ComboOdaberiPobjednika.Size = new System.Drawing.Size(169, 21);
            this.ComboOdaberiPobjednika.TabIndex = 4;
            // 
            // BtnObavijestiPobjednika
            // 
            this.BtnObavijestiPobjednika.Location = new System.Drawing.Point(192, 232);
            this.BtnObavijestiPobjednika.Name = "BtnObavijestiPobjednika";
            this.BtnObavijestiPobjednika.Size = new System.Drawing.Size(132, 23);
            this.BtnObavijestiPobjednika.TabIndex = 5;
            this.BtnObavijestiPobjednika.Text = "Obavijesti pobjednika";
            this.BtnObavijestiPobjednika.UseVisualStyleBackColor = true;
            // 
            // FrmProglasiPobjednika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 314);
            this.Controls.Add(this.BtnObavijestiPobjednika);
            this.Controls.Add(this.ComboOdaberiPobjednika);
            this.Controls.Add(this.LblOdaberiPobjednika);
            this.Controls.Add(this.ComboOdabirNatjecanja);
            this.Controls.Add(this.LblOdabirNatjecanja);
            this.Controls.Add(this.LblProglasenjePobjednika);
            this.Name = "FrmProglasiPobjednika";
            this.Text = "FrmProglasiPobjednika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProglasenjePobjednika;
        private System.Windows.Forms.Label LblOdabirNatjecanja;
        private System.Windows.Forms.ComboBox ComboOdabirNatjecanja;
        private System.Windows.Forms.Label LblOdaberiPobjednika;
        private System.Windows.Forms.ComboBox ComboOdaberiPobjednika;
        private System.Windows.Forms.Button BtnObavijestiPobjednika;
    }
}