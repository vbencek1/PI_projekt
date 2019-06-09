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
        private List<Korisnik> listaKorisnika {get;set;}
        //public Korisnik PrijavljeniKorisnik { get; set; }

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
            listaKorisnika = new List<Korisnik>();
            using (var db = new FishingNetEntities())
            {
                listaKorisnika = db.Korisniks.ToList();
            }

            foreach (var item in listaKorisnika)
            {
                if (TxtKorisnickoIme.Text == item.korisnicko_ime && TxtLozinka.Text == item.lozinka)
                {
                    autentifikacija = true;
                }
                    
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
                MessageBox.Show("Pogrešno uneseni korisnički podaci!");
                TxtLozinka.Clear();
            }
        }

        private void TxtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnPrijava_Click(this, new EventArgs());
            }
        }

        //public void Odjava()
        //{
        //    if (PrijavljeniKorisnik != null)
        //    {
        //        PrijavljeniKorisnik = null;
        //    }

        //}

        //public void PrijaviKorisnika()
        //{
        //    if (Autentifikacija())
        //    {
        //        PrijavljeniKorisnik = new Korisnik();
        //        PrijavljeniKorisnik = listaKorisnika.First(k => k.korisnicko_ime == "admin");
        //    }
        //}

    }
}
