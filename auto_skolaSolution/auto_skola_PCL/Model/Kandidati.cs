using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Kandidati
    {
        public int KandidatId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumRegistracije { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Napomena { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Spol { get; set; }
        public int SpolId { get; set; }

        public System.DateTime DatumRodjenja { get; set; }

        public Nullable<bool> Status { get; set; }
    }
}
