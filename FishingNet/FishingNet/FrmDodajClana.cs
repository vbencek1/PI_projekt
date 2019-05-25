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
    public partial class FrmDodajClana : Form
    {
        public FrmDodajClana()
        {
            InitializeComponent();
            
        }


        private void OsvjeziFormu()
        {
            TxtImeClana.Clear();
            TxtPrezimeClana.Clear();
            TxtOIBClana.Clear();
            TxtDrzavljanstvoClana.Clear();
            TxtMjestoRodenjaClana.Clear();
            TxtAdresaClana.Clear();
            TxtTelefonClana.Clear();
            txtEmailClana.Clear();
        }
        private void UnesiClana()
        {
            
        }

        

        private void BtnDodajClana_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
