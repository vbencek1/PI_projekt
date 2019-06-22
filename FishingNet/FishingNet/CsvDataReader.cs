using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace FishingNet
{
    class CsvDataReader
    {
        public void PohraniInternePrijaveUBazu(string putanja)
        {
            var path= putanja;
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;
                
                csvParser.ReadLine();

                using (var db = new FishingNetEntities())
                {
                    while (!csvParser.EndOfData)
                    {
                        var values = csvParser.ReadFields();
                        if (values[2] == "Da")
                        {
                            if (DohvatiClana(int.Parse(values[3])) != null)
                            {
                                ZahtjevZaPrijavuNatjecanjaClana zahtjev = new ZahtjevZaPrijavuNatjecanjaClana();
                                zahtjev.datum_prijave = DateTime.Now;
                                zahtjev.clan = DohvatiClana(int.Parse(values[3])).id_clana;
                                zahtjev.opis_prijave = values[12];
                                zahtjev.natjecanje = DohvatiNatjecanje(values[1]).id_natjecanje;
                                zahtjev.odobreno = 3;
                                db.ZahtjevZaPrijavuNatjecanjaClanas.Add(zahtjev);
                                db.SaveChanges();
                            }
                        }
                        if (values[2] == "Ne")
                        {
                            ZahtjevZaPrijavuNatjecanjaExterni zahtjev = new ZahtjevZaPrijavuNatjecanjaExterni();
                            zahtjev.natjecanje = DohvatiNatjecanje(values[1]).id_natjecanje;
                            zahtjev.OIB = int.Parse(values[3]);
                            zahtjev.ime = values[4];
                            zahtjev.prezime = values[5];
                            zahtjev.datum_rodenja = DateTime.Parse(values[6]);
                            zahtjev.drzavljanstvo = values[7];
                            zahtjev.mjesto_rodenja = values[8];
                            zahtjev.adresa = values[9];
                            zahtjev.email = values[10];
                            zahtjev.telefon = values[11];
                            zahtjev.opis_prijave = values[12];
                            zahtjev.datum_prijave = DateTime.Now;
                            zahtjev.odobreno = 3;
                            zahtjev.moderator = 20;
                            db.ZahtjevZaPrijavuNatjecanjaExternis.Add(zahtjev);
                            db.SaveChanges();
                        }
                    }
                }      
            }
        }

        private ClanRibickogKluba DohvatiClana(int OIB)
        {
            using(var db= new FishingNetEntities())
            {
                foreach(ClanRibickogKluba item in db.ClanRibickogKlubas)
                {
                    if (item.OIB == OIB)
                    {
                        return item;
                    }
                }
            }return null;
        }
        private Natjecanje DohvatiNatjecanje(string naziv)
        {
            using (var db = new FishingNetEntities())
            {
                foreach (Natjecanje item in db.Natjecanjes)
                {
                    if (item.naziv==naziv)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
