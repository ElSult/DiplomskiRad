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
    
    public partial class asp_Termin_DaLiJeSlobodanTermin_Result
    {
        public int TerminId { get; set; }
        public System.DateTime Datum { get; set; }
        public System.TimeSpan Vrijeme { get; set; }
        public int KorisnikId { get; set; }
        public int VoziloId { get; set; }
        public string Napomena { get; set; }
        public int KandidatId { get; set; }
        public bool IsOdrzan { get; set; }
    }
}