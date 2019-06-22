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
    public partial class FrmPopisModeratora : Form
    {
        public FrmPopisModeratora()
        {
            InitializeComponent();
        }

        private void FrmPopisModeratora_Load(object sender, EventArgs e)
        {
            PrikaziModeratore();
        }

        private void PrikaziModeratore()
        {
            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.Korisniks
                               //from d in db.Ulogas
                           where
                           z.uloga_id_uloga == 2
                           select new
                           {
                               ID = z.id_korisnika,
                               Ime = z.ime,
                               Prezime = z.prezime,
                               Korisnicko_ime = z.korisnicko_ime,
                               Email = z.email,
                               Vrijeme_registracije = z.datum_vrijeme_registracije
                           };
                dgvPopisModeratora.DataSource = upit.ToList();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRibickiKlubPocetna forma = new FrmRibickiKlubPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
