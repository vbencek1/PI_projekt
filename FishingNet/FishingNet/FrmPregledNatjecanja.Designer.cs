namespace FishingNet
{
    partial class FrmPregledNatjecanja
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
            this.LstNatjecanja = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAzurirajNatjecanje = new System.Windows.Forms.Button();
            this.BtnObrisiNatjecanje = new System.Windows.Forms.Button();
            this.BtnDodajNatjecanje = new System.Windows.Forms.Button();
            this.BtnPrikaziNatjecanje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstNatjecanja
            // 
            this.LstNatjecanja.FormattingEnabled = true;
            this.LstNatjecanja.Location = new System.Drawing.Point(43, 86);
            this.LstNatjecanja.Name = "LstNatjecanja";
            this.LstNatjecanja.Size = new System.Drawing.Size(192, 303);
            this.LstNatjecanja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista natjecanja";
            // 
            // BtnAzurirajNatjecanje
            // 
            this.BtnAzurirajNatjecanje.Location = new System.Drawing.Point(253, 121);
            this.BtnAzurirajNatjecanje.Name = "BtnAzurirajNatjecanje";
            this.BtnAzurirajNatjecanje.Size = new System.Drawing.Size(159, 29);
            this.BtnAzurirajNatjecanje.TabIndex = 12;
            this.BtnAzurirajNatjecanje.Text = "Ažuriraj natjecanje";
            this.BtnAzurirajNatjecanje.UseVisualStyleBackColor = true;
            // 
            // BtnObrisiNatjecanje
            // 
            this.BtnObrisiNatjecanje.Location = new System.Drawing.Point(253, 156);
            this.BtnObrisiNatjecanje.Name = "BtnObrisiNatjecanje";
            this.BtnObrisiNatjecanje.Size = new System.Drawing.Size(159, 29);
            this.BtnObrisiNatjecanje.TabIndex = 11;
            this.BtnObrisiNatjecanje.Text = "Obriši natjecanje";
            this.BtnObrisiNatjecanje.UseVisualStyleBackColor = true;
            // 
            // BtnDodajNatjecanje
            // 
            this.BtnDodajNatjecanje.Location = new System.Drawing.Point(253, 86);
            this.BtnDodajNatjecanje.Name = "BtnDodajNatjecanje";
            this.BtnDodajNatjecanje.Size = new System.Drawing.Size(159, 29);
            this.BtnDodajNatjecanje.TabIndex = 10;
            this.BtnDodajNatjecanje.Text = "Dodaj natjecanje";
            this.BtnDodajNatjecanje.UseVisualStyleBackColor = true;
            // 
            // BtnPrikaziNatjecanje
            // 
            this.BtnPrikaziNatjecanje.Location = new System.Drawing.Point(123, 395);
            this.BtnPrikaziNatjecanje.Name = "BtnPrikaziNatjecanje";
            this.BtnPrikaziNatjecanje.Size = new System.Drawing.Size(112, 23);
            this.BtnPrikaziNatjecanje.TabIndex = 13;
            this.BtnPrikaziNatjecanje.Text = "Pregledaj natjecanje";
            this.BtnPrikaziNatjecanje.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pregled natjecanja\r\n";
            // 
            // FrmPregledNatjecanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPrikaziNatjecanje);
            this.Controls.Add(this.BtnAzurirajNatjecanje);
            this.Controls.Add(this.BtnObrisiNatjecanje);
            this.Controls.Add(this.BtnDodajNatjecanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstNatjecanja);
            this.Name = "FrmPregledNatjecanja";
            this.Text = "Pregled natjecanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstNatjecanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAzurirajNatjecanje;
        private System.Windows.Forms.Button BtnObrisiNatjecanje;
        private System.Windows.Forms.Button BtnDodajNatjecanje;
        private System.Windows.Forms.Button BtnPrikaziNatjecanje;
        private System.Windows.Forms.Label label2;
    }
}