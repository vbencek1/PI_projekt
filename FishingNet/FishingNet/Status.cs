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
    
    public partial class Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Status()
        {
            this.ZahtjevZaPrijavuNatjecanjaExternis = new HashSet<ZahtjevZaPrijavuNatjecanjaExterni>();
            this.ZahtjevZaPrijavuNatjecanjaClanas = new HashSet<ZahtjevZaPrijavuNatjecanjaClana>();
        }
    
        public int id_odobreno_odbijeno { get; set; }
        public string naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZahtjevZaPrijavuNatjecanjaExterni> ZahtjevZaPrijavuNatjecanjaExternis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZahtjevZaPrijavuNatjecanjaClana> ZahtjevZaPrijavuNatjecanjaClanas { get; set; }

        public override string ToString()
        {
            return naziv;
        }
    }
}
