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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.LblDodavanjeNovogClana = new System.Windows.Forms.Label();
            this.ComboOdabirNatjecanja = new System.Windows.Forms.ComboBox();
            this.ComboStatusa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.LblLokacija = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPretraziZahtjeve = new System.Windows.Forms.TextBox();
            this.LblPretrazi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviClanova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviEksterni)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvZahtjeviClanova
            // 
            this.DgvZahtjeviClanova.AllowUserToAddRows = false;
            this.DgvZahtjeviClanova.AllowUserToDeleteRows = false;
            this.DgvZahtjeviClanova.Location = new System.Drawing.Point(4, 26);
            this.DgvZahtjeviClanova.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvZahtjeviClanova.Name = "DgvZahtjeviClanova";
            this.DgvZahtjeviClanova.ReadOnly = true;
            this.DgvZahtjeviClanova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvZahtjeviClanova.ShowCellErrors = false;
            this.DgvZahtjeviClanova.Size = new System.Drawing.Size(880, 204);
            this.DgvZahtjeviClanova.TabIndex = 20;
            // 
            // DgvZahtjeviEksterni
            // 
            this.DgvZahtjeviEksterni.AllowUserToAddRows = false;
            this.DgvZahtjeviEksterni.AllowUserToDeleteRows = false;
            this.DgvZahtjeviEksterni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvZahtjeviEksterni.Location = new System.Drawing.Point(4, 262);
            this.DgvZahtjeviEksterni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvZahtjeviEksterni.Name = "DgvZahtjeviEksterni";
            this.DgvZahtjeviEksterni.ReadOnly = true;
            this.DgvZahtjeviEksterni.Size = new System.Drawing.Size(880, 204);
            this.DgvZahtjeviEksterni.TabIndex = 21;
            // 
            // BtnPreuzimiPodatke
            // 
            this.BtnPreuzimiPodatke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnPreuzimiPodatke.FlatAppearance.BorderSize = 0;
            this.BtnPreuzimiPodatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreuzimiPodatke.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreuzimiPodatke.ForeColor = System.Drawing.Color.White;
            this.BtnPreuzimiPodatke.Location = new System.Drawing.Point(835, 49);
            this.BtnPreuzimiPodatke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPreuzimiPodatke.Name = "BtnPreuzimiPodatke";
            this.BtnPreuzimiPodatke.Size = new System.Drawing.Size(236, 28);
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
            this.btnOdobri.Location = new System.Drawing.Point(652, 474);
            this.btnOdobri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(112, 28);
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
            this.BtnOdbij.Location = new System.Drawing.Point(772, 474);
            this.BtnOdbij.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOdbij.Name = "BtnOdbij";
            this.BtnOdbij.Size = new System.Drawing.Size(112, 28);
            this.BtnOdbij.TabIndex = 43;
            this.BtnOdbij.Text = "Odbij";
            this.BtnOdbij.UseVisualStyleBackColor = false;
            this.BtnOdbij.Click += new System.EventHandler(this.BtnOdbij_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnOdbij);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOdobri);
            this.panel1.Controls.Add(this.DgvZahtjeviEksterni);
            this.panel1.Controls.Add(this.DgvZahtjeviClanova);
            this.panel1.Location = new System.Drawing.Point(29, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 513);
            this.panel1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vanjski sudionici:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Naši članovi:";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelHeader.Controls.Add(this.BtnBack);
            this.PanelHeader.Controls.Add(this.PicMaliLogo);
            this.PanelHeader.Controls.Add(this.LblDodavanjeNovogClana);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1087, 42);
            this.PanelHeader.TabIndex = 45;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BackgroundImage = global::FishingNet.Properties.Resources.back_button;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(12, 6);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(33, 31);
            this.BtnBack.TabIndex = 16;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PicMaliLogo
            // 
            this.PicMaliLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicMaliLogo.Image = global::FishingNet.Properties.Resources.logo_small;
            this.PicMaliLogo.Location = new System.Drawing.Point(859, 6);
            this.PicMaliLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicMaliLogo.Name = "PicMaliLogo";
            this.PicMaliLogo.Size = new System.Drawing.Size(171, 32);
            this.PicMaliLogo.TabIndex = 0;
            this.PicMaliLogo.TabStop = false;
            // 
            // LblDodavanjeNovogClana
            // 
            this.LblDodavanjeNovogClana.AutoSize = true;
            this.LblDodavanjeNovogClana.BackColor = System.Drawing.Color.Transparent;
            this.LblDodavanjeNovogClana.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDodavanjeNovogClana.ForeColor = System.Drawing.Color.White;
            this.LblDodavanjeNovogClana.Location = new System.Drawing.Point(427, 6);
            this.LblDodavanjeNovogClana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDodavanjeNovogClana.Name = "LblDodavanjeNovogClana";
            this.LblDodavanjeNovogClana.Size = new System.Drawing.Size(105, 28);
            this.LblDodavanjeNovogClana.TabIndex = 12;
            this.LblDodavanjeNovogClana.Text = "PRIJAVE";
            // 
            // ComboOdabirNatjecanja
            // 
            this.ComboOdabirNatjecanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.ComboOdabirNatjecanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboOdabirNatjecanja.ForeColor = System.Drawing.Color.White;
            this.ComboOdabirNatjecanja.FormattingEnabled = true;
            this.ComboOdabirNatjecanja.Location = new System.Drawing.Point(207, 69);
            this.ComboOdabirNatjecanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboOdabirNatjecanja.Name = "ComboOdabirNatjecanja";
            this.ComboOdabirNatjecanja.Size = new System.Drawing.Size(224, 24);
            this.ComboOdabirNatjecanja.TabIndex = 17;
            this.ComboOdabirNatjecanja.SelectedIndexChanged += new System.EventHandler(this.ComboOdabirNatjecanja_SelectedIndexChanged);
            // 
            // ComboStatusa
            // 
            this.ComboStatusa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.ComboStatusa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboStatusa.ForeColor = System.Drawing.Color.White;
            this.ComboStatusa.FormattingEnabled = true;
            this.ComboStatusa.Location = new System.Drawing.Point(207, 112);
            this.ComboStatusa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboStatusa.Name = "ComboStatusa";
            this.ComboStatusa.Size = new System.Drawing.Size(224, 24);
            this.ComboStatusa.TabIndex = 46;
            this.ComboStatusa.SelectedIndexChanged += new System.EventHandler(this.ComboStatusa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.label3.Location = new System.Drawing.Point(33, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Odaberi natjecanje:";
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnPrikaziSve.FlatAppearance.BorderSize = 0;
            this.BtnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrikaziSve.ForeColor = System.Drawing.Color.White;
            this.BtnPrikaziSve.Location = new System.Drawing.Point(819, 112);
            this.BtnPrikaziSve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(112, 28);
            this.BtnPrikaziSve.TabIndex = 44;
            this.BtnPrikaziSve.Text = "Prikazi sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = false;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // LblLokacija
            // 
            this.LblLokacija.AutoSize = true;
            this.LblLokacija.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLokacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.LblLokacija.Location = new System.Drawing.Point(33, 112);
            this.LblLokacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLokacija.Name = "LblLokacija";
            this.LblLokacija.Size = new System.Drawing.Size(125, 23);
            this.LblLokacija.TabIndex = 49;
            this.LblLokacija.Text = "Odaberi status:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.panel2.Location = new System.Drawing.Point(481, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 52;
            // 
            // TxtPretraziZahtjeve
            // 
            this.TxtPretraziZahtjeve.BackColor = System.Drawing.Color.White;
            this.TxtPretraziZahtjeve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPretraziZahtjeve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPretraziZahtjeve.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPretraziZahtjeve.ForeColor = System.Drawing.Color.Black;
            this.TxtPretraziZahtjeve.Location = new System.Drawing.Point(480, 105);
            this.TxtPretraziZahtjeve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPretraziZahtjeve.Name = "TxtPretraziZahtjeve";
            this.TxtPretraziZahtjeve.Size = new System.Drawing.Size(289, 25);
            this.TxtPretraziZahtjeve.TabIndex = 51;
            this.TxtPretraziZahtjeve.TextChanged += new System.EventHandler(this.TxtPretraziZahtjeve_TextChanged);
            // 
            // LblPretrazi
            // 
            this.LblPretrazi.AutoSize = true;
            this.LblPretrazi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPretrazi.ForeColor = System.Drawing.Color.Black;
            this.LblPretrazi.Location = new System.Drawing.Point(477, 82);
            this.LblPretrazi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPretrazi.Name = "LblPretrazi";
            this.LblPretrazi.Size = new System.Drawing.Size(232, 21);
            this.LblPretrazi.TabIndex = 50;
            this.LblPretrazi.Text = "Pretraži po imenu ili prezimenu:";
            // 
            // FrmZahtjeviPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtPretraziZahtjeve);
            this.Controls.Add(this.LblPretrazi);
            this.Controls.Add(this.LblLokacija);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboStatusa);
            this.Controls.Add(this.ComboOdabirNatjecanja);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.BtnPreuzimiPodatke);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmZahtjeviPrijava";
            this.Text = "Zahtjevi prijava";
            this.Load += new System.EventHandler(this.FrmZahtjeviPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviClanova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZahtjeviEksterni)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblDodavanjeNovogClana;
        private System.Windows.Forms.ComboBox ComboOdabirNatjecanja;
        private System.Windows.Forms.ComboBox ComboStatusa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Label LblLokacija;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtPretraziZahtjeve;
        private System.Windows.Forms.Label LblPretrazi;
    }
}