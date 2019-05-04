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
        BindingList<Uloga> ListaUloga = new BindingList<Uloga>();
        FrmPocetna formaPocetna;
        Uloga Moderator;
        Uloga Administrator;

        public FrmPrijava()
        {
            InitializeComponent();

        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            Moderator = new Moderator("Valentino", "Bencek", "01.01.2019.", "vbencek", "123");
            Administrator = new Administrator("Sara", "Kisic", "01.01.2019.", "skisic", "123");
            ListaUloga.Add(Moderator);
            ListaUloga.Add(Administrator);
        }

        private bool Provjera(string korisnickoIme, string lozinka)
        {
            if(TxtKorisnickoIme.Text == korisnickoIme && lozinka == TxtLozinka.Text)
            {
                return true;
            }
            return false;
        }

        private bool Autentifikacija()
        {
            bool provjera = false;
            foreach (Uloga red in ListaUloga)
            {
                if(Provjera(red.KorisnickoIme, red.Lozinka))
                {
                    provjera = true;
                }
            }
            return provjera;
        }

        private void PrikaziFormu()
        {
            if (formaPocetna == null)
            {
                formaPocetna = new FrmPocetna();
            }
            formaPocetna.ShowDialog();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            if (Autentifikacija())
            {
                this.Hide();
                PrikaziFormu();
                this.Close();
            }
            else
                MessageBox.Show("Neispravni korisnički podaci!");

        }
    }
}
