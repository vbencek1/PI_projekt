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
    public partial class FrmDodajLokaciju : Form
    {
        private Lokacija odabranaLokacija;

        public FrmDodajLokaciju()
        {
            InitializeComponent();
            
        }

        public void DohvatiLokacije()
        {
            using (var db = new FishingNetEntities())
            {
                var query = from l in db.Lokacijas select l;
                dgvLokacije.DataSource = query.ToList();
                dgvLokacije.Columns[4].Visible = false;
                dgvLokacije.Columns[5].Visible = false;
                dgvLokacije.Columns[6].Visible = false;
            }
        }

        private void FrmDodajLokaciju_Load(object sender, EventArgs e)
        {
            DohvatiLokacije();
            TxtNazivRijeke.Focus();
        }

        private void btnAzurirajLokaciju_Click(object sender, EventArgs e)
        {
            FrmAzurirajLokaciju forma = new FrmAzurirajLokaciju(dgvLokacije.CurrentRow.DataBoundItem as Lokacija);
            forma.ShowDialog();

        }

        private void BtnDodajLokaciju_Click(object sender, EventArgs e)
        {
            using (var db = new FishingNetEntities())
            {

                Lokacija lokacija = new Lokacija
                {
                    naziv_rijeke = TxtNazivRijeke.Text,
                    grad = txtGrad.Text,
                    duljina = float.Parse(txtDuljina.Text),
                    administrator = 1
                };
                db.Lokacijas.Add(lokacija);
                db.SaveChanges();

                txtGrad.Clear();
                txtDuljina.Clear();
                TxtNazivRijeke.Clear();
                DohvatiLokacije();
            }
        }

        private void BtnObrisiLokaciju_Click(object sender, EventArgs e)
        {
            odabranaLokacija = dgvLokacije.CurrentRow.DataBoundItem as Lokacija;
            if (odabranaLokacija != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new FishingNetEntities())
                    {
                        db.Lokacijas.Attach(odabranaLokacija);
                        if(odabranaLokacija.Natjecanjes.Count == 0)
                        {
                            db.Lokacijas.Remove(odabranaLokacija);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati lokaciju na kojoj se održava natjecanje!");
                        }
                    }
                }
            }
            DohvatiLokacije();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void dgvLokacije_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            DohvatiLokacije();
        }
    }

}
