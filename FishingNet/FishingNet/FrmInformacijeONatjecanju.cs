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
    public partial class FrmInformacijeONatjecanju : Form
    {
        private Natjecanje odabranoNatjecanje;
        public FrmInformacijeONatjecanju(int id)
        {
            InitializeComponent();
            odabranoNatjecanje = DohvatiNatjecanje(id);
        }
        public FrmInformacijeONatjecanju(Natjecanje natjecanje)
        {
            InitializeComponent();
            odabranoNatjecanje = natjecanje;
        }

        private Natjecanje DohvatiNatjecanje(int id)
        {
            if (id > 0)
            {
                using (var db = new FishingNetEntities())
                {
                    foreach (Natjecanje item in db.Natjecanjes)
                    {
                        if (item.id_natjecanje == id)
                        {
                            return item;
                        }
                    }
                }
            }
            return null;
        }

        private void FrmInformacijeONatjecanju_Load(object sender, EventArgs e)
        {
            LblNazivNatjecanja.Text = odabranoNatjecanje.naziv;
            PocetakNatjecanja.Text = odabranoNatjecanje.datum_pocetka.Value.ToString();
            KrajNatjecanja.Text = odabranoNatjecanje.datum_zavrsetka.Value.ToString();
            Lokacija.Text = DohvatiImeLokacije(odabranoNatjecanje.lokacija);
            KreatorNatjecanja.Text = DohvatiKreatora(odabranoNatjecanje.moderator);
            DohvatiSudionikeInterne(odabranoNatjecanje);
            DohvatiSudionikeEksterne(odabranoNatjecanje);
            LblStatus.Text=PostaviStatusNatjecanja();

        }

        private string DohvatiImeLokacije(int id)
        {
            using(var db=new FishingNetEntities())
            {
                foreach(Lokacija item in db.Lokacijas)
                {
                    if (item.id_lokacija == id)
                    {
                        return item.naziv_rijeke + " " + item.grad + " " + "(" + item.duljina + " km)";
                    }
                }
            }return null;
        }

        private string DohvatiKreatora(int id)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (Korisnik item in db.Korisniks)
                {
                    if (item.id_korisnika == id)
                    {
                        return item.ime + " " + item.prezime;
                    }
                }
            }
            return null;
        }

        private string PostaviStatusNatjecanja()
        {
            DateTime datumPocetka = odabranoNatjecanje.datum_pocetka.Value;
            DateTime datumZavrsetka = odabranoNatjecanje.datum_zavrsetka.Value;
            DateTime trenutniDatum = DateTime.Now;
            if(datumPocetka<=trenutniDatum && trenutniDatum <= datumZavrsetka)
            {
                return "U tijeku";
            }
            if (datumPocetka > trenutniDatum)
            {
                return "Ativno";
            }
            if (datumZavrsetka < trenutniDatum)
            {
                return "Neaktivno";
            }return "Nepoznato";

        }

        private void DohvatiSudionikeInterne(Natjecanje natjecanje)
        {
            
            using (var db = new FishingNetEntities())
            {
                var upit = from s in db.SudionikNatjecanjas
                           from z in db.ZahtjevZaPrijavuNatjecanjaClanas
                           from n in db.Natjecanjes
                           from c in db.ClanRibickogKlubas
                           where s.natjecanje == n.id_natjecanje &&
                           s.prijava_clan == z.id_zahtjev_za_prijavu_na_natjecanje &&
                           z.odobreno == 1 &&
                           z.clan == c.id_clana &&
                           n.id_natjecanje==natjecanje.id_natjecanje
                           select new
                           {
                               ID = s.id_sudionika,
                               Ime = c.ime,
                               Prezime = c.prezime,
                               Bodovi = s.bodovi
                           };
                DgvSudioniciInterni.DataSource = upit.ToList();
                         
            }
            
        }

        private void DohvatiSudionikeEksterne(Natjecanje natjecanje)
        {

            using (var db = new FishingNetEntities())
            {
                var upit = from s in db.SudionikNatjecanjas
                           from z in db.ZahtjevZaPrijavuNatjecanjaExternis
                           from n in db.Natjecanjes
                           where s.natjecanje == n.id_natjecanje &&
                           s.prijava_eksterni == z.id_eksterni &&
                           z.odobreno == 1 &&
                           n.id_natjecanje == natjecanje.id_natjecanje
                           select new
                           {
                               ID = s.id_sudionika,
                               Ime = z.ime,
                               Prezime = z.prezime,
                               Bodovi = s.bodovi
                           };
               DgvSudioniciExterni.DataSource = upit.ToList();

            }

        }

        private SudionikNatjecanja DohvatiSudionikaPrekoId(int id)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (SudionikNatjecanja item in db.SudionikNatjecanjas)
                {
                    if (item.id_sudionika == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        private void ObrisiSudionika(SudionikNatjecanja sudionik)
        {
            using(var db=new FishingNetEntities())
            {
                db.SudionikNatjecanjas.Attach(sudionik);
                db.SudionikNatjecanjas.Remove(sudionik);
                db.SaveChanges();
            }
        }

        private void UnesiBodoveSudioniku(SudionikNatjecanja sudionik, int bodovi)
        {
            using (var db = new FishingNetEntities())
            {
                db.SudionikNatjecanjas.Attach(sudionik);
                sudionik.bodovi = bodovi;
                db.SaveChanges();
            }
        }

        private bool ProvjeraNegativnihVrijednosti(int broj)
        {
            if (broj < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPregledNatjecanja forma = new FrmPregledNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnObrisiSudionika_Click(object sender, EventArgs e)
        {
            if (DgvSudioniciInterni.SelectedRows.Count > 0)
            {
                int idSudionika = int.Parse(DgvSudioniciInterni.CurrentRow.Cells[0].Value.ToString());
                ObrisiSudionika(DohvatiSudionikaPrekoId(idSudionika));
                DohvatiSudionikeInterne(odabranoNatjecanje);
                MessageBox.Show("Sudionik je obrisan");
            }
            if (DgvSudioniciExterni.SelectedRows.Count > 0)
            {
                int idSudionika = int.Parse(DgvSudioniciExterni.CurrentRow.Cells[0].Value.ToString());
                ObrisiSudionika(DohvatiSudionikaPrekoId(idSudionika));
                DohvatiSudionikeEksterne(odabranoNatjecanje);
                MessageBox.Show("Sudionik je obrisan");
            }
        }

        private void BtnUnesiBodove_Click(object sender, EventArgs e)
        {
            if (ProvjeraNegativnihVrijednosti(int.Parse(TxtUnosBodova.Text)))
            {
                if (DgvSudioniciInterni.SelectedRows.Count > 0)
                {
                    int idSudionika = int.Parse(DgvSudioniciInterni.CurrentRow.Cells[0].Value.ToString());
                    UnesiBodoveSudioniku(DohvatiSudionikaPrekoId(idSudionika), int.Parse(TxtUnosBodova.Text));
                    DohvatiSudionikeInterne(odabranoNatjecanje);
                }
                if (DgvSudioniciExterni.SelectedRows.Count > 0)
                {
                    int idSudionika = int.Parse(DgvSudioniciExterni.CurrentRow.Cells[0].Value.ToString());
                    UnesiBodoveSudioniku(DohvatiSudionikaPrekoId(idSudionika), int.Parse(TxtUnosBodova.Text));
                    DohvatiSudionikeEksterne(odabranoNatjecanje);
                }
            }
            else
            {
                MessageBox.Show("Dozvoljen je unos samo pozitivnih vrijednosti");
            }
        }

        private void BtnZahtjevi_Click(object sender, EventArgs e)
        {
            FrmZahtjeviPrijava forma = new FrmZahtjeviPrijava(odabranoNatjecanje);
            forma.ShowDialog();
        }
    }
}
