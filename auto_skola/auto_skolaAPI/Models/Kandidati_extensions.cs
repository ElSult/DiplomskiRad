using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace auto_skolaAPI.Models
{
    public partial class Kandidati
    {
        public int getAge()
        {
            return (int)Math.Round((DateTime.Now.Date - DatumRodjenja.Date).TotalDays / (float)365);
        }

        public int BrojIzlazakaNaVoznju { get; set; } // stvarni broj izlazaka
        public int PredvidjeniBrojIzlazakaNaVoznju { get; set; }
    }
}