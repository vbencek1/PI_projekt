﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FishingNet
{
    public partial class FrmRibickiKlubPocetna : Form
    {

        public FrmRibickiKlubPocetna()
        {
            InitializeComponent();
        }

        public bool ProvjeraKorisnika(string ime, string prezime)
        {
            using (var db = new FishingNetEntities())
            {
                var query = from k in db.Korisniks select k;
                foreach (var item in query)
                {
                    if (item.ime == ime && item.prezime == prezime)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void PopuniCombo()
        {
            using(var db = new FishingNetEntities())
            {
                var query = from c in db.ClanRibickogKlubas select c;
                List<ClanRibickogKluba> listaModeratora = new List<ClanRibickogKluba>();
                string ime = "";
                string prezime = "";
                foreach (var item in query)
                {
                    ime = item.ime;
                    prezime = item.prezime;
                    if (!ProvjeraKorisnika(ime, prezime))
                    {
                        listaModeratora.Add(item);
                    }
                }
                comboModerator.DataSource = listaModeratora;
                comboModerator.DisplayMember = "prezime";
            }
        }

        public void PopuniInformacije()
        {
            using (var db = new FishingNetEntities())
            {
                var query = from r in db.RibickiKlubs select r;
                List<RibickiKlub> lista = new List<RibickiKlub>();
                lista = query.ToList();

                foreach (var item in lista)
                {
                    if (item.id_ribicki_klub == 1)
                    {
                        lblAdresa.Text = item.adresa;
                        lblEmail.Text = item.email;
                        lblDatum.Text = item.datum_kreiranja.ToString();
                        lblNaziv.Text = item.naziv;
                        lblPredsjednik.Text = item.predsjednik;
                        lblTelefon.Text = item.telefon.ToString();
                        lblWeb.Text = item.web_adresa;
                    }
                }
            }
        }

        private void LblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnPodaci_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRibickiKlub forma = new FrmRibickiKlub();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private PrijavljeniKorisnik DohvatiAktivnogKorisnika()
        {
            using (var db = new FishingNetEntities())
            {
                foreach (var item in db.PrijavljeniKorisniks)
                {
                    return item;

                }
            }
            return null;
        }

        private void FrmRibickiKlubPocetna_Load(object sender, EventArgs e)
        {
            PopuniCombo();
            PopuniInformacije();
            if (DohvatiAktivnogKorisnika().uloga != 1)
            {
                btnDodajModeratora.Enabled = false;
                btnPodaci.Enabled = false;
            }
        }

        private void comboModerator_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((ClanRibickogKluba)e.ListItem).ime;
            string prezime = ((ClanRibickogKluba)e.ListItem).prezime;
            e.Value = ime + " " + prezime;
        }

        private void btnDodajModeratora_Click(object sender, EventArgs e)
        {
            DodajModeratora();
        }

        private string GenerirajKorisnickoIme(ClanRibickogKluba clan)
        {
            string korisnickoIme = "";            
            int maxDuljina = 10;
            int minDuljina = 5;

            korisnickoIme += clan.ime.Substring(0, 1);
            korisnickoIme += clan.prezime;
            if (korisnickoIme.Length > maxDuljina)
            {
                korisnickoIme = korisnickoIme.Substring(0, maxDuljina);
            }
            else if (korisnickoIme.Length < minDuljina)
            {
                int brojZnakovaKojiFale = minDuljina - korisnickoIme.Length;
                Random r = new Random();
                for (int i = 0; i < brojZnakovaKojiFale; i++)
                {
                    korisnickoIme += r.Next(0, 9);
                }
            }

            return korisnickoIme.ToLower();

        }

        private string GenerirajLozinku()
        {
            string lozinka = "";
            Random r = new Random();
            for(int i = 0; i < 6; i++)
            {
                lozinka += r.Next(0, 9);
            }
            return lozinka;
        }

        private void DodajModeratora()
        {
            using (var db = new FishingNetEntities())
            {
                ClanRibickogKluba clan;
                clan = (ClanRibickogKluba)comboModerator.SelectedItem;

                Korisnik korisnik = new Korisnik
                {
                    ime = clan.ime,
                    prezime = clan.prezime,
                    email = clan.email,
                    korisnicko_ime = GenerirajKorisnickoIme(clan),
                    lozinka = GenerirajLozinku(),
                    datum_vrijeme_registracije = DateTime.Now,
                    uloga_id_uloga = 2
                };
                db.Korisniks.Add(korisnik);
                MessageBox.Show("Uspješno ste dodali novog moderatora!");
                db.SaveChanges();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna forma = new FrmPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnPopisModeratora_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPopisModeratora forma = new FrmPopisModeratora();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
