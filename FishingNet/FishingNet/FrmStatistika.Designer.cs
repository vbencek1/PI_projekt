namespace FishingNet
{
    partial class FrmStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblStatistikaNatjecanja = new System.Windows.Forms.Label();
            this.chartStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbStatistika = new System.Windows.Forms.ComboBox();
            this.chartLokacija = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStatistikaPoLokaciji = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicMaliLogo = new System.Windows.Forms.PictureBox();
            this.lblOpcenitaStatistika = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLokacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).BeginInit();
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
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1067, 42);
            this.PanelHeader.TabIndex = 16;
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
            this.LblStatistikaNatjecanja.Size = new System.Drawing.Size(328, 28);
            this.LblStatistikaNatjecanja.TabIndex = 12;
            this.LblStatistikaNatjecanja.Text = "STATISTIKE RIBIČKOG KLUBA";
            // 
            // chartStatistika
            // 
            chartArea1.Name = "Statistika";
            this.chartStatistika.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistika.Legends.Add(legend1);
            this.chartStatistika.Location = new System.Drawing.Point(12, 136);
            this.chartStatistika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartStatistika.Name = "chartStatistika";
            series1.ChartArea = "Statistika";
            series1.Legend = "Legend1";
            series1.Name = "Broj natjecanja";
            series2.ChartArea = "Statistika";
            series2.Legend = "Legend1";
            series2.Name = "Broj natjecatelja";
            series3.ChartArea = "Statistika";
            series3.Legend = "Legend1";
            series3.Name = "Broj lokacija natjecanja";
            this.chartStatistika.Series.Add(series1);
            this.chartStatistika.Series.Add(series2);
            this.chartStatistika.Series.Add(series3);
            this.chartStatistika.Size = new System.Drawing.Size(539, 407);
            this.chartStatistika.TabIndex = 17;
            this.chartStatistika.Text = "chartStatistika";
            // 
            // cmbStatistika
            // 
            this.cmbStatistika.FormattingEnabled = true;
            this.cmbStatistika.Location = new System.Drawing.Point(733, 119);
            this.cmbStatistika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatistika.Name = "cmbStatistika";
            this.cmbStatistika.Size = new System.Drawing.Size(217, 24);
            this.cmbStatistika.TabIndex = 18;
            this.cmbStatistika.SelectedValueChanged += new System.EventHandler(this.cmbStatistika_SelectedValueChanged);
            // 
            // chartLokacija
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLokacija.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLokacija.Legends.Add(legend2);
            this.chartLokacija.Location = new System.Drawing.Point(656, 167);
            this.chartLokacija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartLokacija.Name = "chartLokacija";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Broj natjecanja";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Broj natjecatelja";
            this.chartLokacija.Series.Add(series4);
            this.chartLokacija.Series.Add(series5);
            this.chartLokacija.Size = new System.Drawing.Size(399, 376);
            this.chartLokacija.TabIndex = 19;
            this.chartLokacija.Text = "chart1";
            // 
            // lblStatistikaPoLokaciji
            // 
            this.lblStatistikaPoLokaciji.AutoSize = true;
            this.lblStatistikaPoLokaciji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatistikaPoLokaciji.Location = new System.Drawing.Point(689, 87);
            this.lblStatistikaPoLokaciji.Name = "lblStatistikaPoLokaciji";
            this.lblStatistikaPoLokaciji.Size = new System.Drawing.Size(269, 17);
            this.lblStatistikaPoLokaciji.TabIndex = 20;
            this.lblStatistikaPoLokaciji.Text = "Prikaz natjecatelja i natjecanja po lokaciji:";
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
            // lblOpcenitaStatistika
            // 
            this.lblOpcenitaStatistika.AutoSize = true;
            this.lblOpcenitaStatistika.Location = new System.Drawing.Point(12, 100);
            this.lblOpcenitaStatistika.Name = "lblOpcenitaStatistika";
            this.lblOpcenitaStatistika.Size = new System.Drawing.Size(162, 17);
            this.lblOpcenitaStatistika.TabIndex = 21;
            this.lblOpcenitaStatistika.Text = "Općenita statistika kluba";
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblOpcenitaStatistika);
            this.Controls.Add(this.lblStatistikaPoLokaciji);
            this.Controls.Add(this.chartLokacija);
            this.Controls.Add(this.cmbStatistika);
            this.Controls.Add(this.chartStatistika);
            this.Controls.Add(this.PanelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStatistika";
            this.Text = "FrmStatistika";
            this.Load += new System.EventHandler(this.FrmStatistika_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLokacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaliLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicMaliLogo;
        private System.Windows.Forms.Label LblStatistikaNatjecanja;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistika;
        private System.Windows.Forms.ComboBox cmbStatistika;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLokacija;
        private System.Windows.Forms.Label lblStatistikaPoLokaciji;
        private System.Windows.Forms.Label lblOpcenitaStatistika;
    }
}