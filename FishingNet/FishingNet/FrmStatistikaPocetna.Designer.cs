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
            this.btnPodaciLokacija = new System.Windows.Forms.Button();
            this.cmbPopisNatjecanja = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1001, 42);
            this.PanelHeader.TabIndex = 17;
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
            this.PicMaliLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PicMaliLogo.Name = "PicMaliLogo";
            this.PicMaliLogo.Size = new System.Drawing.Size(171, 32);
            this.PicMaliLogo.TabIndex = 0;
            this.PicMaliLogo.TabStop = false;
            // 
            // LblStatistikaNatjecanja
            // 
            this.LblStatistikaNatjecanja.AutoSize = true;
            this.LblStatistikaNatjecanja.BackColor = System.Drawing.Color.Transparent;
            this.LblStatistikaNatjecanja.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatistikaNatjecanja.ForeColor = System.Drawing.Color.White;
            this.LblStatistikaNatjecanja.Location = new System.Drawing.Point(344, 6);
            this.LblStatistikaNatjecanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatistikaNatjecanja.Name = "LblStatistikaNatjecanja";
            this.LblStatistikaNatjecanja.Size = new System.Drawing.Size(334, 28);
            this.LblStatistikaNatjecanja.TabIndex = 12;
            this.LblStatistikaNatjecanja.Text = "STATISTIKA RIBIČKOG KLUBA";
            // 
            // btnPodaciLokacija
            // 
            this.btnPodaciLokacija.Location = new System.Drawing.Point(743, 438);
            this.btnPodaciLokacija.Name = "btnPodaciLokacija";
            this.btnPodaciLokacija.Size = new System.Drawing.Size(178, 47);
            this.btnPodaciLokacija.TabIndex = 18;
            this.btnPodaciLokacija.Text = "Podaci o lokacijama";
            this.btnPodaciLokacija.UseVisualStyleBackColor = true;
            this.btnPodaciLokacija.Click += new System.EventHandler(this.btnPodaciLokacija_Click);
            // 
            // cmbPopisNatjecanja
            // 
            this.cmbPopisNatjecanja.FormattingEnabled = true;
            this.cmbPopisNatjecanja.Location = new System.Drawing.Point(142, 110);
            this.cmbPopisNatjecanja.Name = "cmbPopisNatjecanja";
            this.cmbPopisNatjecanja.Size = new System.Drawing.Size(121, 24);
            this.cmbPopisNatjecanja.TabIndex = 19;
            this.cmbPopisNatjecanja.SelectedValueChanged += new System.EventHandler(this.cmbPopisNatjecanja_SelectedValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 174);
            this.chart1.Name = "chart1";
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
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chartZahtjevi";
            // 
            // FrmStatistikaPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 509);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cmbPopisNatjecanja);
            this.Controls.Add(this.btnPodaciLokacija);
            this.Controls.Add(this.PanelHeader);
            this.Name = "FrmStatistikaPocetna";
            this.Text = "FrmStatistikaPocetna";
            this.Load += new System.EventHandler(this.FrmStatistikaPocetna_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblStatistikaNatjecanja;
        private System.Windows.Forms.Button btnPodaciLokacija;
        private System.Windows.Forms.ComboBox cmbPopisNatjecanja;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}