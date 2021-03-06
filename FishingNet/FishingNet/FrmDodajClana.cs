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
    public partial class FrmDodajClana : Form
    {
        private ClanRibickogKluba odabraniClan = null;
        public FrmDodajClana()
        {
            InitializeComponent();
            
        }
        public FrmDodajClana(ClanRibickogKluba clan)
        {
            InitializeComponent();
            odabraniClan = clan;
        }

        private bool ProvjeraOIB(int oib)
        {
            using(var db = new FishingNetEntities())
            {
                foreach (var item in db.ClanRibickogKlubas)
                {
                    if (item.OIB == oib)
                        return true;
                }
            }
            return false;
        }

        private void FrmDodajClana_Load(object sender, EventArgs e)
        {
            if (odabraniClan != null)
            {
                TxtImeClana.Text = odabraniClan.ime;
                TxtPrezimeClana.Text = odabraniClan.prezime;
                TxtOIBClana.Text = odabraniClan.OIB.ToString();
                TxtOIBClana.Enabled = false;
                TxtDrzavljanstvoClana.Text = odabraniClan.drzavljanstvo;
                TxtMjestoRodenjaClana.Text = odabraniClan.mjesto_rodenja;
                TxtAdresaClana.Text = odabraniClan.adresa;
                TxtTelefonClana.Text = odabraniClan.telefon;
                txtEmailClana.Text = odabraniClan.email;
                DatumRodenjaClana.Value = odabraniClan.datum_rodenja;
            }
        }

        private void UnesiClana()
        {
            using (var db=new FishingNetEntities())
            {
                if (odabraniClan == null)
                {
                    ClanRibickogKluba noviClan = new ClanRibickogKluba();
                    noviClan.ime = TxtImeClana.Text;
                    noviClan.prezime = TxtPrezimeClana.Text;
                    noviClan.OIB = int.Parse(TxtOIBClana.Text);
                    noviClan.drzavljanstvo = TxtDrzavljanstvoClana.Text;
                    noviClan.mjesto_rodenja = TxtMjestoRodenjaClana.Text;
                    noviClan.adresa = TxtAdresaClana.Text;
                    noviClan.telefon = TxtTelefonClana.Text;
                    noviClan.email = txtEmailClana.Text;
                    noviClan.datum_rodenja = DatumRodenjaClana.Value;
                    noviClan.datum_upisa = DateTime.Now;
                    noviClan.ribicki_klub = 1;
                    noviClan.administrator = 1;
                    if (!ProvjeraOIB(noviClan.OIB))
                    {
                        db.ClanRibickogKlubas.Add(noviClan);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Član s upisanim OIB-om već postoji!");
                    }
                }
                else
                {
                    db.ClanRibickogKlubas.Attach(odabraniClan);
                    odabraniClan.ime = TxtImeClana.Text;
                    odabraniClan.prezime = TxtPrezimeClana.Text;
                    odabraniClan.OIB = int.Parse(TxtOIBClana.Text);
                    odabraniClan.drzavljanstvo = TxtDrzavljanstvoClana.Text;
                    odabraniClan.mjesto_rodenja = TxtMjestoRodenjaClana.Text;
                    odabraniClan.adresa = TxtAdresaClana.Text;
                    odabraniClan.telefon = TxtTelefonClana.Text;
                    odabraniClan.email = txtEmailClana.Text;
                    odabraniClan.datum_rodenja = DatumRodenjaClana.Value;
                    db.SaveChanges();
                }
            }
        }

        private bool ProvjeraIspravnosti()
        {
            if(TxtAdresaClana.Text=="" &&
                TxtDrzavljanstvoClana.Text==""
                && txtEmailClana.Text==""
                && TxtImeClana.Text==""
                && TxtMjestoRodenjaClana.Text==""
                && TxtOIBClana.Text==""
                && TxtPrezimeClana.Text==""
                && TxtTelefonClana.Text==""
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnDodajClana_Click_1(object sender, EventArgs e)
        {
            if (ProvjeraIspravnosti())
            {
                UnesiClana();
                Close();
            }
            else
            {
                MessageBox.Show("Molimo ispunite sve podatke!");
            }
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
