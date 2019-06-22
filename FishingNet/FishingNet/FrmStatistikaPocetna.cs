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
    public partial class FrmStatistikaPocetna : Form
    {
        public FrmStatistikaPocetna()
        {
            InitializeComponent();
        }

        private void btnPodaciLokacija_Click(object sender, EventArgs e)
        {
            Hide();
            FrmStatistika forma = new FrmStatistika();
            forma.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna forma = new FrmPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void PopuniComboNatjecanjima()
        {
            using (var db = new FishingNetEntities())
            {
                var query = from n in db.Natjecanjes select n;
                cmbPopisNatjecanja.DataSource = query.ToList();
                cmbPopisNatjecanja.DisplayMember = "naziv";
            }
        }

        private void FrmStatistikaPocetna_Load(object sender, EventArgs e)
        {
            PopuniComboNatjecanjima();
        }
        private void PrikaziStatistikuZahtjeva(Natjecanje odabranoNatjecanje)
        {
            int brojOdobrenihZahjteva = 0;
            int brojOdbijenihZahtjeva = 0;
            int brojNepregledanihZahtjeva = 0;
            using (var db = new FishingNetEntities())
            {

                foreach (SudionikNatjecanja sudionik in db.SudionikNatjecanjas)
                {
                  
                }
            }
        }
        private void cmbPopisNatjecanja_SelectedValueChanged(object sender, EventArgs e)
        {
            Natjecanje natjecanje = cmbPopisNatjecanja.SelectedItem as Natjecanje;
        }
    }
}
