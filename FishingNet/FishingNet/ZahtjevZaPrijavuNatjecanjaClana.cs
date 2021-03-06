//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishingNet
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZahtjevZaPrijavuNatjecanjaClana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZahtjevZaPrijavuNatjecanjaClana()
        {
            this.SudionikNatjecanjas = new HashSet<SudionikNatjecanja>();
        }
    
        public int id_zahtjev_za_prijavu_na_natjecanje { get; set; }
        public string opis_prijave { get; set; }
        public System.DateTime datum_prijave { get; set; }
        public int clan { get; set; }
        public Nullable<int> odobreno { get; set; }
        public int natjecanje { get; set; }
        public Nullable<int> moderator { get; set; }
    
        public virtual ClanRibickogKluba ClanRibickogKluba { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Natjecanje Natjecanje1 { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SudionikNatjecanja> SudionikNatjecanjas { get; set; }
    }
}
