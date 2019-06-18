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
            this.LblPopisClanova = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.LblClanovi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPretraziClanove = new System.Windows.Forms.TextBox();
            this.LblPretraziClanove = new System.Windows.Forms.Label();
            this.BtnDodajClana = new System.Windows.Forms.Button();
            this.BtnAzurirajClana = new System.Windows.Forms.Button();
            this.BtnObrisiClana = new System.Windows.Forms.Button();
            this.BtnOsvjeziListu = new System.Windows.Forms.Button();
            this.dgvPopisClanova = new System.Windows.Forms.DataGridView();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisClanova)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPopisClanova
            // 
            this.LblPopisClanova.AutoSize = true;
            this.LblPopisClanova.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPopisClanova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.LblPopisClanova.Location = new System.Drawing.Point(29, 76);
            this.LblPopisClanova.Name = "LblPopisClanova";
            this.LblPopisClanova.Size = new System.Drawing.Size(117, 23);
            this.LblPopisClanova.TabIndex = 2;
            this.LblPopisClanova.Text = "Popis članova";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelHeader.Controls.Add(this.BtnBack);
            this.PanelHeader.Controls.Add(this.PicMaliLogo);
            this.PanelHeader.Controls.Add(this.LblClanovi);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(784, 34);
            this.PanelHeader.TabIndex = 16;
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
            // LblClanovi
            // 
            this.LblClanovi.AutoSize = true;
            this.LblClanovi.BackColor = System.Drawing.Color.Transparent;
            this.LblClanovi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClanovi.ForeColor = System.Drawing.Color.White;
            this.LblClanovi.Location = new System.Drawing.Point(311, 5);
            this.LblClanovi.Name = "LblClanovi";
            this.LblClanovi.Size = new System.Drawing.Size(95, 23);
            this.LblClanovi.TabIndex = 12;
            this.LblClanovi.Text = "ČLANOVI";
            this.LblClanovi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.panel1.Location = new System.Drawing.Point(541, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 1);
            this.panel1.TabIndex = 19;
            // 
            // TxtPretraziClanove
            // 
            this.TxtPretraziClanove.BackColor = System.Drawing.Color.White;
            this.TxtPretraziClanove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPretraziClanove.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPretraziClanove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPretraziClanove.ForeColor = System.Drawing.Color.Black;
            this.TxtPretraziClanove.Location = new System.Drawing.Point(540, 102);
            this.TxtPretraziClanove.Name = "TxtPretraziClanove";
            this.TxtPretraziClanove.Size = new System.Drawing.Size(217, 20);
            this.TxtPretraziClanove.TabIndex = 18;
            this.TxtPretraziClanove.TextChanged += new System.EventHandler(this.TxtPretraziClanove_TextChanged);
            // 
            // LblPretraziClanove
            // 
            this.LblPretraziClanove.AutoSize = true;
            this.LblPretraziClanove.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPretraziClanove.ForeColor = System.Drawing.Color.Black;
            this.LblPretraziClanove.Location = new System.Drawing.Point(538, 84);
            this.LblPretraziClanove.Name = "LblPretraziClanove";
            this.LblPretraziClanove.Size = new System.Drawing.Size(211, 15);
            this.LblPretraziClanove.TabIndex = 17;
            this.LblPretraziClanove.Text = "Pretraži članove po imenu i prezimenu:";
            this.LblPretraziClanove.Click += new System.EventHandler(this.LblNaziv_Click);
            // 
            // BtnDodajClana
            // 
            this.BtnDodajClana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnDodajClana.FlatAppearance.BorderSize = 0;
            this.BtnDodajClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajClana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajClana.ForeColor = System.Drawing.Color.White;
            this.BtnDodajClana.Location = new System.Drawing.Point(607, 192);
            this.BtnDodajClana.Name = "BtnDodajClana";
            this.BtnDodajClana.Size = new System.Drawing.Size(150, 30);
            this.BtnDodajClana.TabIndex = 21;
            this.BtnDodajClana.Text = "Dodaj člana";
            this.BtnDodajClana.UseVisualStyleBackColor = false;
            this.BtnDodajClana.Click += new System.EventHandler(this.BtnDodajClana_Click);
            // 
            // BtnAzurirajClana
            // 
            this.BtnAzurirajClana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnAzurirajClana.FlatAppearance.BorderSize = 0;
            this.BtnAzurirajClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAzurirajClana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAzurirajClana.ForeColor = System.Drawing.Color.White;
            this.BtnAzurirajClana.Location = new System.Drawing.Point(607, 228);
            this.BtnAzurirajClana.Name = "BtnAzurirajClana";
            this.BtnAzurirajClana.Size = new System.Drawing.Size(150, 30);
            this.BtnAzurirajClana.TabIndex = 22;
            this.BtnAzurirajClana.Text = "Ažuriraj člana";
            this.BtnAzurirajClana.UseVisualStyleBackColor = false;
            this.BtnAzurirajClana.Click += new System.EventHandler(this.BtnAzurirajClana_Click);
            // 
            // BtnObrisiClana
            // 
            this.BtnObrisiClana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.BtnObrisiClana.FlatAppearance.BorderSize = 0;
            this.BtnObrisiClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObrisiClana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObrisiClana.ForeColor = System.Drawing.Color.White;
            this.BtnObrisiClana.Location = new System.Drawing.Point(607, 264);
            this.BtnObrisiClana.Name = "BtnObrisiClana";
            this.BtnObrisiClana.Size = new System.Drawing.Size(150, 30);
            this.BtnObrisiClana.TabIndex = 23;
            this.BtnObrisiClana.Text = "Obriši člana";
            this.BtnObrisiClana.UseVisualStyleBackColor = true;
            this.BtnObrisiClana.Click += new System.EventHandler(this.BtnObrisiClana_Click);
            // 
            // BtnOsvjeziListu
            // 
            this.BtnOsvjeziListu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.BtnOsvjeziListu.FlatAppearance.BorderSize = 0;
            this.BtnOsvjeziListu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOsvjeziListu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOsvjeziListu.ForeColor = System.Drawing.Color.White;
            this.BtnOsvjeziListu.Location = new System.Drawing.Point(457, 381);
            this.BtnOsvjeziListu.Name = "BtnOsvjeziListu";
            this.BtnOsvjeziListu.Size = new System.Drawing.Size(75, 23);
            this.BtnOsvjeziListu.TabIndex = 7;
            this.BtnOsvjeziListu.Text = "Osvježi";
            this.BtnOsvjeziListu.UseVisualStyleBackColor = true;
            this.BtnOsvjeziListu.Click += new System.EventHandler(this.BtnOsvjeziListu_Click);
            // 
            // dgvPopisClanova
            // 
            this.dgvPopisClanova.AllowUserToAddRows = false;
            this.dgvPopisClanova.AllowUserToDeleteRows = false;
            this.dgvPopisClanova.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisClanova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPopisClanova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisClanova.Location = new System.Drawing.Point(24, 102);
            this.dgvPopisClanova.Name = "dgvPopisClanova";
            this.dgvPopisClanova.ReadOnly = true;
            this.dgvPopisClanova.Size = new System.Drawing.Size(508, 278);
            this.dgvPopisClanova.TabIndex = 24;
            // 
            // FrmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvPopisClanova);
            this.Controls.Add(this.BtnOsvjeziListu);
            this.Controls.Add(this.LblPopisClanova);
            this.Controls.Add(this.BtnObrisiClana);
            this.Controls.Add(this.BtnAzurirajClana);
            this.Controls.Add(this.BtnDodajClana);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtPretraziClanove);
            this.Controls.Add(this.LblPretraziClanove);
            this.Controls.Add(this.PanelHeader);
            this.Name = "FrmClanovi";
            this.Text = "FrmClanovi";
            this.Load += new System.EventHandler(this.FrmClanovi_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisClanova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPopisClanova;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblClanovi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPretraziClanove;
        private System.Windows.Forms.Label LblPretraziClanove;
        private System.Windows.Forms.Button BtnDodajClana;
        private System.Windows.Forms.Button BtnAzurirajClana;
        private System.Windows.Forms.Button BtnObrisiClana;
        private System.Windows.Forms.Button BtnOsvjeziListu;
        private System.Windows.Forms.Button BtnOsvjezi;
        private System.Windows.Forms.DataGridView dgvPopisClanova;
    }
}