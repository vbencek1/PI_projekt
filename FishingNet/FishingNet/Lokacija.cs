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
    
    public partial class Lokacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lokacija()
        {
            this.Natjecanjes = new HashSet<Natjecanje>();
        }
    
        public int id_lokacija { get; set; }
        public string naziv_rijeke { get; set; }
        public double duljina { get; set; }
        public string grad { get; set; }
        public int administrator { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Natjecanje> Natjecanjes { get; set; }

        public override string ToString()
        {
            return naziv_rijeke + " " + grad + " " + duljina + "km ";
        }
    }
    
}