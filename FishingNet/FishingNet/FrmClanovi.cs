﻿using System;
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

        public FrmClanovi()
        {
            InitializeComponent();
        }

        private void FrmClanovi_Load(object sender, EventArgs e)
        {
            OsvjeziClanove();
            TxtPretraziClanove.Clear();
            if (DohvatiAktivnogKorisnika().uloga != 1)
            {
                BtnAzurirajClana.Enabled = false;
                BtnDodajClana.Enabled = false;
                BtnObrisiClana.Enabled = false;
            }
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

        private void OsvjeziClanove()
        {
            List<ClanRibickogKluba> listaClanova;
            using(var db= new FishingNetEntities())
            {
                listaClanova = db.ClanRibickogKlubas.ToList();
            }
            dgvPopisClanova.DataSource = listaClanova;
            dgvPopisClanova.Columns[11].Visible = false;
            dgvPopisClanova.Columns[12].Visible = false;
            dgvPopisClanova.Columns[13].Visible = false;
            dgvPopisClanova.Columns[14].Visible = false;
            dgvPopisClanova.Columns[15].Visible = false;
        }
        private void PretraziClanove(string rijec)
        {
            List<ClanRibickogKluba> listaClanova;
            using (var db = new FishingNetEntities())
            {
                listaClanova = db.ClanRibickogKlubas.ToList();
            }
            List<ClanRibickogKluba> listaPretrage = new List<ClanRibickogKluba>();
            foreach (ClanRibickogKluba item in listaClanova)
            {
                string punoIme = item.ime + " " + item.prezime;
                if(punoIme.ToLower().Contains(rijec))
                {
                    listaPretrage.Add(item);
                }
            }
            dgvPopisClanova.DataSource = listaPretrage;
            dgvPopisClanova.Columns[11].Visible = false;
            dgvPopisClanova.Columns[12].Visible = false;
            dgvPopisClanova.Columns[13].Visible = false;
            dgvPopisClanova.Columns[14].Visible = false;
            dgvPopisClanova.Columns[15].Visible = false;
        }
        private void ObrisiClana(ClanRibickogKluba clan)
        {
            using (var db = new FishingNetEntities())
            {
                db.ClanRibickogKlubas.Attach(clan);
                db.ClanRibickogKlubas.Remove(clan);
                db.SaveChanges();
            }
        }

        private void BtnDodajClana_Click(object sender, EventArgs e)
        {
            FrmDodajClana forma = new FrmDodajClana();
            forma.ShowDialog();
            OsvjeziClanove();
        }


        private void BtnOsvjeziListu_Click(object sender, EventArgs e)
        {
            OsvjeziClanove();
            TxtPretraziClanove.Clear();
        }
        

        private void BtnObrisiClana_Click(object sender, EventArgs e)
        {
            if (dgvPopisClanova.Rows.Count > 0)
            {
               
                ClanRibickogKluba odabraniClan = dgvPopisClanova.CurrentRow.DataBoundItem as ClanRibickogKluba;
                ObrisiClana(odabraniClan);
                OsvjeziClanove();
            }
            
        }

        private void BtnAzurirajClana_Click(object sender, EventArgs e)
        {
            if (dgvPopisClanova.Rows.Count > 0)
            {
                ClanRibickogKluba odabraniClan = dgvPopisClanova.CurrentRow.DataBoundItem as ClanRibickogKluba;
                FrmDodajClana forma = new FrmDodajClana(odabraniClan);
                forma.ShowDialog();
                OsvjeziClanove();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna forma = new FrmPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
        private void TxtPretraziClanove_TextChanged(object sender, EventArgs e)
        {
            PretraziClanove(TxtPretraziClanove.Text);
        }

        private void LblNaziv_Click(object sender, EventArgs e)
        {

        }

        
    }
}
