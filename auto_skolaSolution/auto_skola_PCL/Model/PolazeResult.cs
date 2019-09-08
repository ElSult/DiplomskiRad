using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skola_PCL.Model
{
   public class PolazeResult
    {
	//SELECT  p.PolazeId,p.VrijemePocetka,p.VrijemeZavrsetka,t.Naziv,r.Rezultat as Rezultat1,r.BrojacTacnihOdgovora as brojTacnihOdgovora
        public int PolazeId { get; set; }
        public System.DateTime VrijemePocetka { get; set; }
        public Nullable<System.DateTime> VrijemeZavrsetka { get; set; }
        public string Naziv { get; set; }
        public double Rezultat1 { get; set; }
        public string RezS
        {
            get => Rezultat1.ToString("0.00") + " %";
        }
        public int brojTacnihOdgovora { get; set; }


    }
}
