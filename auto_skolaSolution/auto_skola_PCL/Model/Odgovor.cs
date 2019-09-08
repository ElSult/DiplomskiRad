using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Odgovor
    {
        public int OdgovorId { get; set; }
        public string Odgovor1 { get; set; }
        public Nullable<bool> IsTacan { get; set; }
        public bool IsNetacan { get; set; }
        public bool IsNeoznacenTacan { get; set; }
        public int PitanjeId { get; set; }
        public bool Oznacen { get; set; }
    }
}
