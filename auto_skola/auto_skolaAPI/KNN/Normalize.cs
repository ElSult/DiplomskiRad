using auto_skolaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skolaAPI.KNN
{
    class Normalize
    {
        public float age;
        public float educationLevel;

        public Normalize(  Kandidati cus, int maxAge, int maxEducationLevel)
        {
            age = cus.getAge() / (float)maxAge;
            educationLevel = cus.StrucnaSprema.StepenObrazovanja.Value / (float)maxEducationLevel;
        }
    }
}
