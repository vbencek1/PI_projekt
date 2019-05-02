using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingNet
{
    public class Clan
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Oib { get; set; }
        public string DatumRodenja { get; set; }
        public string Drzavljanstvo { get; set; }
        public string MjestoRodenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime DatumPridruzivanja { get; set; }

        public Clan(
            string ime,
            string prezime,
            int oib,
            string datumRodenja,
            string drzavljanstvo,
            string mjestoRodenja,
            string adresa,
            string telefon,
            string email
            )
        {
            Ime = ime;
            Prezime = prezime;
            Oib = oib;
            DatumRodenja = datumRodenja;
            Drzavljanstvo = drzavljanstvo;
            MjestoRodenja = mjestoRodenja;
            Adresa = adresa;
            Telefon = telefon;
            Email = email;
            DatumPridruzivanja = DateTime.Now;
        }
        public string IspisClana()
        {
            return Ime + " " + Prezime;
        }
    }
}
