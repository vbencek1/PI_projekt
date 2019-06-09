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
            this.BtnPregledNatjecanja = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.LblDodavanjeNovogClana = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicComp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicStats = new System.Windows.Forms.PictureBox();
            this.BtnStatistika = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PicWinner = new System.Windows.Forms.PictureBox();
            this.BtnProglasiPobjednika = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PicLocationIcon = new System.Windows.Forms.PictureBox();
            this.BtnDodajLokaciju = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicComp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStats)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicWinner)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLocationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPregledNatjecanja
            // 
            this.BtnPregledNatjecanja.BackColor = System.Drawing.Color.SlateGray;
            this.BtnPregledNatjecanja.FlatAppearance.BorderSize = 0;
            this.BtnPregledNatjecanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPregledNatjecanja.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPregledNatjecanja.ForeColor = System.Drawing.Color.White;
            this.BtnPregledNatjecanja.Location = new System.Drawing.Point(0, 269);
            this.BtnPregledNatjecanja.Name = "BtnPregledNatjecanja";
            this.BtnPregledNatjecanja.Size = new System.Drawing.Size(150, 31);
            this.BtnPregledNatjecanja.TabIndex = 1;
            this.BtnPregledNatjecanja.Text = "Pregled natjecanja";
            this.BtnPregledNatjecanja.UseVisualStyleBackColor = false;
            this.BtnPregledNatjecanja.Click += new System.EventHandler(this.BtnPregledNatjecanja_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelHeader.Controls.Add(this.BtnBack);
            this.PanelHeader.Controls.Add(this.PicMaliLogo);
            this.PanelHeader.Controls.Add(this.LblDodavanjeNovogClana);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(784, 34);
            this.PanelHeader.TabIndex = 32;
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
            // LblDodavanjeNovogClana
            // 
            this.LblDodavanjeNovogClana.AutoSize = true;
            this.LblDodavanjeNovogClana.BackColor = System.Drawing.Color.Transparent;
            this.LblDodavanjeNovogClana.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDodavanjeNovogClana.ForeColor = System.Drawing.Color.White;
            this.LblDodavanjeNovogClana.Location = new System.Drawing.Point(320, 5);
            this.LblDodavanjeNovogClana.Name = "LblDodavanjeNovogClana";
            this.LblDodavanjeNovogClana.Size = new System.Drawing.Size(131, 23);
            this.LblDodavanjeNovogClana.TabIndex = 12;
            this.LblDodavanjeNovogClana.Text = "NATJECANJA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.PicComp);
            this.panel1.Controls.Add(this.BtnPregledNatjecanja);
            this.panel1.Location = new System.Drawing.Point(81, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 300);
            this.panel1.TabIndex = 33;
            // 
            // PicComp
            // 
            this.PicComp.Image = global::FishingNet.Properties.Resources.competition_small_white;
            this.PicComp.Location = new System.Drawing.Point(22, 83);
            this.PicComp.Name = "PicComp";
            this.PicComp.Size = new System.Drawing.Size(103, 88);
            this.PicComp.TabIndex = 2;
            this.PicComp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.PicStats);
            this.panel2.Controls.Add(this.BtnStatistika);
            this.panel2.Location = new System.Drawing.Point(237, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 300);
            this.panel2.TabIndex = 34;
            // 
            // PicStats
            // 
            this.PicStats.Image = global::FishingNet.Properties.Resources.statistic_icon;
            this.PicStats.Location = new System.Drawing.Point(25, 83);
            this.PicStats.Name = "PicStats";
            this.PicStats.Size = new System.Drawing.Size(103, 88);
            this.PicStats.TabIndex = 3;
            this.PicStats.TabStop = false;
            // 
            // BtnStatistika
            // 
            this.BtnStatistika.BackColor = System.Drawing.Color.SlateGray;
            this.BtnStatistika.FlatAppearance.BorderSize = 0;
            this.BtnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatistika.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStatistika.ForeColor = System.Drawing.Color.White;
            this.BtnStatistika.Location = new System.Drawing.Point(0, 269);
            this.BtnStatistika.Name = "BtnStatistika";
            this.BtnStatistika.Size = new System.Drawing.Size(150, 31);
            this.BtnStatistika.TabIndex = 2;
            this.BtnStatistika.Text = "Statistika";
            this.BtnStatistika.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.PicWinner);
            this.panel3.Controls.Add(this.BtnProglasiPobjednika);
            this.panel3.Location = new System.Drawing.Point(394, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 300);
            this.panel3.TabIndex = 34;
            // 
            // PicWinner
            // 
            this.PicWinner.Image = global::FishingNet.Properties.Resources.winner_icon;
            this.PicWinner.Location = new System.Drawing.Point(33, 83);
            this.PicWinner.Name = "PicWinner";
            this.PicWinner.Size = new System.Drawing.Size(86, 88);
            this.PicWinner.TabIndex = 4;
            this.PicWinner.TabStop = false;
            // 
            // BtnProglasiPobjednika
            // 
            this.BtnProglasiPobjednika.BackColor = System.Drawing.Color.SlateGray;
            this.BtnProglasiPobjednika.FlatAppearance.BorderSize = 0;
            this.BtnProglasiPobjednika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProglasiPobjednika.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProglasiPobjednika.ForeColor = System.Drawing.Color.White;
            this.BtnProglasiPobjednika.Location = new System.Drawing.Point(0, 269);
            this.BtnProglasiPobjednika.Name = "BtnProglasiPobjednika";
            this.BtnProglasiPobjednika.Size = new System.Drawing.Size(150, 31);
            this.BtnProglasiPobjednika.TabIndex = 3;
            this.BtnProglasiPobjednika.Text = "Proglasi pobjednika";
            this.BtnProglasiPobjednika.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.panel4.Controls.Add(this.PicLocationIcon);
            this.panel4.Controls.Add(this.BtnDodajLokaciju);
            this.panel4.Location = new System.Drawing.Point(550, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 300);
            this.panel4.TabIndex = 35;
            // 
            // PicLocationIcon
            // 
            this.PicLocationIcon.Image = global::FishingNet.Properties.Resources.location_icon;
            this.PicLocationIcon.Location = new System.Drawing.Point(46, 83);
            this.PicLocationIcon.Name = "PicLocationIcon";
            this.PicLocationIcon.Size = new System.Drawing.Size(70, 88);
            this.PicLocationIcon.TabIndex = 5;
            this.PicLocationIcon.TabStop = false;
            // 
            // BtnDodajLokaciju
            // 
            this.BtnDodajLokaciju.BackColor = System.Drawing.Color.SlateGray;
            this.BtnDodajLokaciju.FlatAppearance.BorderSize = 0;
            this.BtnDodajLokaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajLokaciju.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajLokaciju.ForeColor = System.Drawing.Color.White;
            this.BtnDodajLokaciju.Location = new System.Drawing.Point(0, 269);
            this.BtnDodajLokaciju.Name = "BtnDodajLokaciju";
            this.BtnDodajLokaciju.Size = new System.Drawing.Size(150, 31);
            this.BtnDodajLokaciju.TabIndex = 4;
            this.BtnDodajLokaciju.Text = "Dodaj lokaciju";
            this.BtnDodajLokaciju.UseVisualStyleBackColor = false;
            this.BtnDodajLokaciju.Click += new System.EventHandler(this.BtnDodajLokaciju_Click);
            // 
            // FrmNatjecanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHeader);
            this.Name = "FrmNatjecanja";
            this.Text = "FrmNatjecanja";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicComp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicStats)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicWinner)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLocationIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnPregledNatjecanja;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblDodavanjeNovogClana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PicComp;
        private System.Windows.Forms.PictureBox PicStats;
        private System.Windows.Forms.Button BtnStatistika;
        private System.Windows.Forms.Button BtnProglasiPobjednika;
        private System.Windows.Forms.Button BtnDodajLokaciju;
        private System.Windows.Forms.PictureBox PicWinner;
        private System.Windows.Forms.PictureBox PicLocationIcon;
    }
}