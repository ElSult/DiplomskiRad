using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Podkategorija
    {
        public int PodkategorijaId { get; set; }
        public string Naziv { get; set; }
        public string NazivMod
        {
            get => "Podkategorija " + Naziv;
        }
        public int KategorijaId { get; set; }
    }
}
