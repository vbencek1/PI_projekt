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

        
        FrmClanovi formaClanovi;
        public FrmDodajClana()
        {
            InitializeComponent();
            if (formaClanovi == null)
                formaClanovi = new FrmClanovi();
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
            formaClanovi.DodajClana(
                TxtImeClana.Text,
                TxtPrezimeClana.Text,
                int.Parse(TxtOIBClana.Text),
                DatumRodenjaClana.Text,
                TxtDrzavljanstvoClana.Text,
                TxtMjestoRodenjaClana.Text,
                TxtAdresaClana.Text,
                TxtTelefonClana.Text,
                txtEmailClana.Text
                );
        }

        

        private void BtnDodajClana_Click_1(object sender, EventArgs e)
        {
            UnesiClana();
            OsvjeziFormu();

            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formaClanovi.ShowDialog();
            this.Close();

        }
    }
}
