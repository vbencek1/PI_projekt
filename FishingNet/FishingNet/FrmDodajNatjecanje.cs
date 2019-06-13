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
    public partial class FrmDodajNatjecanje : Form
    {
        private Natjecanje odabranoNatjecanje = null;
        public FrmDodajNatjecanje()
        {
            InitializeComponent();
        }
        public FrmDodajNatjecanje(int id)
        {
            InitializeComponent();
            odabranoNatjecanje = DohvatiNatjecanje(id);
        }

        private Natjecanje DohvatiNatjecanje(int id)
        {
            if (id > 0)
            {
                using( var db=new FishingNetEntities())
                {
                    foreach(Natjecanje item in db.Natjecanjes)
                    {
                        if (item.id_natjecanje == id)
                        {
                            return item;
                        }
                    }
                }
            }return null;
        }

        private void PopuniComboLokacijaAzuriranja(int idLokacije)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (Lokacija item in ComboLokacija.Items)
                {
                    if (item.id_lokacija == idLokacije)
                    {
                        ComboLokacija.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void PopuniComboModeratoraAzuriranja(int idModeratora)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (Korisnik item in ComboKreatorNatjecanja.Items)
                {
                    if (item.id_korisnika == idModeratora)
                    {
                        ComboKreatorNatjecanja.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void FrmDodajNatjecanje_Load(object sender, EventArgs e)
        {
            PopuniLokacije();
            PopuniModeratore();
            if (odabranoNatjecanje != null)
            {
               TxtNazivNatjecanja.Text=odabranoNatjecanje.naziv;
               TxtOpisNatjecanja.Text=odabranoNatjecanje.opis;
               PocetakNatjecanja.Value =odabranoNatjecanje.datum_pocetka.Value;
               KrajNatjecanja.Value =odabranoNatjecanje.datum_zavrsetka.Value;
                PopuniComboModeratoraAzuriranja(odabranoNatjecanje.moderator);
                PopuniComboLokacijaAzuriranja(odabranoNatjecanje.lokacija);
            }
        }

        private void PopuniLokacije()
        {
            List<Lokacija> lokacija;
            using (var db = new FishingNetEntities())
            {
                lokacija = db.Lokacijas.ToList();
            }
            ComboLokacija.DataSource = lokacija;
        }
        private void PopuniModeratore()
        {
            using (var db = new FishingNetEntities())
            {
                IQueryable<Korisnik> upit = from m in db.Korisniks where m.uloga_id_uloga == 2 select m;
                ComboKreatorNatjecanja.DataSource = upit.ToList();
            }
        }

        private void DodajNatjecanje(Korisnik korisnik, Lokacija lokacija)
        {
            using (var db = new FishingNetEntities())
            {
                if (odabranoNatjecanje == null)
                {
                    Natjecanje natjecanje = new Natjecanje();
                    natjecanje.naziv = TxtNazivNatjecanja.Text;
                    natjecanje.opis = TxtOpisNatjecanja.Text;
                    natjecanje.datum_pocetka = PocetakNatjecanja.Value;
                    natjecanje.datum_zavrsetka = KrajNatjecanja.Value;
                    natjecanje.moderator =korisnik.id_korisnika;
                    natjecanje.lokacija =lokacija.id_lokacija;
                   
                    db.Natjecanjes.Add(natjecanje);
                    db.SaveChanges();
                }
                else
                {
                   db.Natjecanjes.Attach(odabranoNatjecanje);
                   odabranoNatjecanje.naziv = TxtNazivNatjecanja.Text;
                   odabranoNatjecanje.opis = TxtOpisNatjecanja.Text;
                   odabranoNatjecanje.datum_pocetka = PocetakNatjecanja.Value;
                   odabranoNatjecanje.datum_zavrsetka = KrajNatjecanja.Value;
                   odabranoNatjecanje.moderator = korisnik.id_korisnika;
                   odabranoNatjecanje.lokacija = lokacija.id_lokacija;
                   db.SaveChanges();
                }
            }
        }

        private bool ProvjeriPodatke()
        {
            if(TxtNazivNatjecanja.Text=="" || TxtOpisNatjecanja.Text == "")
            {
                return false;
            }
            return true;
        }

        private void BtnUnesiNatjecanje_Click(object sender, EventArgs e)
        {
            if (ProvjeriPodatke())
            {
                Korisnik korisnik = ComboKreatorNatjecanja.SelectedItem as Korisnik;
                Lokacija lokacija = ComboLokacija.SelectedItem as Lokacija;
                DodajNatjecanje(korisnik, lokacija);
                Close();
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti ispunjena!");
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
