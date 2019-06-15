namespace FishingNet
{
    partial class FrmZahtjeviPrijava
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
            this.DgvZahtjeviClanova = new System.Windows.Forms.DataGridView();
            this.DgvZahtjeviEksterni = new System.Windows.Forms.DataGridView();
            this.BtnPreuzimiPodatke = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.BtnOdbij = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviClanova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviEksterni)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvZahtjeviClanova
            // 
            this.DgvZahtjeviClanova.AllowUserToAddRows = false;
            this.DgvZahtjeviClanova.AllowUserToDeleteRows = false;
            this.DgvZahtjeviClanova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvZahtjeviClanova.Location = new System.Drawing.Point(3, 21);
            this.DgvZahtjeviClanova.Name = "DgvZahtjeviClanova";
            this.DgvZahtjeviClanova.ReadOnly = true;
            this.DgvZahtjeviClanova.Size = new System.Drawing.Size(660, 166);
            this.DgvZahtjeviClanova.TabIndex = 20;
            // 
            // DgvZahtjeviEksterni
            // 
            this.DgvZahtjeviEksterni.AllowUserToAddRows = false;
            this.DgvZahtjeviEksterni.AllowUserToDeleteRows = false;
            this.DgvZahtjeviEksterni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvZahtjeviEksterni.Location = new System.Drawing.Point(3, 213);
            this.DgvZahtjeviEksterni.Name = "DgvZahtjeviEksterni";
            this.DgvZahtjeviEksterni.ReadOnly = true;
            this.DgvZahtjeviEksterni.Size = new System.Drawing.Size(660, 166);
            this.DgvZahtjeviEksterni.TabIndex = 21;
            // 
            // BtnPreuzimiPodatke
            // 
            this.BtnPreuzimiPodatke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.BtnPreuzimiPodatke.FlatAppearance.BorderSize = 0;
            this.BtnPreuzimiPodatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreuzimiPodatke.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreuzimiPodatke.ForeColor = System.Drawing.Color.White;
            this.BtnPreuzimiPodatke.Location = new System.Drawing.Point(622, 1);
            this.BtnPreuzimiPodatke.Name = "BtnPreuzimiPodatke";
            this.BtnPreuzimiPodatke.Size = new System.Drawing.Size(177, 23);
            this.BtnPreuzimiPodatke.TabIndex = 41;
            this.BtnPreuzimiPodatke.Text = "Učitaj podatke iz datoteke";
            this.BtnPreuzimiPodatke.UseVisualStyleBackColor = false;
            this.BtnPreuzimiPodatke.Click += new System.EventHandler(this.BtnPreuzimiPodatke_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.btnOdobri.FlatAppearance.BorderSize = 0;
            this.btnOdobri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdobri.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdobri.ForeColor = System.Drawing.Color.White;
            this.btnOdobri.Location = new System.Drawing.Point(518, 415);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(84, 23);
            this.btnOdobri.TabIndex = 42;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // BtnOdbij
            // 
            this.BtnOdbij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.BtnOdbij.FlatAppearance.BorderSize = 0;
            this.BtnOdbij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdbij.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOdbij.ForeColor = System.Drawing.Color.White;
            this.BtnOdbij.Location = new System.Drawing.Point(611, 415);
            this.BtnOdbij.Name = "BtnOdbij";
            this.BtnOdbij.Size = new System.Drawing.Size(84, 23);
            this.BtnOdbij.TabIndex = 43;
            this.BtnOdbij.Text = "Odbij";
            this.BtnOdbij.UseVisualStyleBackColor = false;
            this.BtnOdbij.Click += new System.EventHandler(this.BtnOdbij_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DgvZahtjeviEksterni);
            this.panel1.Controls.Add(this.DgvZahtjeviClanova);
            this.panel1.Location = new System.Drawing.Point(28, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 417);
            this.panel1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vanjski sudionici:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Naši članovi:";
            // 
            // FrmZahtjeviPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOdbij);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.BtnPreuzimiPodatke);
            this.Controls.Add(this.panel1);
            this.Name = "FrmZahtjeviPrijava";
            this.Text = "Zahtjevi prijava";
            this.Load += new System.EventHandler(this.FrmZahtjeviPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviClanova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviEksterni)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvZahtjeviClanova;
        private System.Windows.Forms.DataGridView DgvZahtjeviEksterni;
        private System.Windows.Forms.Button BtnPreuzimiPodatke;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button BtnOdbij;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}