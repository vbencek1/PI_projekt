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
    public partial class FrmAzurirajLokaciju : Form
    {
        private Lokacija odabranaLokacija;

        public FrmAzurirajLokaciju(Lokacija lokacija)
        {
            InitializeComponent();
            odabranaLokacija = lokacija;
        }

        private void FrmAzurirajLokaciju_Load(object sender, EventArgs e)
        {
            txtDuljina.Text = odabranaLokacija.duljina.ToString();
            txtGrad.Text = odabranaLokacija.grad;
            TxtNazivRijeke.Text = odabranaLokacija.naziv_rijeke;

        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            using(var db = new FishingNetEntities())
            {
                db.Lokacijas.Attach(odabranaLokacija);
                odabranaLokacija.duljina = float.Parse(txtDuljina.Text);
                odabranaLokacija.grad = txtGrad.Text;
                odabranaLokacija.naziv_rijeke = TxtNazivRijeke.Text;
                db.SaveChanges();
            }
            Close();
        }
    }
}
