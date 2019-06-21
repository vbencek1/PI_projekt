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
    public partial class FrmZahtjeviPrijava : Form
    {
        CsvDataReader csvDataReader = new CsvDataReader();
        public FrmZahtjeviPrijava()
        {
            InitializeComponent();

        }

        private void FrmZahtjeviPrijava_Load(object sender, EventArgs e)
        {
            PopuniComboNatjecanja();
            PrikaziZahtjeveClanova();
            PrikaziZahtjeveEksterne();
            OznaciBojom();
        }

        private void UcitajDatoteku()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                csvDataReader.PohraniInternePrijaveUBazu(selectedFileName);
            }
        }

        private void PrikaziZahtjeveClanova()
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaClanas
                           from n in db.Natjecanjes
                           from c in db.ClanRibickogKlubas
                           from s in db.Statuses
                           where
                           z.natjecanje == n.id_natjecanje &&
                           z.clan == c.id_clana &&
                           s.id_odobreno_odbijeno == z.odobreno
                           select new
                           {
                               Id = z.id_zahtjev_za_prijavu_na_natjecanje,
                               Ime = c.ime,
                               Prezime = c.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviClanova.DataSource = upit.ToList();
            }

        }
        private void PrikaziZahtjeveEksterne()
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaExternis
                           from n in db.Natjecanjes
                           from s in db.Statuses
                           where z.natjecanje == n.id_natjecanje &&
                           s.id_odobreno_odbijeno == z.odobreno
                           select new
                           {
                               Id = z.id_eksterni,
                               Ime = z.ime,
                               Prezime = z.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviEksterni.DataSource = upit.ToList();

            }

        }

        private void FilterNatjecanjaPrikaziZahtjeveClanova(Natjecanje odabranoNatjecanje)
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaClanas
                           from n in db.Natjecanjes
                           from c in db.ClanRibickogKlubas
                           from s in db.Statuses
                           where
                           z.natjecanje == n.id_natjecanje &&
                           z.clan == c.id_clana &&
                           n.id_natjecanje == odabranoNatjecanje.id_natjecanje &&
                           s.id_odobreno_odbijeno == z.odobreno
                           select new
                           {
                               Id = z.id_zahtjev_za_prijavu_na_natjecanje,
                               Ime = c.ime,
                               Prezime = c.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviClanova.DataSource = upit.ToList();
            }

        }
        private void FilterNatjecanjaPrikaziZahtjeveEksterne(Natjecanje odabranoNatjecanje)
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaExternis
                           from n in db.Natjecanjes
                           from s in db.Statuses
                           where z.natjecanje == n.id_natjecanje &&
                           s.id_odobreno_odbijeno == z.odobreno &&
                           n.id_natjecanje == odabranoNatjecanje.id_natjecanje
                           select new
                           {
                               Id = z.id_eksterni,
                               Ime = z.ime,
                               Prezime = z.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviEksterni.DataSource = upit.ToList();

            }

        }
        private void FilterStatusaPrikaziZahtjeveClanova(Natjecanje odabranoNatjecanje, Status odabraniStatus)
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaClanas
                           from n in db.Natjecanjes
                           from c in db.ClanRibickogKlubas
                           from s in db.Statuses
                           where
                           z.natjecanje == n.id_natjecanje &&
                           z.clan == c.id_clana &&
                           n.id_natjecanje == odabranoNatjecanje.id_natjecanje &&
                           s.id_odobreno_odbijeno == z.odobreno &&
                           s.id_odobreno_odbijeno == odabraniStatus.id_odobreno_odbijeno
                           select new
                           {
                               Id = z.id_zahtjev_za_prijavu_na_natjecanje,
                               Ime = c.ime,
                               Prezime = c.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviClanova.DataSource = upit.ToList();
            }

        }
        private void FilterStatusPrikaziZahtjeveEksterne(Natjecanje odabranoNatjecanje, Status odabraniStatus)
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaExternis
                           from n in db.Natjecanjes
                           from s in db.Statuses
                           where z.natjecanje == n.id_natjecanje &&
                           s.id_odobreno_odbijeno == z.odobreno &&
                           n.id_natjecanje == odabranoNatjecanje.id_natjecanje &&
                           s.id_odobreno_odbijeno == odabraniStatus.id_odobreno_odbijeno
                           select new
                           {
                               Id = z.id_eksterni,
                               Ime = z.ime,
                               Prezime = z.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviEksterni.DataSource = upit.ToList();

            }

        }

        private void PretraziZahtjeveClanova(string rijec)
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaClanas
                           from n in db.Natjecanjes
                           from c in db.ClanRibickogKlubas
                           from s in db.Statuses
                           where
                           z.natjecanje == n.id_natjecanje &&
                           z.clan == c.id_clana &&
                           s.id_odobreno_odbijeno == z.odobreno && (
                           c.ime.Contains(rijec) || c.prezime.Contains(rijec))
                           select new
                           {
                               Id = z.id_zahtjev_za_prijavu_na_natjecanje,
                               Ime = c.ime,
                               Prezime = c.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviClanova.DataSource = upit.ToList();
            }

        }
        private void PretraziZahtjeveEksterne(string rijec)
        {

            using (var db = new FishingNetEntities())
            {
                var upit =
                           from z in db.ZahtjevZaPrijavuNatjecanjaExternis
                           from n in db.Natjecanjes
                           from s in db.Statuses
                           where z.natjecanje == n.id_natjecanje &&
                           s.id_odobreno_odbijeno == z.odobreno && (
                           z.ime.Contains(rijec) || z.prezime.Contains(rijec))
                           select new
                           {
                               Id = z.id_eksterni,
                               Ime = z.ime,
                               Prezime = z.prezime,
                               Opis = z.opis_prijave,
                               Datum = z.datum_prijave,
                               Natjecanje = n.naziv,
                               Status = s.naziv
                           };
                DgvZahtjeviEksterni.DataSource = upit.ToList();

            }

        }



        private void OznaciBojom()
        {
            for (int i = 0; i < DgvZahtjeviClanova.Rows.Count; i++)
            {
                if (DgvZahtjeviClanova.Rows[i].Cells[6].Value.ToString() == "odbijeno")
                {
                    DgvZahtjeviClanova.Rows[i].Cells[6].Style.ForeColor = Color.Red;
                }
                if (DgvZahtjeviClanova.Rows[i].Cells[6].Value.ToString() == "odobreno")
                {
                    DgvZahtjeviClanova.Rows[i].Cells[6].Style.ForeColor = Color.Green;
                }
                if (DgvZahtjeviClanova.Rows[i].Cells[6].Value.ToString() == "nije pregledano")
                {
                    DgvZahtjeviClanova.Rows[i].Cells[6].Style.ForeColor = Color.Blue;
                }

            }
            for (int i = 0; i < DgvZahtjeviEksterni.Rows.Count; i++)
            {
                if (DgvZahtjeviEksterni.Rows[i].Cells[6].Value.ToString() == "odbijeno")
                {
                    DgvZahtjeviEksterni.Rows[i].Cells[6].Style.ForeColor = Color.Red;
                }
                if (DgvZahtjeviEksterni.Rows[i].Cells[6].Value.ToString() == "odobreno")
                {
                    DgvZahtjeviEksterni.Rows[i].Cells[6].Style.ForeColor = Color.Green;
                }
                if (DgvZahtjeviEksterni.Rows[i].Cells[6].Value.ToString() == "nije pregledano")
                {
                    DgvZahtjeviEksterni.Rows[i].Cells[6].Style.ForeColor = Color.Blue;
                }

            }
        }

        private void PopuniComboNatjecanja()
        {
            using (var db = new FishingNetEntities())
            {
                ComboOdabirNatjecanja.DataSource = db.Natjecanjes.ToList();
            }
        }

        private void PopuniComboStatusa()
        {
            using (var db = new FishingNetEntities())
            {
                ComboStatusa.DataSource = db.Statuses.ToList();
            }
        }

        private ZahtjevZaPrijavuNatjecanjaClana DohvatiZahtjevClanaPrekoID(int id)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (var item in db.ZahtjevZaPrijavuNatjecanjaClanas)
                {
                    if (item.id_zahtjev_za_prijavu_na_natjecanje == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        private ZahtjevZaPrijavuNatjecanjaExterni DohvatiZahtjevEksterniPrekoID(int id)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (var item in db.ZahtjevZaPrijavuNatjecanjaExternis)
                {
                    if (item.id_eksterni == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        private void OdobriIliOdbijPrijavuClana(ZahtjevZaPrijavuNatjecanjaClana zahtjevClana, int status)
        {
            using (var db = new FishingNetEntities())
            {
                db.ZahtjevZaPrijavuNatjecanjaClanas.Attach(zahtjevClana);
                zahtjevClana.odobreno = status;
                db.SaveChanges();
            }
        }

        private void OdobriIliOdbijPrijavuExternog(ZahtjevZaPrijavuNatjecanjaExterni zahtjevExternog, int status)
        {
            using (var db = new FishingNetEntities())
            {
                db.ZahtjevZaPrijavuNatjecanjaExternis.Attach(zahtjevExternog);
                zahtjevExternog.odobreno = status;
                db.SaveChanges();
            }
        }

        private int DohvatiNatjecanje(string naziv)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (Natjecanje item in db.Natjecanjes)
                {
                    if (item.naziv == naziv)
                    {
                        return item.id_natjecanje;
                    }
                }
            }
            return 0;
        }

        private void DodajSudionikaNatjecanjaClana(int idZahtjevaClana, int idNatjecanja)
        {
            using (var db = new FishingNetEntities())
            {
                SudionikNatjecanja sudionik = new SudionikNatjecanja();
                sudionik.bodovi = 0;
                sudionik.prijava_clan = idZahtjevaClana;
                sudionik.natjecanje = idNatjecanja;
                db.SudionikNatjecanjas.Add(sudionik);
                db.SaveChanges();
            }

        }
        private void DodajSudionikaNatjecanjaEksterni(int idZahtjevaEksternog, int idNatjecanja)
        {
            using (var db = new FishingNetEntities())
            {
                SudionikNatjecanja sudionik = new SudionikNatjecanja();
                sudionik.bodovi = 0;
                sudionik.prijava_eksterni = idZahtjevaEksternog;
                sudionik.natjecanje = idNatjecanja;
                db.SudionikNatjecanjas.Add(sudionik);
                db.SaveChanges();
            }

        }


        private void BtnPreuzimiPodatke_Click(object sender, EventArgs e)
        {
            UcitajDatoteku();
            PrikaziZahtjeveClanova();
            PrikaziZahtjeveEksterne();
            OznaciBojom();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            if (DgvZahtjeviClanova.SelectedRows.Count > 0)
            {
                if (DgvZahtjeviClanova.CurrentRow.Cells[6].Value.ToString() == "nije pregledano")
                {

                    int idClana = int.Parse(DgvZahtjeviClanova.CurrentRow.Cells[0].Value.ToString());
                    ZahtjevZaPrijavuNatjecanjaClana zahtjevClana = DohvatiZahtjevClanaPrekoID(idClana);
                    OdobriIliOdbijPrijavuClana(zahtjevClana, 1);
                    string idNatjecanja = DgvZahtjeviClanova.CurrentRow.Cells[5].Value.ToString();
                    DodajSudionikaNatjecanjaClana(zahtjevClana.id_zahtjev_za_prijavu_na_natjecanje, DohvatiNatjecanje(idNatjecanja));
                    PrikaziZahtjeveClanova();
                    OznaciBojom();

                }
                else
                {
                    MessageBox.Show("Prijava je već pregledana");
                }
            }
            if (DgvZahtjeviEksterni.SelectedRows.Count > 0)
            {
                if (DgvZahtjeviEksterni.CurrentRow.Cells[6].Value.ToString() == "nije pregledano")
                {

                    int idExternog = int.Parse(DgvZahtjeviEksterni.CurrentRow.Cells[0].Value.ToString());
                    ZahtjevZaPrijavuNatjecanjaExterni zahtjevExterni = DohvatiZahtjevEksterniPrekoID(idExternog);
                    OdobriIliOdbijPrijavuExternog(zahtjevExterni, 1);
                    string idNatjecanja = DgvZahtjeviEksterni.CurrentRow.Cells[5].Value.ToString();
                    DodajSudionikaNatjecanjaEksterni(zahtjevExterni.id_eksterni, DohvatiNatjecanje(idNatjecanja));
                    PrikaziZahtjeveEksterne();
                    OznaciBojom();

                }
                else
                {
                    MessageBox.Show("Prijava je već pregledana");
                }
            }

        }

        private void BtnOdbij_Click(object sender, EventArgs e)
        {
            if (DgvZahtjeviClanova.SelectedRows.Count > 0)
            {
                if (DgvZahtjeviClanova.CurrentRow.Cells[6].Value.ToString() == "nije pregledano")
                {

                    int idClana = int.Parse(DgvZahtjeviClanova.CurrentRow.Cells[0].Value.ToString());
                    ZahtjevZaPrijavuNatjecanjaClana zahtjevClana = DohvatiZahtjevClanaPrekoID(idClana);
                    OdobriIliOdbijPrijavuClana(zahtjevClana, 2);
                    PrikaziZahtjeveClanova();
                    OznaciBojom();

                }
                else
                {
                    MessageBox.Show("Prijava je već pregledana");
                }
            }
            if (DgvZahtjeviEksterni.SelectedRows.Count > 0)
            {
                if (DgvZahtjeviEksterni.CurrentRow.Cells[6].Value.ToString() == "nije pregledano")
                {

                    int idExternog = int.Parse(DgvZahtjeviEksterni.CurrentRow.Cells[0].Value.ToString());
                    ZahtjevZaPrijavuNatjecanjaExterni zahtjevExterni = DohvatiZahtjevEksterniPrekoID(idExternog);
                    OdobriIliOdbijPrijavuExternog(zahtjevExterni, 2);
                    PrikaziZahtjeveEksterne();
                    OznaciBojom();

                }
                else
                {
                    MessageBox.Show("Prijava je već pregledana");
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void ComboOdabirNatjecanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Natjecanje natjecanje = ComboOdabirNatjecanja.SelectedItem as Natjecanje;
            FilterNatjecanjaPrikaziZahtjeveClanova(natjecanje);
            FilterNatjecanjaPrikaziZahtjeveEksterne(natjecanje);
            OznaciBojom();
            PopuniComboStatusa();
            TxtPretraziZahtjeve.Clear();
        }

        private void ComboStatusa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Natjecanje natjecanje = ComboOdabirNatjecanja.SelectedItem as Natjecanje;
            Status status = ComboStatusa.SelectedItem as Status;
            FilterStatusaPrikaziZahtjeveClanova(natjecanje, status);
            FilterStatusPrikaziZahtjeveEksterne(natjecanje, status);
            OznaciBojom();
            TxtPretraziZahtjeve.Clear();
        }

        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziZahtjeveClanova();
            PrikaziZahtjeveEksterne();
            OznaciBojom();
            TxtPretraziZahtjeve.Clear();
        }


        private void TxtPretraziZahtjeve_TextChanged(object sender, EventArgs e)
        {
            PretraziZahtjeveClanova(TxtPretraziZahtjeve.Text);
            PretraziZahtjeveEksterne(TxtPretraziZahtjeve.Text);
            OznaciBojom();
        }
    }
}
