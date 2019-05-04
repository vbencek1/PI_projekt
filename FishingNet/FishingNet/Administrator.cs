using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingNet
{
    public class Administrator:Uloga
    {
        public Administrator(string ime, string prezime, string datumRodenja, string korisnickoIme, string lozinka)
        {
            Naziv = "Administrator";
            Ime = ime;
            Prezime = prezime;
            DatumRodenja = datumRodenja;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
        }
    }
}
