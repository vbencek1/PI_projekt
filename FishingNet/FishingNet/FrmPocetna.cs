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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private PrijavljeniKorisnik DohvatiAktivnogKorisnika()
        {
            using (var db = new FishingNetEntities())
            {
                foreach (var item in db.PrijavljeniKorisniks)
                {
                    return item;

                }
            }return null;
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = "Prijavljeni ste kao: "+ DohvatiAktivnogKorisnika().korisnicko_ime;
        }

        private void BtnClanovi_Click(object sender, EventArgs e)
        {
            Hide();
            FrmClanovi forma = new FrmClanovi();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrijava forma = new FrmPrijava();
            forma.Odjava();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnNatjecanja_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRibickiKlub_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRibickiKlubPocetna forma = new FrmRibickiKlubPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            Hide();
            FrmStatistikaPocetna forma = new FrmStatistikaPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
