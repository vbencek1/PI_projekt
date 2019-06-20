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
    public partial class FrmRibickiKlub : Form
    {
        public FrmRibickiKlub()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblKlubInfo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRibickiKlubPocetna forma = new FrmRibickiKlubPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void PopuniInformacije()
        {
            using (var db = new FishingNetEntities())
            {
                var query = from r in db.RibickiKlubs select r;
                List<RibickiKlub> lista = new List<RibickiKlub>();
                lista = query.ToList();
                foreach (var item in lista)
                {
                    if (item.id_ribicki_klub == 1)
                    {
                        TxtAdresaKluba.Text = item.adresa;
                        TxtEmailKluba.Text = item.email;
                        TxtNazivKluba.Text = item.naziv;
                        TxtPredsjednikKluba.Text = item.predsjednik;
                        TxtTelefonKluba.Text = item.telefon.ToString();
                        TxtWebAdresaKluba.Text = item.web_adresa;
                    }
                }
            }
        }

        private void FrmRibickiKlub_Load(object sender, EventArgs e)
        {
            PopuniInformacije();
        }

        private void AzurirajInformacije()
        {
            using(var db = new FishingNetEntities())
            {
                var query = from r in db.RibickiKlubs where r.id_ribicki_klub == 1 select r;
                foreach (var item in query)
                {
                    item.adresa = TxtAdresaKluba.Text;
                    item.email = TxtEmailKluba.Text;
                    item.naziv = TxtNazivKluba.Text;
                    item.predsjednik = TxtPredsjednikKluba.Text;
                    item.telefon = TxtTelefonKluba.Text;
                    item.web_adresa = TxtWebAdresaKluba.Text;
                }
                db.SaveChanges();
            }
        }

        private void BtnUnosPodataka_Click(object sender, EventArgs e)
        {
            AzurirajInformacije();
            MessageBox.Show("Podaci su uspješno ažurirani!");
            Hide();
            FrmRibickiKlubPocetna forma = new FrmRibickiKlubPocetna();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }
    }
}
