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
    public partial class FrmPregledNatjecanja : Form
    {
        public FrmPregledNatjecanja()
        {
            InitializeComponent();
            PopuniComboLokacija();
        }


        private void FrmPregledNatjecanja_Load(object sender, EventArgs e)
        {
            PrikaziNatjecanja();
        }

        private void PrikaziNatjecanja()
        {
            using( var db= new FishingNetEntities())
            {
                var upit = from n in db.Natjecanjes
                           from l in db.Lokacijas
                           from m in db.Korisniks
                           where n.lokacija == l.id_lokacija && n.moderator == m.id_korisnika
                           select new
                           {
                               ID=n.id_natjecanje,
                               Naziv=n.naziv,
                               Opis=n.opis,
                               Početak=n.datum_pocetka,
                               Završetak=n.datum_zavrsetka,
                               Pobjednik=n.pobjednik,
                               Lokacija=l.naziv_rijeke+" "+ l.grad+" ("+l.duljina+" km)",
                               Kreator=m.ime+" "+m.prezime

                           };
                dgvNatjecanja.DataSource = upit.ToList();
            }
        }

        private void PopuniComboLokacija()
        {
            
            using(var db= new FishingNetEntities())
            {
                var upit = from l in db.Lokacijas orderby l.naziv_rijeke select l;
                ComboLokacije.DataSource = upit.ToList();
            }
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

        private void ObrisiNatjecanje(Natjecanje natjecanje)
        {
            using (var db = new FishingNetEntities())
            {
                db.Natjecanjes.Attach(natjecanje);
                db.Natjecanjes.Remove(natjecanje);
                db.SaveChanges();
            }
        }

        private void FiltrirajPoLokaciji(Lokacija lokacija)
        {
            using (var db = new FishingNetEntities())
            {
                var upit = from n in db.Natjecanjes
                           from l in db.Lokacijas
                           from m in db.Korisniks
                           where n.lokacija == l.id_lokacija && n.moderator == m.id_korisnika && n.lokacija==lokacija.id_lokacija
                           select new
                           {
                               ID = n.id_natjecanje,
                               Naziv = n.naziv,
                               Opis = n.opis,
                               Početak = n.datum_pocetka,
                               Završetak = n.datum_zavrsetka,
                               Pobjednik = n.pobjednik,
                               Lokacija = l.naziv_rijeke + " " + l.grad + " (" + l.duljina + " km)",
                               Kreator = m.ime + " " + m.prezime

                           };
                dgvNatjecanja.DataSource = upit.ToList();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnDodajNatjecanje_Click(object sender, EventArgs e)
        {
            
            FrmDodajNatjecanje forma = new FrmDodajNatjecanje();
            forma.ShowDialog();
            PrikaziNatjecanja();
        }

        private bool ZastitaBrisanjaNatjecanjaSaSudionicima(Natjecanje natjecanje)
        {
            using (var db = new FishingNetEntities())
            {
                var upit = (from s in db.SudionikNatjecanjas
                            where s.natjecanje == natjecanje.id_natjecanje
                            select s.id_sudionika).Count();
                if (upit == 0)
                {
                    return true;
                }
            }return false;

        }


        private void BtnAzurirajClana_Click(object sender, EventArgs e)
        {
             if(dgvNatjecanja.RowCount > 0)
                {
                int idNatjecanja = int.Parse(dgvNatjecanja.CurrentRow.Cells[0].Value.ToString());
                FrmDodajNatjecanje forma = new FrmDodajNatjecanje(idNatjecanja);
                forma.ShowDialog();
                PrikaziNatjecanja();
               }
             else
               {
               MessageBox.Show("Odaberite natjecanje!");
               }
        }

        private void BtnObrisiClana_Click(object sender, EventArgs e)
        {
            if (dgvNatjecanja.RowCount > 0)
            {
               
                int idNatjecanja = int.Parse(dgvNatjecanja.CurrentRow.Cells[0].Value.ToString());
                if (ZastitaBrisanjaNatjecanjaSaSudionicima(DohvatiNatjecanje(idNatjecanja))){

                    ObrisiNatjecanje(DohvatiNatjecanje(idNatjecanja));
                    MessageBox.Show("Natjecanje obrisano!");
                }
                else
                {
                    MessageBox.Show("Ne mogu se brisati natjecanja koja imaju sudionike!");
                }
                PrikaziNatjecanja();
            }
            else
            {
                MessageBox.Show("Odaberite natjecanje!");
            }
        }

        private void BtnPregledajNatjecanje_Click(object sender, EventArgs e)
        {
            if (dgvNatjecanja.RowCount > 0)
            {
                int idNatjecanja = int.Parse(dgvNatjecanja.CurrentRow.Cells[0].Value.ToString());
                Hide();
                FrmInformacijeONatjecanju forma = new FrmInformacijeONatjecanju(idNatjecanja);
                forma.Closed += (s, args) => this.Close();
                forma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Odaberite natjecanje!");
            }
        }

        private void ComboLokacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lokacija lokacija = ComboLokacije.SelectedItem as Lokacija;
            FiltrirajPoLokaciji(lokacija);
        }

        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziNatjecanja();
        }
    }
}
