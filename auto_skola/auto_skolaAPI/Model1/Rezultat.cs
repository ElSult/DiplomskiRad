//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace auto_skolaAPI.Model1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezultat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezultat()
        {
            this.Polaze = new HashSet<Polaze>();
        }
    
        public int RezultatId { get; set; }
        public int BrojacTacnihOdgovora { get; set; }
        public double Rezultat1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Polaze> Polaze { get; set; }
    }
}
