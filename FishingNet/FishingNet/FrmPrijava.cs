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
    public partial class FrmPrijava : Form
    {
        FrmPocetna formaPocetna;
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void PrikaziFormu()
        {
            if (formaPocetna == null)
            {
                formaPocetna = new FrmPocetna();
            }
            formaPocetna.ShowDialog();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrikaziFormu();
            this.Close();

        }
    }
}
