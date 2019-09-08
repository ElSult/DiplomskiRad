using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Spol
    {
        public int SpolId { get; set; }
        public string Naziv { get; set; }

        public Spol(int SpolId, string Naziv)
        {
            this.SpolId = SpolId;
            this.Naziv = Naziv;
        }
    }
}
