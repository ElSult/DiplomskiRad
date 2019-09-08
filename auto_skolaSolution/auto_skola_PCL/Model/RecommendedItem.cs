using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
    public class RecommendedItem
    {
        public int TestId { get; set; }
        public string Naziv { get; set; }
        public string Podkategorija { get; set; }
        public float Prosjek { get; set; }
        public string ProsjekS {
            get => Prosjek.ToString("0.00") + " %";
        }
    }
}
