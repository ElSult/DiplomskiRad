using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Pitanje
    {
        public int PitanjeId { get; set; }
        public string Pitanje1 { get; set; }
        //public byte[] Slika { get; set; }
        public int TipPitanjaId { get; set; }
        public int TestId { get; set; }
        public byte[] SlikaThumb { get; set; }

    }
}
