namespace FishingNet
{
    partial class FrmStatistikaPocetna
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.LblStatistikaNatjecanja = new System.Windows.Forms.Label();
            this.cmbPopisNatjecanja = new System.Windows.Forms.ComboBox();
            this.chartZahtjevi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPodaciLokacija = new System.Windows.Forms.Button();
            this.LblPocetakNatjecanja = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelHeader.Controls.Add(this.BtnBack);
            this.PanelHeader.Controls.Add(this.PicMaliLogo);
            this.PanelHeader.Controls.Add(this.LblStatistikaNatjecanja);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(784, 34);
            this.PanelHeader.TabIndex = 17;
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
            // LblStatistikaNatjecanja
            // 
            this.LblStatistikaNatjecanja.AutoSize = true;
            this.LblStatistikaNatjecanja.BackColor = System.Drawing.Color.Transparent;
            this.LblStatistikaNatjecanja.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatistikaNatjecanja.ForeColor = System.Drawing.Color.White;
            this.LblStatistikaNatjecanja.Location = new System.Drawing.Point(258, 5);
            this.LblStatistikaNatjecanja.Name = "LblStatistikaNatjecanja";
            this.LblStatistikaNatjecanja.Size = new System.Drawing.Size(263, 23);
            this.LblStatistikaNatjecanja.TabIndex = 12;
            this.LblStatistikaNatjecanja.Text = "STATISTIKA RIBIČKOG KLUBA";
            // 
            // cmbPopisNatjecanja
            // 
            this.cmbPopisNatjecanja.FormattingEnabled = true;
            this.cmbPopisNatjecanja.Location = new System.Drawing.Point(26, 121);
            this.cmbPopisNatjecanja.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPopisNatjecanja.Name = "cmbPopisNatjecanja";
            this.cmbPopisNatjecanja.Size = new System.Drawing.Size(170, 21);
            this.cmbPopisNatjecanja.TabIndex = 19;
            this.cmbPopisNatjecanja.SelectedValueChanged += new System.EventHandler(this.cmbPopisNatjecanja_SelectedValueChanged);
            // 
            // chartZahtjevi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartZahtjevi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartZahtjevi.Legends.Add(legend1);
            this.chartZahtjevi.Location = new System.Drawing.Point(26, 155);
            this.chartZahtjevi.Margin = new System.Windows.Forms.Padding(2);
            this.chartZahtjevi.Name = "chartZahtjevi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Odbijeni zahtjevi";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Odobreni zahtjevi";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Nepregledani zahtjevi";
            this.chartZahtjevi.Series.Add(series1);
            this.chartZahtjevi.Series.Add(series2);
            this.chartZahtjevi.Series.Add(series3);
            this.chartZahtjevi.Size = new System.Drawing.Size(306, 244);
            this.chartZahtjevi.TabIndex = 20;
            this.chartZahtjevi.Text = "chartZahtjevi";
            this.chartZahtjevi.Click += new System.EventHandler(this.chartZahtjevi_Click);
            // 
            // btnPodaciLokacija
            // 
            this.btnPodaciLokacija.BackColor = System.Drawing.Color.SlateGray;
            this.btnPodaciLokacija.FlatAppearance.BorderSize = 0;
            this.btnPodaciLokacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodaciLokacija.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodaciLokacija.ForeColor = System.Drawing.Color.White;
            this.btnPodaciLokacija.Location = new System.Drawing.Point(589, 67);
            this.btnPodaciLokacija.Name = "btnPodaciLokacija";
            this.btnPodaciLokacija.Size = new System.Drawing.Size(170, 30);
            this.btnPodaciLokacija.TabIndex = 32;
            this.btnPodaciLokacija.Text = "Podaci o lokacijama\r\n";
            this.btnPodaciLokacija.UseVisualStyleBackColor = false;
            this.btnPodaciLokacija.Click += new System.EventHandler(this.btnPodaciLokacija_Click_1);
            // 
            // LblPocetakNatjecanja
            // 
            this.LblPocetakNatjecanja.AutoSize = true;
            this.LblPocetakNatjecanja.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPocetakNatjecanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.LblPocetakNatjecanja.Location = new System.Drawing.Point(23, 61);
            this.LblPocetakNatjecanja.Name = "LblPocetakNatjecanja";
            this.LblPocetakNatjecanja.Size = new System.Drawing.Size(202, 36);
            this.LblPocetakNatjecanja.TabIndex = 33;
            this.LblPocetakNatjecanja.Text = "Broj odobrenih/odbijenih prijava\r\npo natjecanju:\r\n";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(23, 104);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(116, 15);
            this.LblStatus.TabIndex = 34;
            this.LblStatus.Text = "Odaberi natjecanje:\r\n";
            // 
            // FrmStatistikaPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblPocetakNatjecanja);
            this.Controls.Add(this.btnPodaciLokacija);
            this.Controls.Add(this.chartZahtjevi);
            this.Controls.Add(this.cmbPopisNatjecanja);
            this.Controls.Add(this.PanelHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStatistikaPocetna";
            this.Text = "FrmStatistikaPocetna";
            this.Load += new System.EventHandler(this.FrmStatistikaPocetna_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblStatistikaNatjecanja;
        private System.Windows.Forms.ComboBox cmbPopisNatjecanja;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZahtjevi;
        private System.Windows.Forms.Button btnPodaciLokacija;
        private System.Windows.Forms.Label LblPocetakNatjecanja;
        private System.Windows.Forms.Label LblStatus;
    }
}