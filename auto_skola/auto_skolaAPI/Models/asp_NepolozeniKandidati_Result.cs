//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace auto_skolaAPI.Models
{
    using System;
    
    public partial class asp_NepolozeniKandidati_Result
    {
        public int KandidatId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumRodjenja { get; set; }
        public int SpolId { get; set; }
        public Nullable<int> StepenObrazovanja { get; set; }
        public string StrucnaSprema { get; set; }
        public string Spol { get; set; }
        public Nullable<int> BrojIzlazaka { get; set; }
    }
}
