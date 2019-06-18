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
            
            using(var db= new FishingNetEntities())
            {
                var upit = 
                           from z in db.ZahtjevZaPrijavuNatjecanjaClanas
                           from n in db.Natjecanjes
                           from c in db.ClanRibickogKlubas
                           from s in db.Statuses
                           where 
                           z.natjecanje== n.id_natjecanje &&
                           z.clan == c.id_clana &&
                           s.id_odobreno_odbijeno==z.odobreno
                           select new
                           {
                               Ime = c.ime,
                               Prezime = c.prezime,
                               Opis= z.opis_prijave,
                               Datum=z.datum_prijave,
                               Natjecanje =n.naziv,
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
                           s.id_odobreno_odbijeno==z.odobreno
                           select new
                           {
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
                           s.id_odobreno_odbijeno==odabraniStatus.id_odobreno_odbijeno
                           select new
                           {
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
                           s.id_odobreno_odbijeno == z.odobreno &&(
                           c.ime.Contains(rijec) || c.prezime.Contains(rijec))
                           select new
                           {
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
            for(int i = 0; i< DgvZahtjeviClanova.Rows.Count; i++)
            {
                if (DgvZahtjeviClanova.Rows[i].Cells[5].Value.ToString()=="odbijeno")
                {
                    DgvZahtjeviClanova.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                if (DgvZahtjeviClanova.Rows[i].Cells[5].Value.ToString() == "odobreno")
                {
                    DgvZahtjeviClanova.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                if (DgvZahtjeviClanova.Rows[i].Cells[5].Value.ToString() == "nije pregledano")
                {
                    DgvZahtjeviClanova.Rows[i].Cells[5].Style.ForeColor = Color.Blue;
                }

            }
            for (int i = 0; i < DgvZahtjeviEksterni.Rows.Count; i++)
            {
                if (DgvZahtjeviEksterni.Rows[i].Cells[5].Value.ToString() == "odbijeno")
                {
                    DgvZahtjeviEksterni.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                if (DgvZahtjeviEksterni.Rows[i].Cells[5].Value.ToString() == "odobreno")
                {
                    DgvZahtjeviEksterni.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                if (DgvZahtjeviEksterni.Rows[i].Cells[5].Value.ToString() == "nije pregledano")
                {
                    DgvZahtjeviEksterni.Rows[i].Cells[5].Style.ForeColor = Color.Blue;
                }

            }
        }

        private void PopuniComboNatjecanja()
        {
            using(var db= new FishingNetEntities())
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

        private void BtnPreuzimiPodatke_Click(object sender, EventArgs e)
        {
            UcitajDatoteku();
            PrikaziZahtjeveClanova();
            PrikaziZahtjeveEksterne();
            OznaciBojom();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {

        }

        private void BtnOdbij_Click(object sender, EventArgs e)
        {

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
