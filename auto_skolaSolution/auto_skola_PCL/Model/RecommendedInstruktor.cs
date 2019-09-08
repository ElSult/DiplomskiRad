using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class RecommendedInstruktor
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get => Ime + " " + Prezime; }
        public float Prosjek { get; set; }
        public byte[] Slika { get; set; }
        public string ProsjekS
        {
            get => "Prosječna ocjena " + Prosjek.ToString("0.00");
        }
        public string Email { get; set; }
    }
}
