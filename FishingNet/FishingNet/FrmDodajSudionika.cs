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
    public partial class FrmDodajSudionika : Form
    {
        private Natjecanje odabranoNatjecanje;
        public FrmDodajSudionika(Natjecanje natjecanje)
        {
            InitializeComponent();
            odabranoNatjecanje = natjecanje;
        }

        private void FrmDodajSudionika_Load(object sender, EventArgs e)
        {
            LblNazivNatjecanja.Text = odabranoNatjecanje.naziv;
            PopuniComboClanova();
            PopuniComboIzbora();
        }

        private void PopuniComboClanova()
        {
            List<ClanRibickogKluba> lista;
            using(var db= new FishingNetEntities())
            {
                lista = db.ClanRibickogKlubas.ToList();
                lista.Insert(0, new ClanRibickogKluba {ime="Izaberite člana(opcionalno)" });
                ComboOdaberiSudionika.DataSource = lista;
            }
        }

        private void PopuniComboIzbora()
        {
            List<Status> lista;
            using (var db = new FishingNetEntities())
            {
                lista = db.Statuses.ToList();
                ComboOdobreno.DataSource = lista;
            }
        }

        private void DodajInterniZahtjev(Natjecanje natjecanje, ClanRibickogKluba clan, Status status)
        {
            using (var db = new FishingNetEntities())
            {
                ZahtjevZaPrijavuNatjecanjaClana zahtjev = new ZahtjevZaPrijavuNatjecanjaClana();
                zahtjev.opis_prijave = TxtOpisPrijave.Text;
                zahtjev.clan = clan.id_clana;
                zahtjev.natjecanje = natjecanje.id_natjecanje;
                zahtjev.odobreno = status.id_odobreno_odbijeno;
                zahtjev.datum_prijave = DatumPrijaveSudionika.Value;
                //TO DO ---> zahtjev.moderator 
                db.ZahtjevZaPrijavuNatjecanjaClanas.Add(zahtjev);
                db.SaveChanges();
            }
        }
        private void DodajEksterniZahtjev(Natjecanje natjecanje, Status status)
        {
            using (var db = new FishingNetEntities())
            {
                ZahtjevZaPrijavuNatjecanjaExterni zahtjev = new ZahtjevZaPrijavuNatjecanjaExterni();
                zahtjev.opis_prijave = TxtOpisPrijave.Text;
                zahtjev.natjecanje = natjecanje.id_natjecanje;
                zahtjev.odobreno = status.id_odobreno_odbijeno;
                zahtjev.datum_prijave = DatumPrijaveSudionika.Value;
                //TO DO ---> zahtjev.moderator 
                zahtjev.moderator = 20;
                zahtjev.adresa = TxtAdresaSudionika.Text;
                zahtjev.ime = TxtImeSudionika.Text;
                zahtjev.prezime = TxtPrezimeSudionika.Text;
                zahtjev.OIB =int.Parse( TxtOIBSudionika.Text);
                zahtjev.telefon = TxtTelefonSudionika.Text;
                zahtjev.mjesto_rodenja = TxtMjestoRodenjaSudionika.Text;
                zahtjev.drzavljanstvo = TxtDrzavljanstvoSudionika.Text;
                zahtjev.datum_rodenja = DatumRodenjaClana.Value;
                zahtjev.email = TxtEmailSudionika.Text;
                db.ZahtjevZaPrijavuNatjecanjaExternis.Add(zahtjev);
                db.SaveChanges();
            }
        }

        private ZahtjevZaPrijavuNatjecanjaClana DohvatiZahtjevInterni(Natjecanje natjecanje, ClanRibickogKluba clan, Status status)
        {
            using (var db = new FishingNetEntities())
            {
               foreach(ZahtjevZaPrijavuNatjecanjaClana item in db.ZahtjevZaPrijavuNatjecanjaClanas)
                {
                    if(item.clan==clan.id_clana && item.natjecanje == natjecanje.id_natjecanje && item.odobreno==1)
                    {
                        return item;
                    }
                }
            }return null;
        }

        private ZahtjevZaPrijavuNatjecanjaExterni DohvatiZahtjevEksterni(Natjecanje natjecanje, Status status, int OIB)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (ZahtjevZaPrijavuNatjecanjaExterni item in db.ZahtjevZaPrijavuNatjecanjaExternis)
                {
                    if (item.OIB == OIB && item.natjecanje == natjecanje.id_natjecanje && item.odobreno == 1)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        private void DodajInternogSudionika(Natjecanje natjecanje,ZahtjevZaPrijavuNatjecanjaClana zahtjev)
        {
            using (var db = new FishingNetEntities())
            {
                SudionikNatjecanja sudionik = new SudionikNatjecanja();
                sudionik.natjecanje = natjecanje.id_natjecanje;
                sudionik.bodovi = 0;
                sudionik.prijava_clan = zahtjev.id_zahtjev_za_prijavu_na_natjecanje;
                db.SudionikNatjecanjas.Add(sudionik);
                db.SaveChanges();
            }
        }

        private void DodajExternogSudionika(Natjecanje natjecanje, ZahtjevZaPrijavuNatjecanjaExterni zahtjev)
        {
            using (var db = new FishingNetEntities())
            {
                SudionikNatjecanja sudionik = new SudionikNatjecanja();
                sudionik.natjecanje = natjecanje.id_natjecanje;
                sudionik.bodovi = 0;
                sudionik.prijava_eksterni = zahtjev.id_eksterni;
                db.SudionikNatjecanjas.Add(sudionik);
                db.SaveChanges();
            }
        }

        private bool ProvjeriAKoVecPostojiSudionikInterni(Natjecanje natjecanje, ZahtjevZaPrijavuNatjecanjaClana zahtjev)
        {
            //to do
            return true;
        }
        private bool ProvjeriAKoVecPostojiSudionikEksterni(Natjecanje natjecanje, ZahtjevZaPrijavuNatjecanjaExterni zahtjev)
        {
            //to do
            return true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUnosSudionika_Click(object sender, EventArgs e)
        {
            if (ComboOdaberiSudionika.SelectedIndex > 0)
            {
                ClanRibickogKluba clan = ComboOdaberiSudionika.SelectedItem as ClanRibickogKluba;
                Status status = ComboOdobreno.SelectedItem as Status;
                DodajInterniZahtjev(odabranoNatjecanje, clan, status);
                if (ProvjeriAKoVecPostojiSudionikInterni(odabranoNatjecanje, DohvatiZahtjevInterni(odabranoNatjecanje, clan, status)) && status.id_odobreno_odbijeno==1)
                {
                    DodajInternogSudionika(odabranoNatjecanje, DohvatiZahtjevInterni(odabranoNatjecanje, clan, status));
                    MessageBox.Show("Član je dodan na natjecanje!");
                }
                else
                {
                    if (ComboOdobreno.SelectedIndex == 1)
                    {
                        MessageBox.Show("Prijava na natjecanje je odbijena");
                    }
                    else
                    {
                        MessageBox.Show("Natjecatelj već sudjeluje na ovom natjecanju!");
                    }
                }

            }
            else
            {
                Status status = ComboOdobreno.SelectedItem as Status;
                DodajEksterniZahtjev(odabranoNatjecanje, status);
                ZahtjevZaPrijavuNatjecanjaExterni zahtjev = DohvatiZahtjevEksterni(odabranoNatjecanje, status, int.Parse(TxtOIBSudionika.Text));
                if (ProvjeriAKoVecPostojiSudionikEksterni(odabranoNatjecanje,zahtjev) && status.id_odobreno_odbijeno == 1)
                {
                    DodajExternogSudionika(odabranoNatjecanje, zahtjev);
                    MessageBox.Show("Sudionik je dodan na natjecanje!");
                }
                else
                {
                    if (ComboOdobreno.SelectedIndex == 1)
                    {
                        MessageBox.Show("Prijava na natjecanje je odbijena");
                    }
                    else
                    {
                        MessageBox.Show("Natjecatelj već sudjeluje na ovom natjecanju!");
                    }
                }

            }
        }

        private void ComboOdaberiSudionika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboOdaberiSudionika.SelectedIndex > 0)
            {
                ClanRibickogKluba clan = ComboOdaberiSudionika.SelectedItem as ClanRibickogKluba;
                TxtImeSudionika.Text = clan.ime;
                TxtPrezimeSudionika.Text = clan.prezime;
                TxtAdresaSudionika.Text = clan.adresa;
                TxtDrzavljanstvoSudionika.Text = clan.drzavljanstvo;
                TxtEmailSudionika.Text = clan.email;
                TxtOIBSudionika.Text = clan.OIB.ToString();
                TxtTelefonSudionika.Text = clan.telefon;
                TxtMjestoRodenjaSudionika.Text = clan.mjesto_rodenja;
                DatumRodenjaClana.Value = clan.datum_rodenja;
                DatumPrijaveSudionika.Value = DateTime.Now;
                TxtImeSudionika.Enabled = false;
                TxtPrezimeSudionika.Enabled = false;
                TxtAdresaSudionika.Enabled = false;
                TxtDrzavljanstvoSudionika.Enabled = false;
                TxtEmailSudionika.Enabled = false;
                TxtOIBSudionika.Enabled = false;
                TxtTelefonSudionika.Enabled = false;
                TxtMjestoRodenjaSudionika.Enabled = false;
                DatumRodenjaClana.Enabled = false;
            }
            else
            {
                TxtImeSudionika.Text = "";
                TxtPrezimeSudionika.Text = "";
                TxtAdresaSudionika.Text = "";
                TxtDrzavljanstvoSudionika.Text = "";
                TxtEmailSudionika.Text = "";
                TxtOIBSudionika.Text = "";
                TxtTelefonSudionika.Text = "";
                TxtMjestoRodenjaSudionika.Text = "";
                DatumRodenjaClana.Value = DateTime.Now;
                DatumPrijaveSudionika.Value = DateTime.Now;
                TxtImeSudionika.Enabled = true;
                TxtPrezimeSudionika.Enabled = true;
                TxtAdresaSudionika.Enabled = true;
                TxtDrzavljanstvoSudionika.Enabled = true;
                TxtEmailSudionika.Enabled = true;
                TxtOIBSudionika.Enabled = true;
                TxtTelefonSudionika.Enabled = true;
                TxtMjestoRodenjaSudionika.Enabled = true;
                DatumRodenjaClana.Enabled = true;
            }
            
        }
    }
}
