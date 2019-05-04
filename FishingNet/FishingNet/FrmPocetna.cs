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
    public partial class FrmPocetna : Form
    {
        FrmClanovi formaClanovi;
        FrmPrijava formaPrijava;
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {

        }
        private void PrikaziFormu()
        {
            if (formaClanovi == null)
            {
                formaClanovi = new FrmClanovi();
            }
            formaClanovi.ShowDialog();
        }
        private void PrikaziFormuPrijave()
        {
            if (formaPrijava == null)
            {
                formaPrijava = new FrmPrijava();
            }
            formaPrijava.ShowDialog();
        }

        private void BtnClanovi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrikaziFormu();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrikaziFormuPrijave();
            this.Close();
        }
    }
}
