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


        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            PrikaziSvuStatistiku();
            PopuniComboLokacija();
        }

        private void PrikaziSvuStatistiku()
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

        private void PopuniComboLokacija()
        {
            List<Lokacija> lokacije;
            using (var db = new FishingNetEntities())
            {
                lokacije = db.Lokacijas.ToList();
                cmbStatistika.DataSource = lokacije;
            }
        }

        private void PrikaziStatistikuLokacija( Lokacija odabranaLokacija)
        {
            int brojNatjecanja = 0;
            int brojNatjecatelja = 0;
            using (var db = new FishingNetEntities())
            {

                foreach (Natjecanje natjecanje in db.Natjecanjes)
                {
                    if (natjecanje.lokacija==odabranaLokacija.id_lokacija)
                    {
                        brojNatjecanja++;
                    }
                }
                foreach (SudionikNatjecanja sudionik in db.SudionikNatjecanjas)
                {
                    if (sudionik.Natjecanje1.lokacija==odabranaLokacija.id_lokacija)
                    {
                        brojNatjecatelja++;
                    }
                }

                this.chartLokacija.Series["Broj natjecanja"].Points.Clear();
                this.chartLokacija.Series["Broj natjecanja"].Points.Add(brojNatjecanja);
                this.chartLokacija.Series["Broj natjecatelja"].Points.Clear();
                this.chartLokacija.Series["Broj natjecatelja"].Points.Add(brojNatjecatelja);
                chartLokacija.Update();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna forma = new FrmPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
        

        private void cmbStatistika_SelectedValueChanged(object sender, EventArgs e)
        {
            Lokacija lokacija = cmbStatistika.SelectedItem as Lokacija;
            PrikaziStatistikuLokacija(lokacija);
            
        }
    }
}
