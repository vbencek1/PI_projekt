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
            this.BtnPregledajNatjecanje = new System.Windows.Forms.Button();
            this.LbListaNatjecanja = new System.Windows.Forms.Label();
            this.BtnObrisiNatjecanje = new System.Windows.Forms.Button();
            this.BtnAzurirajNatjecanja = new System.Windows.Forms.Button();
            this.BtnDodajNatjecanje = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.LblPregledNatjecanja = new System.Windows.Forms.Label();
            this.dgvNatjecanja = new System.Windows.Forms.DataGridView();
            this.ComboLokacije = new System.Windows.Forms.ComboBox();
            this.BtnPrikaziSve = new System.Windows.Forms.Button();
            this.LblLokacija = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPregledajNatjecanje
            // 
            this.BtnPregledajNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.BtnPregledajNatjecanje.FlatAppearance.BorderSize = 0;
            this.BtnPregledajNatjecanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPregledajNatjecanje.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPregledajNatjecanje.ForeColor = System.Drawing.Color.White;
            this.BtnPregledajNatjecanje.Location = new System.Drawing.Point(448, 388);
            this.BtnPregledajNatjecanje.Name = "BtnPregledajNatjecanje";
            this.BtnPregledajNatjecanje.Size = new System.Drawing.Size(130, 25);
            this.BtnPregledajNatjecanje.TabIndex = 27;
            this.BtnPregledajNatjecanje.Text = "Pregledaj natjecanje";
            this.BtnPregledajNatjecanje.UseVisualStyleBackColor = false;
            this.BtnPregledajNatjecanje.Click += new System.EventHandler(this.BtnPregledajNatjecanje_Click);
            // 
            // LbListaNatjecanja
            // 
            this.LbListaNatjecanja.AutoSize = true;
            this.LbListaNatjecanja.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListaNatjecanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.LbListaNatjecanja.Location = new System.Drawing.Point(34, 95);
            this.LbListaNatjecanja.Name = "LbListaNatjecanja";
            this.LbListaNatjecanja.Size = new System.Drawing.Size(133, 23);
            this.LbListaNatjecanja.TabIndex = 26;
            this.LbListaNatjecanja.Text = "Lista natjecanja";
            // 
            // BtnObrisiNatjecanje
            // 
            this.BtnObrisiNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnObrisiNatjecanje.FlatAppearance.BorderSize = 0;
            this.BtnObrisiNatjecanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObrisiNatjecanje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObrisiNatjecanje.ForeColor = System.Drawing.Color.White;
            this.BtnObrisiNatjecanje.Location = new System.Drawing.Point(597, 193);
            this.BtnObrisiNatjecanje.Name = "BtnObrisiNatjecanje";
            this.BtnObrisiNatjecanje.Size = new System.Drawing.Size(150, 30);
            this.BtnObrisiNatjecanje.TabIndex = 30;
            this.BtnObrisiNatjecanje.Text = "Obriši natjecanje";
            this.BtnObrisiNatjecanje.UseVisualStyleBackColor = false;
            this.BtnObrisiNatjecanje.Click += new System.EventHandler(this.BtnObrisiClana_Click);
            // 
            // BtnAzurirajNatjecanja
            // 
            this.BtnAzurirajNatjecanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnAzurirajNatjecanja.FlatAppearance.BorderSize = 0;
            this.BtnAzurirajNatjecanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAzurirajNatjecanja.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAzurirajNatjecanja.ForeColor = System.Drawing.Color.White;
            this.BtnAzurirajNatjecanja.Location = new System.Drawing.Point(597, 157);
            this.BtnAzurirajNatjecanja.Name = "BtnAzurirajNatjecanja";
            this.BtnAzurirajNatjecanja.Size = new System.Drawing.Size(150, 30);
            this.BtnAzurirajNatjecanja.TabIndex = 29;
            this.BtnAzurirajNatjecanja.Text = "Ažuriraj natjecanje";
            this.BtnAzurirajNatjecanja.UseVisualStyleBackColor = false;
            this.BtnAzurirajNatjecanja.Click += new System.EventHandler(this.BtnAzurirajClana_Click);
            // 
            // BtnDodajNatjecanje
            // 
            this.BtnDodajNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnDodajNatjecanje.FlatAppearance.BorderSize = 0;
            this.BtnDodajNatjecanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajNatjecanje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajNatjecanje.ForeColor = System.Drawing.Color.White;
            this.BtnDodajNatjecanje.Location = new System.Drawing.Point(597, 121);
            this.BtnDodajNatjecanje.Name = "BtnDodajNatjecanje";
            this.BtnDodajNatjecanje.Size = new System.Drawing.Size(150, 30);
            this.BtnDodajNatjecanje.TabIndex = 28;
            this.BtnDodajNatjecanje.Text = "Dodaj natjecanje";
            this.BtnDodajNatjecanje.UseVisualStyleBackColor = false;
            this.BtnDodajNatjecanje.Click += new System.EventHandler(this.BtnDodajNatjecanje_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelHeader.Controls.Add(this.BtnBack);
            this.PanelHeader.Controls.Add(this.PicMaliLogo);
            this.PanelHeader.Controls.Add(this.LblPregledNatjecanja);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(784, 34);
            this.PanelHeader.TabIndex = 31;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BackgroundImage = global::FishingNet.Properties.Resources.back_button;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(9, 5);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(25, 25);
            this.BtnBack.TabIndex = 16;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PicMaliLogo
            // 
            this.PicMaliLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicMaliLogo.Image = global::FishingNet.Properties.Resources.logo_small;
            this.PicMaliLogo.Location = new System.Drawing.Point(644, 5);
            this.PicMaliLogo.Name = "PicMaliLogo";
            this.PicMaliLogo.Size = new System.Drawing.Size(128, 26);
            this.PicMaliLogo.TabIndex = 0;
            this.PicMaliLogo.TabStop = false;
            // 
            // LblPregledNatjecanja
            // 
            this.LblPregledNatjecanja.AutoSize = true;
            this.LblPregledNatjecanja.BackColor = System.Drawing.Color.Transparent;
            this.LblPregledNatjecanja.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPregledNatjecanja.ForeColor = System.Drawing.Color.White;
            this.LblPregledNatjecanja.Location = new System.Drawing.Point(259, 5);
            this.LblPregledNatjecanja.Name = "LblPregledNatjecanja";
            this.LblPregledNatjecanja.Size = new System.Drawing.Size(215, 23);
            this.LblPregledNatjecanja.TabIndex = 12;
            this.LblPregledNatjecanja.Text = "PREGLED NATJECANJA";
            this.LblPregledNatjecanja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNatjecanja
            // 
            this.dgvNatjecanja.AllowUserToAddRows = false;
            this.dgvNatjecanja.AllowUserToDeleteRows = false;
            this.dgvNatjecanja.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNatjecanja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNatjecanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNatjecanja.Location = new System.Drawing.Point(38, 121);
            this.dgvNatjecanja.Name = "dgvNatjecanja";
            this.dgvNatjecanja.ReadOnly = true;
            this.dgvNatjecanja.Size = new System.Drawing.Size(540, 265);
            this.dgvNatjecanja.TabIndex = 32;
            this.dgvNatjecanja.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNatjecanja_DataBindingComplete);
            // 
            // ComboLokacije
            // 
            this.ComboLokacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboLokacije.FormattingEnabled = true;
            this.ComboLokacije.Location = new System.Drawing.Point(286, 94);
            this.ComboLokacije.Name = "ComboLokacije";
            this.ComboLokacije.Size = new System.Drawing.Size(199, 21);
            this.ComboLokacije.TabIndex = 42;
            this.ComboLokacije.SelectedIndexChanged += new System.EventHandler(this.ComboLokacije_SelectedIndexChanged);
            // 
            // BtnPrikaziSve
            // 
            this.BtnPrikaziSve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.BtnPrikaziSve.FlatAppearance.BorderSize = 0;
            this.BtnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrikaziSve.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrikaziSve.ForeColor = System.Drawing.Color.White;
            this.BtnPrikaziSve.Location = new System.Drawing.Point(491, 94);
            this.BtnPrikaziSve.Name = "BtnPrikaziSve";
            this.BtnPrikaziSve.Size = new System.Drawing.Size(87, 21);
            this.BtnPrikaziSve.TabIndex = 43;
            this.BtnPrikaziSve.Text = "Prikaži sve";
            this.BtnPrikaziSve.UseVisualStyleBackColor = false;
            this.BtnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // LblLokacija
            // 
            this.LblLokacija.AutoSize = true;
            this.LblLokacija.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLokacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.LblLokacija.Location = new System.Drawing.Point(221, 94);
            this.LblLokacija.Name = "LblLokacija";
            this.LblLokacija.Size = new System.Drawing.Size(59, 18);
            this.LblLokacija.TabIndex = 44;
            this.LblLokacija.Text = "Lokacija:";
            // 
            // FrmPregledNatjecanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.LblLokacija);
            this.Controls.Add(this.BtnPrikaziSve);
            this.Controls.Add(this.ComboLokacije);
            this.Controls.Add(this.dgvNatjecanja);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.BtnObrisiNatjecanje);
            this.Controls.Add(this.BtnAzurirajNatjecanja);
            this.Controls.Add(this.BtnDodajNatjecanje);
            this.Controls.Add(this.BtnPregledajNatjecanje);
            this.Controls.Add(this.LbListaNatjecanja);
            this.Name = "FrmPregledNatjecanja";
            this.Text = "Pregled natjecanja";
            this.Load += new System.EventHandler(this.FrmPregledNatjecanja_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnPregledajNatjecanje;
        private System.Windows.Forms.Label LbListaNatjecanja;
        private System.Windows.Forms.Button BtnObrisiNatjecanje;
        private System.Windows.Forms.Button BtnAzurirajNatjecanja;
        private System.Windows.Forms.Button BtnDodajNatjecanje;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblPregledNatjecanja;
        private System.Windows.Forms.DataGridView dgvNatjecanja;
        private System.Windows.Forms.ComboBox ComboLokacije;
        private System.Windows.Forms.Button BtnPrikaziSve;
        private System.Windows.Forms.Label LblLokacija;
    }
}