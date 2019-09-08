using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class Test
    {
        public int TestId { get; set; }
        public string Naziv { get; set; }
        public int PodkategorijaId { get; set; }
        public bool ParcijalnoBodovanje { get; set; }
    }
}
