using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingNet
{
    public class Moderator : Uloga
    {
        public Moderator(string ime, string prezime, string datumRodenja, string korisnickoIme, string lozinka)
        {
            Naziv = "Moderator";
            Ime = ime;
            Prezime = prezime;
            DatumRodenja = datumRodenja;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
        }
    }
}
