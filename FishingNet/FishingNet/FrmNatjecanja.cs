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
    public partial class FrmNatjecanja : Form
    {
        public FrmNatjecanja()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna forma = new FrmPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnPregledNatjecanja_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPregledNatjecanja forma = new FrmPregledNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnDodajLokaciju_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDodajLokaciju forma = new FrmDodajLokaciju();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnStatistika_Click(object sender, EventArgs e)
        {
            Hide();
            FrmStatistika forma = new FrmStatistika();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnZahtjeviPrijava_Click(object sender, EventArgs e)
        {
            Hide();
            FrmZahtjeviPrijava forma = new FrmZahtjeviPrijava();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnProglasiPobjednika_Click(object sender, EventArgs e)
        {
            Hide();
            FrmProglasiPobjednika forma = new FrmProglasiPobjednika();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
