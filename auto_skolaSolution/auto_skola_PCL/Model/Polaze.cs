using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Polaze
    {
        public int PolazeId { get; set; }
        public System.DateTime VrijemePocetka { get; set; }
        public Nullable<System.DateTime> VrijemeZavrsetka { get; set; }
        public Nullable<int> RezultatId { get; set; }
        public int TestId { get; set; }
        public int KandidatId { get; set; }

    }
}
