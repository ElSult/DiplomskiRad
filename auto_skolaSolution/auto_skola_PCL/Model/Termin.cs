using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Termin
    {
        public string TerminVoznje { get; set; }
        public string Instruktor { get; set; }
        public string InstruktorV { get => "Instruktor:" + " " + Instruktor; }

        public string Napomena { get; set; }
        public bool IsOdrzan { get; set; }
        public string Odrzano { get => IsOdrzan ? "Termin održan" : "Termin nije održan"; }
    }
}
