namespace FishingNet
{
    partial class FrmNatjecanja
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
            this.BtnPregledNatjecanja = new System.Windows.Forms.Button();
            this.BtnStatistika = new System.Windows.Forms.Button();
            this.BtnProglasiPobjednika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Natjecanja";
            // 
            // BtnPregledNatjecanja
            // 
            this.BtnPregledNatjecanja.Location = new System.Drawing.Point(130, 110);
            this.BtnPregledNatjecanja.Name = "BtnPregledNatjecanja";
            this.BtnPregledNatjecanja.Size = new System.Drawing.Size(118, 23);
            this.BtnPregledNatjecanja.TabIndex = 1;
            this.BtnPregledNatjecanja.Text = "Pregled natjecanja";
            this.BtnPregledNatjecanja.UseVisualStyleBackColor = true;
            // 
            // BtnStatistika
            // 
            this.BtnStatistika.Location = new System.Drawing.Point(130, 139);
            this.BtnStatistika.Name = "BtnStatistika";
            this.BtnStatistika.Size = new System.Drawing.Size(118, 23);
            this.BtnStatistika.TabIndex = 2;
            this.BtnStatistika.Text = "Statistika";
            this.BtnStatistika.UseVisualStyleBackColor = true;
            // 
            // BtnProglasiPobjednika
            // 
            this.BtnProglasiPobjednika.Location = new System.Drawing.Point(130, 168);
            this.BtnProglasiPobjednika.Name = "BtnProglasiPobjednika";
            this.BtnProglasiPobjednika.Size = new System.Drawing.Size(118, 23);
            this.BtnProglasiPobjednika.TabIndex = 3;
            this.BtnProglasiPobjednika.Text = "Proglasi pobjednika";
            this.BtnProglasiPobjednika.UseVisualStyleBackColor = true;
            // 
            // FrmNatjecanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 270);
            this.Controls.Add(this.BtnProglasiPobjednika);
            this.Controls.Add(this.BtnStatistika);
            this.Controls.Add(this.BtnPregledNatjecanja);
            this.Controls.Add(this.label1);
            this.Name = "FrmNatjecanja";
            this.Text = "FrmNatjecanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPregledNatjecanja;
        private System.Windows.Forms.Button BtnStatistika;
        private System.Windows.Forms.Button BtnProglasiPobjednika;
    }
}