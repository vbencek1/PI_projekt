namespace FishingNet
{
    partial class FrmRibickiKlubPocetna
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.LblKlubInfo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailNaslov = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTelefonNaslov = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.LblWebNaslov = new System.Windows.Forms.Label();
            this.lblPredsjednik = new System.Windows.Forms.Label();
            this.LblPredsjednikNaslov = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblAdresaNaslov = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.LblNazivNaslov = new System.Windows.Forms.Label();
            this.btnDodajModeratora = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboModerator = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPodaci = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblDatumNaslov = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelHeader.Controls.Add(this.BtnBack);
            this.PanelHeader.Controls.Add(this.PicMaliLogo);
            this.PanelHeader.Controls.Add(this.LblKlubInfo);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 34);
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
            // LblKlubInfo
            // 
            this.LblKlubInfo.AutoSize = true;
            this.LblKlubInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblKlubInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKlubInfo.ForeColor = System.Drawing.Color.White;
            this.LblKlubInfo.Location = new System.Drawing.Point(297, 5);
            this.LblKlubInfo.Name = "LblKlubInfo";
            this.LblKlubInfo.Size = new System.Drawing.Size(167, 23);
            this.LblKlubInfo.TabIndex = 12;
            this.LblKlubInfo.Text = "PODACI O KLUBU\r\n";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(251, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(136, 15);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "ribicki_klub@mail.com\r\n";
            // 
            // lblEmailNaslov
            // 
            this.lblEmailNaslov.AutoSize = true;
            this.lblEmailNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.lblEmailNaslov.Location = new System.Drawing.Point(251, 145);
            this.lblEmailNaslov.Name = "lblEmailNaslov";
            this.lblEmailNaslov.Size = new System.Drawing.Size(44, 18);
            this.lblEmailNaslov.TabIndex = 28;
            this.lblEmailNaslov.Text = "Email:";
            this.lblEmailNaslov.Click += new System.EventHandler(this.LblEmail_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(251, 118);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(86, 15);
            this.lblTelefon.TabIndex = 27;
            this.lblTelefon.Text = "01 923 23 000\r\n";
            // 
            // lblTelefonNaslov
            // 
            this.lblTelefonNaslov.AutoSize = true;
            this.lblTelefonNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.lblTelefonNaslov.Location = new System.Drawing.Point(251, 96);
            this.lblTelefonNaslov.Name = "lblTelefonNaslov";
            this.lblTelefonNaslov.Size = new System.Drawing.Size(55, 18);
            this.lblTelefonNaslov.TabIndex = 26;
            this.lblTelefonNaslov.Text = "Telefon:";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeb.Location = new System.Drawing.Point(59, 263);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(95, 15);
            this.lblWeb.TabIndex = 25;
            this.lblWeb.Text = "Link na stranicu";
            // 
            // LblWebNaslov
            // 
            this.LblWebNaslov.AutoSize = true;
            this.LblWebNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWebNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.LblWebNaslov.Location = new System.Drawing.Point(59, 241);
            this.LblWebNaslov.Name = "LblWebNaslov";
            this.LblWebNaslov.Size = new System.Drawing.Size(82, 18);
            this.LblWebNaslov.TabIndex = 24;
            this.LblWebNaslov.Text = "Web adresa:";
            // 
            // lblPredsjednik
            // 
            this.lblPredsjednik.AutoSize = true;
            this.lblPredsjednik.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredsjednik.Location = new System.Drawing.Point(59, 215);
            this.lblPredsjednik.Name = "lblPredsjednik";
            this.lblPredsjednik.Size = new System.Drawing.Size(155, 15);
            this.lblPredsjednik.TabIndex = 23;
            this.lblPredsjednik.Text = "Ime i prezime predsjednika\r\n";
            // 
            // LblPredsjednikNaslov
            // 
            this.LblPredsjednikNaslov.AutoSize = true;
            this.LblPredsjednikNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPredsjednikNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.LblPredsjednikNaslov.Location = new System.Drawing.Point(59, 193);
            this.LblPredsjednikNaslov.Name = "LblPredsjednikNaslov";
            this.LblPredsjednikNaslov.Size = new System.Drawing.Size(82, 18);
            this.LblPredsjednikNaslov.TabIndex = 22;
            this.LblPredsjednikNaslov.Text = "Predsjednik:\r\n";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(59, 167);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(79, 15);
            this.lblAdresa.TabIndex = 21;
            this.lblAdresa.Text = "Adresa kluba\r\n";
            // 
            // lblAdresaNaslov
            // 
            this.lblAdresaNaslov.AutoSize = true;
            this.lblAdresaNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.lblAdresaNaslov.Location = new System.Drawing.Point(59, 145);
            this.lblAdresaNaslov.Name = "lblAdresaNaslov";
            this.lblAdresaNaslov.Size = new System.Drawing.Size(53, 18);
            this.lblAdresaNaslov.TabIndex = 20;
            this.lblAdresaNaslov.Text = "Adresa:\n";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(59, 119);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(71, 15);
            this.lblNaziv.TabIndex = 19;
            this.lblNaziv.Text = "Naziv kluba\r\n";
            // 
            // LblNazivNaslov
            // 
            this.LblNazivNaslov.AutoSize = true;
            this.LblNazivNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNazivNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.LblNazivNaslov.Location = new System.Drawing.Point(59, 97);
            this.LblNazivNaslov.Name = "LblNazivNaslov";
            this.LblNazivNaslov.Size = new System.Drawing.Size(45, 18);
            this.LblNazivNaslov.TabIndex = 18;
            this.LblNazivNaslov.Text = "Naziv:";
            // 
            // btnDodajModeratora
            // 
            this.btnDodajModeratora.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodajModeratora.FlatAppearance.BorderSize = 0;
            this.btnDodajModeratora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajModeratora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajModeratora.ForeColor = System.Drawing.Color.White;
            this.btnDodajModeratora.Location = new System.Drawing.Point(614, 215);
            this.btnDodajModeratora.Name = "btnDodajModeratora";
            this.btnDodajModeratora.Size = new System.Drawing.Size(150, 30);
            this.btnDodajModeratora.TabIndex = 31;
            this.btnDodajModeratora.Text = "Dodaj moderatora";
            this.btnDodajModeratora.UseVisualStyleBackColor = false;
            this.btnDodajModeratora.Click += new System.EventHandler(this.btnDodajModeratora_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboModerator);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(511, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 97);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj moderatora:";
            // 
            // comboModerator
            // 
            this.comboModerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModerator.FormattingEnabled = true;
            this.comboModerator.Location = new System.Drawing.Point(19, 56);
            this.comboModerator.Name = "comboModerator";
            this.comboModerator.Size = new System.Drawing.Size(216, 23);
            this.comboModerator.TabIndex = 32;
            this.comboModerator.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboModerator_Format);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.panel1.Location = new System.Drawing.Point(19, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 1);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Moderator:";
            // 
            // btnPodaci
            // 
            this.btnPodaci.BackColor = System.Drawing.Color.SlateGray;
            this.btnPodaci.FlatAppearance.BorderSize = 0;
            this.btnPodaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodaci.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodaci.ForeColor = System.Drawing.Color.White;
            this.btnPodaci.Location = new System.Drawing.Point(614, 251);
            this.btnPodaci.Name = "btnPodaci";
            this.btnPodaci.Size = new System.Drawing.Size(150, 30);
            this.btnPodaci.TabIndex = 32;
            this.btnPodaci.Text = "Podaci o klubu";
            this.btnPodaci.UseVisualStyleBackColor = false;
            this.btnPodaci.Click += new System.EventHandler(this.btnPodaci_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(252, 215);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(72, 15);
            this.lblDatum.TabIndex = 34;
            this.lblDatum.Text = "01.01.2019.";
            // 
            // lblDatumNaslov
            // 
            this.lblDatumNaslov.AutoSize = true;
            this.lblDatumNaslov.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.lblDatumNaslov.Location = new System.Drawing.Point(252, 193);
            this.lblDatumNaslov.Name = "lblDatumNaslov";
            this.lblDatumNaslov.Size = new System.Drawing.Size(108, 18);
            this.lblDatumNaslov.TabIndex = 33;
            this.lblDatumNaslov.Text = "Datum kreiranja:";
            // 
            // FrmRibickiKlubPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblDatumNaslov);
            this.Controls.Add(this.btnPodaci);
            this.Controls.Add(this.btnDodajModeratora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.lblEmailNaslov);
            this.Controls.Add(this.LblWebNaslov);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.LblNazivNaslov);
            this.Controls.Add(this.lblTelefonNaslov);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblWeb);
            this.Controls.Add(this.lblAdresaNaslov);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPredsjednik);
            this.Controls.Add(this.LblPredsjednikNaslov);
            this.Name = "FrmRibickiKlubPocetna";
            this.Text = "FrmRibickiKlubPocetna";
            this.Load += new System.EventHandler(this.FrmRibickiKlubPocetna_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblKlubInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailNaslov;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTelefonNaslov;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label LblWebNaslov;
        private System.Windows.Forms.Label lblPredsjednik;
        private System.Windows.Forms.Label LblPredsjednikNaslov;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblAdresaNaslov;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label LblNazivNaslov;
        private System.Windows.Forms.Button btnDodajModeratora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboModerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPodaci;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblDatumNaslov;
    }
}