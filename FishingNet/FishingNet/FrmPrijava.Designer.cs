namespace FishingNet
{
    partial class FrmPrijava
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
            this.LblKorisnickoIme = new System.Windows.Forms.Label();
            this.LblLozinka = new System.Windows.Forms.Label();
            this.TxtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.BtnPrijava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKorisnickoIme
            // 
            this.LblKorisnickoIme.AutoSize = true;
            this.LblKorisnickoIme.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.LblKorisnickoIme.Location = new System.Drawing.Point(356, 249);
            this.LblKorisnickoIme.Name = "LblKorisnickoIme";
            this.LblKorisnickoIme.Size = new System.Drawing.Size(92, 15);
            this.LblKorisnickoIme.TabIndex = 0;
            this.LblKorisnickoIme.Text = "Korisničko ime:\r\n";
            // 
            // LblLozinka
            // 
            this.LblLozinka.AutoSize = true;
            this.LblLozinka.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLozinka.ForeColor = System.Drawing.Color.White;
            this.LblLozinka.Location = new System.Drawing.Point(375, 311);
            this.LblLozinka.Name = "LblLozinka";
            this.LblLozinka.Size = new System.Drawing.Size(51, 15);
            this.LblLozinka.TabIndex = 1;
            this.LblLozinka.Text = "Lozinka:";
            // 
            // TxtKorisnickoIme
            // 
            this.TxtKorisnickoIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.TxtKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKorisnickoIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.TxtKorisnickoIme.Location = new System.Drawing.Point(274, 274);
            this.TxtKorisnickoIme.Name = "TxtKorisnickoIme";
            this.TxtKorisnickoIme.Size = new System.Drawing.Size(248, 20);
            this.TxtKorisnickoIme.TabIndex = 2;
            this.TxtKorisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.TxtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLozinka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLozinka.ForeColor = System.Drawing.Color.White;
            this.TxtLozinka.Location = new System.Drawing.Point(272, 336);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.PasswordChar = '*';
            this.TxtLozinka.Size = new System.Drawing.Size(250, 20);
            this.TxtLozinka.TabIndex = 3;
            this.TxtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLozinka_KeyDown);
            // 
            // BtnPrijava
            // 
            this.BtnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(244)))));
            this.BtnPrijava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrijava.FlatAppearance.BorderSize = 0;
            this.BtnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrijava.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrijava.ForeColor = System.Drawing.Color.White;
            this.BtnPrijava.Location = new System.Drawing.Point(272, 369);
            this.BtnPrijava.Name = "BtnPrijava";
            this.BtnPrijava.Size = new System.Drawing.Size(250, 30);
            this.BtnPrijava.TabIndex = 4;
            this.BtnPrijava.Text = "Prijava";
            this.BtnPrijava.UseVisualStyleBackColor = false;
            this.BtnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FishingNet.Properties.Resources.logo250;
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 217);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(272, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(274, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 7;
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPrijava);
            this.Controls.Add(this.TxtLozinka);
            this.Controls.Add(this.TxtKorisnickoIme);
            this.Controls.Add(this.LblLozinka);
            this.Controls.Add(this.LblKorisnickoIme);
            this.Name = "FrmPrijava";
            this.ShowIcon = false;
            this.Text = "FishNet Prijava";
            this.Load += new System.EventHandler(this.FrmPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKorisnickoIme;
        private System.Windows.Forms.Label LblLozinka;
        private System.Windows.Forms.TextBox TxtKorisnickoIme;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.Button BtnPrijava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

