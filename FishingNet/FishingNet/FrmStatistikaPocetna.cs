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
    public partial class FrmStatistikaPocetna : Form
    {
        public FrmStatistikaPocetna()
        {
            InitializeComponent();
        }

        private void btnPodaciLokacija_Click_1(object sender, EventArgs e)
        {
            Hide();
            FrmStatistika forma = new FrmStatistika();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna forma = new FrmPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void PopuniComboNatjecanjima()
        {
            using (var db = new FishingNetEntities())
            {
                var query = from n in db.Natjecanjes select n;
                cmbPopisNatjecanja.DataSource = query.ToList();
                cmbPopisNatjecanja.DisplayMember = "naziv";
            }
        }

        private void FrmStatistikaPocetna_Load(object sender, EventArgs e)
        {
            PopuniComboNatjecanjima();
        }
        

        private void PrikaziStatistikuZahtjeva(Natjecanje odabranoNatjecanje)
        {
            int brojOdobrenihZahtjeva = 0;
            int brojOdbijenihZahtjeva = 0;
            int brojNepregledanihZahtjeva = 0;
            using (var db = new FishingNetEntities())
            {
                foreach (var item in db.ZahtjevZaPrijavuNatjecanjaClanas)
                {
                    if (item.natjecanje == odabranoNatjecanje.id_natjecanje)
                    {
                        if (item.odobreno == 1)
                            brojOdobrenihZahtjeva++;
                        else if (item.odobreno == 2)
                            brojOdbijenihZahtjeva++;
                        else
                            brojNepregledanihZahtjeva++;
                    }
                }
                foreach (var item in db.ZahtjevZaPrijavuNatjecanjaExternis)
                {
                    if (item.natjecanje == odabranoNatjecanje.id_natjecanje)
                    {
                        if (item.odobreno == 1)
                            brojOdobrenihZahtjeva++;
                        else if (item.odobreno == 2)
                            brojOdbijenihZahtjeva++;
                        else
                            brojNepregledanihZahtjeva++;
                    }
                }
            }
            this.chartZahtjevi.Series["pie"].IsValueShownAsLabel = true;
            this.chartZahtjevi.Series["pie"].Points.Clear();
            this.chartZahtjevi.Series["pie"].Points.AddXY("Odbijeni zahtjevi", brojOdbijenihZahtjeva);
            this.chartZahtjevi.Series["pie"].Points.AddXY("Odobreni zahtjevi", brojOdobrenihZahtjeva);
            this.chartZahtjevi.Series["pie"].Points.AddXY("Nepregledani zahtjevi", brojNepregledanihZahtjeva);
            chartZahtjevi.Update();

        }
        private void cmbPopisNatjecanja_SelectedValueChanged(object sender, EventArgs e)
        {
            Natjecanje natjecanje = cmbPopisNatjecanja.SelectedItem as Natjecanje;
            PrikaziStatistikuZahtjeva(natjecanje);
        }

    }
}
