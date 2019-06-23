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
    public partial class FrmProglasiPobjednika : Form
    {
        public FrmProglasiPobjednika()
        {
            InitializeComponent();
        }

        private void FrmProglasiPobjednika_Load(object sender, EventArgs e)
        {
            PopuniComboNatjecanja();
        }

        private bool ProvjeriClanstvo(int idSudionika)
        {
            using (var db = new FishingNetEntities())
            {
                var clanovi = from c in db.ClanRibickogKlubas select c.id_clana;
                List<int> lista = clanovi.ToList();
                if (lista.Contains(idSudionika))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void PopuniComboNatjecanja()
        {
            using (var db = new FishingNetEntities())
            {
                var query = from n in db.Natjecanjes select n;
                ComboOdabirNatjecanja.DataSource = query.ToList();
                ComboOdabirNatjecanja.DisplayMember = "naziv";


            }
        }

        private void PopuniComboPobjednika(Natjecanje natjecanje)
        {
            List<SudionikNatjecanja> lista;
            List<SudionikNatjecanja> listaFinal = new List<SudionikNatjecanja>();
            using (var db = new FishingNetEntities())
            {
                var query = from s in db.SudionikNatjecanjas where s.natjecanje == natjecanje.id_natjecanje orderby s.bodovi descending select s;
                int brojac = 0;
                int maxBodovi = query.Max(x => x.bodovi);
                foreach (var item in query)
                {
                    if (item.bodovi == maxBodovi)
                    {
                        brojac++;
                    }
                }
                lista = query.ToList();
                int brojac2 = 0;
                foreach (var item in lista)
                {

                    listaFinal.Add(item);
                    brojac2++;
                    if (brojac == brojac2) { break; }

                }
                ComboOdaberiPobjednika.DataSource = listaFinal;
                ComboOdaberiPobjednika.DisplayMember = "id_sudionika";

                TxtImeSudionika.Clear();
                foreach(var item in listaFinal)
                {
                    if (item.prijava_clan != null)
                    {
                        foreach (var zahtjevClana in db.ZahtjevZaPrijavuNatjecanjaClanas)
                        {
                            if (zahtjevClana.id_zahtjev_za_prijavu_na_natjecanje == item.prijava_clan)
                            {
                                foreach(var clan in db.ClanRibickogKlubas)
                                {
                                    if (clan.id_clana == zahtjevClana.clan)
                                    {
                                        TxtImeSudionika.Text +=item.id_sudionika+"= "+ clan.ime + " " + clan.prezime+Environment.NewLine;
                                    }
                                }
                            }
                        }
                    }
                    if (item.prijava_eksterni != null)
                    {
                        foreach(var zahtjevEksterni in db.ZahtjevZaPrijavuNatjecanjaExternis)
                        {
                            if (zahtjevEksterni.id_eksterni == item.prijava_eksterni)
                            {
                                TxtImeSudionika.Text += item.id_sudionika + "= " + zahtjevEksterni.ime + " " + zahtjevEksterni.prezime + Environment.NewLine;
                            }
                        }
                    }
                   
                }


            }
        }

        private void PopuniComboImePrezime()
        {
            
        }

        private void ComboOdabirNatjecanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboOdabirNatjecanja.SelectedItem != null)
            {
                Natjecanje natjecanje = ComboOdabirNatjecanja.SelectedItem as Natjecanje;
                PopuniComboPobjednika(natjecanje);
            }
        }

        private void BtnObavijestiPobjednika_Click(object sender, EventArgs e)
        {
            using (var db = new FishingNetEntities())
            {
                Email email = new Email();
                SudionikNatjecanja sudionik = ComboOdaberiPobjednika.SelectedItem as SudionikNatjecanja;
                string primatelj = "";
                string natjecanje = "";
                if (ProvjeriClanstvo(sudionik.id_sudionika))
                {
                    var query = from c in db.ClanRibickogKlubas where c.id_clana == sudionik.id_sudionika select c;
                    foreach (var item in query)
                    {
                        primatelj = item.email;
                    }
                }
                else
                {
                    var query = from c in db.ZahtjevZaPrijavuNatjecanjaExternis where c.id_eksterni == sudionik.id_sudionika select c;
                    foreach (var item in query)
                    {
                        primatelj = item.email;
                    }
                }
                Natjecanje n = ComboOdabirNatjecanja.SelectedItem as Natjecanje;
                natjecanje = n.naziv;
                string poruka = "Čestitamo, pobjednik ste natjecanja " + natjecanje + "!";
                email.PosaljiEmail(primatelj, natjecanje, poruka);
                MessageBox.Show("Uspješno ste poslali email!");

                var listaNatjecanja = from nat in db.Natjecanjes where n.id_natjecanje == n.id_natjecanje select n;
                foreach (var nat in listaNatjecanja)
                {
                    nat.pobjednik = sudionik.id_sudionika;
                }
                db.SaveChanges();
                PopuniComboNatjecanja();
            }
        }

        private void ComboOdaberiPobjednika_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
