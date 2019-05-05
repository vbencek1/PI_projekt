using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingNet
{
    class Natjecanje
    {
        public string Naziv { get; set; }
        public string Pocetak { get; set; }
        public string Kraj { get; set; }
        public string Lokacija { get; set; }
        public bool Aktivnost { get; set; }
        public string Opis { get; set; }
        public string KreatorNatjecanja { get; set; }
        public Natjecanje(string naziv, string pocetak, string kraj, string lokacija, bool aktivnost, string opis, string kreatorNatjecanja)
        {
            Naziv = naziv;
            Pocetak = pocetak;
            Kraj = kraj;
            Lokacija = lokacija;
            Aktivnost = aktivnost;
            Opis = opis;
            KreatorNatjecanja = kreatorNatjecanja;
        }
        public void IspisNatjecanja()
        {

        }
    }
}
