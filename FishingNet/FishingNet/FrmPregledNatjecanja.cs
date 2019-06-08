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
    public partial class FrmPregledNatjecanja : Form
    {
        public FrmPregledNatjecanja()
        {
            InitializeComponent();
        }


        private void FrmPregledNatjecanja_Load(object sender, EventArgs e)
        {
            PrikaziNatjecanja();
        }

        private void PrikaziNatjecanja()
        {
            using( var db= new FishingNetEntities())
            {
                var upit = from n in db.Natjecanjes
                           from l in db.Lokacijas
                           from m in db.Korisniks
                           where n.lokacija == l.id_lokacija && n.moderator == m.id_korisnika
                           select new
                           {
                               ID=n.id_natjecanje,
                               Naziv=n.naziv,
                               Opis=n.opis,
                               Početak=n.datum_pocetka,
                               Završetak=n.datum_zavrsetka,
                               Pobjednik=n.pobjednik,
                               Lokacija=l.naziv_rijeke+" "+ l.grad+" ("+l.duljina+" km)",
                               Kreator=m.ime+" "+m.prezime

                           };
                dgvNatjecanja.DataSource = upit.ToList();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNatjecanja forma = new FrmNatjecanja();
            forma.Closed += (s, args) => this.Close();
            forma.ShowDialog();
        }

        private void BtnDodajNatjecanje_Click(object sender, EventArgs e)
        {
            
            FrmDodajNatjecanje forma = new FrmDodajNatjecanje();
            forma.ShowDialog();
            PrikaziNatjecanja();
        }

        private void BtnAzurirajClana_Click(object sender, EventArgs e)
        {
             if(dgvNatjecanja.RowCount > 0)
                {
                int idNatjecanja = int.Parse(dgvNatjecanja.CurrentRow.Cells[0].Value.ToString());
                FrmDodajNatjecanje forma = new FrmDodajNatjecanje(idNatjecanja);
                forma.ShowDialog();
                PrikaziNatjecanja();
               }
             else
               {
               MessageBox.Show("Odaberite natjecanje!");
               }
        }
    }
}
