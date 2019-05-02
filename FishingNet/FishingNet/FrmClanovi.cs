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
    public partial class FrmClanovi : Form
    {
        FrmDodajClana formaDodaj;
        public static List<Clan> ListaClanova;

        public FrmClanovi()
        {
            InitializeComponent();
            ListaClanova = new List<Clan>();

        }

        private void PrikaziFormu()
        {
            if (formaDodaj == null)
            {
                formaDodaj = new FrmDodajClana();
            }
            formaDodaj.Show();
        }

        public void DodajClana(
            string ime,
            string prezime,
            int oib,
            string datumRodenja,
            string drzavljanstvo,
            string mjestoRodenja,
            string adresa,
            string telefon,
            string email
            )
        {
            if (Provjera(oib))
            {
                MessageBox.Show("Član ne može biti unese. Uneseni oib već postoji!");
            }
            else
            {
                Clan noviClan = new Clan(ime, prezime, oib, datumRodenja, drzavljanstvo, mjestoRodenja, adresa, telefon, email);
                ListaClanova.Add(noviClan);
                int i = ListaClanova.Count;
                MessageBox.Show("Unesen je novi član: " + i + " " + ListaClanova.ElementAt(ListaClanova.Count - 1).IspisClana());
            }
        }
        private void OsvjeziFormu()
        {
            LstClanova.Items.Clear();
            foreach(Clan redak in ListaClanova)
            {
                LstClanova.Items.Add(ListaClanova.IndexOf(redak) + ". "+redak.IspisClana());
                
            }

           

        }
        private bool Provjera(int oib)
        {
            foreach (Clan redak in ListaClanova)
            {
                if (redak.Oib == oib)
                {

                    return true;
                }
            }return false;
        }
        private void Pretraga(string rijec)
        {
            LstClanova.Items.Clear();
            foreach (Clan redak in ListaClanova)
            {
                if (redak.Ime.Contains(rijec) || redak.Prezime.Contains(rijec))
                {

                    LstClanova.Items.Add(ListaClanova.IndexOf(redak)+". "+redak.IspisClana());
                }
            }
        }
        private void ObrisiClana(int index)
        {
            int id = index;
            for(int i = 0; i < ListaClanova.Count - 1; i++)
            {
                ListaClanova.Remove(ListaClanova.ElementAt(i));
            }
        }

        private void BtnDodajClana_Click(object sender, EventArgs e)
        {
            PrikaziFormu();
            
        }
        

        //ovo treba maknut bez da se makne forma
        private void LstClanova_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BtnOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziFormu();
        }

        private void BtnPretraziClanove_Click(object sender, EventArgs e)
        {
            Pretraga(TxtPretraziClanove.Text);
        }

        private void BtnObrisiClana_Click(object sender, EventArgs e)
        {
            ObrisiClana(LstClanova.SelectedIndex);
            OsvjeziFormu();
        }

        private void LblNaziv_Click(object sender, EventArgs e)
        {

        }
    }
}
