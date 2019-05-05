using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingNet
{
    class RibickiKlub
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Predsjednik { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string WebAdresa { get; set; }
        public RibickiKlub(string naziv, string adresa, string predsjednik, string telefon, string email, string webAdresa)
        {
            Naziv = naziv;
            Adresa = adresa;
            Predsjednik = predsjednik;
            Telefon = telefon;
            Email = email;
            WebAdresa = webAdresa;
        }
    }
}
