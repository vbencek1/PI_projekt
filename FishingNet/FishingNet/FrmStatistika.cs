using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingNet
{
    public partial class FrmStatistika : Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            int brojNatjecanja = 0;
            int brojLokacija = 0;
            int brojNatjecatelja = 0;
            using (var db = new FishingNetEntities())
            {
                foreach (Natjecanje item in db.Natjecanjes)
                {
                    brojNatjecanja++;
                }
                foreach (Lokacija item in db.Lokacijas)
                {
                    brojLokacija++;
                }
                foreach (SudionikNatjecanja item in db.SudionikNatjecanjas)
                {
                    brojNatjecatelja++;
                }
                this.chartStatistika.Series["Broj natjecatelja"].Points.Add(brojNatjecatelja);
                this.chartStatistika.Series["Broj natjecanja"].Points.Add(brojNatjecanja);
                this.chartStatistika.Series["Broj lokacija natjecanja"].Points.Add(brojLokacija);
            }

        }
    }
}
