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
        
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {

        }

        private void BtnClanovi_Click(object sender, EventArgs e)
        {
            Hide();
            FrmClanovi forma = new FrmClanovi();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrijava forma = new FrmPrijava();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnNatjecanja_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
