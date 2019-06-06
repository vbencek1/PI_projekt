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
    public partial class FrmPrijava : Form
    {

        public FrmPrijava()
        {
            InitializeComponent();

        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
          
        }
        

        private bool Autentifikacija()
        {
            bool autentifikacija = false;
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            using(var db = new FishingNetEntities())
            {
                listaKorisnika = db.Korisniks.ToList();
            }

            foreach (var item in listaKorisnika)
            {
                if (TxtKorisnickoIme.Text == item.korisnicko_ime && TxtLozinka.Text == item.lozinka)
                    autentifikacija = true;
            }
            return autentifikacija;
        }

        private void PrikaziFormu()
        {
            
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            if (Autentifikacija())
            {
                Hide();
                FrmPocetna forma = new FrmPocetna();
                forma.Closed += (s, args) => this.Close();
                forma.ShowDialog();
            }

            else
            {
                MessageBox.Show("Pogresno uneseni korisnički podaci!");
                TxtLozinka.Clear();
            }
        }
    }
}
