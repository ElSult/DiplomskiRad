using auto_skolaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skolaAPI.KNN
{
    class MaximumValue
    {
        int maxAge = 0;
        int maxEducationLevel = 0;

        List<Kandidati> lKandidati = new List<Kandidati>();

        public MaximumValue(  List <Kandidati> lc )
        {
            this.lKandidati = lc;
        }

        public void findAllMax()
        {
            for (int i = 0; i < this.lKandidati.Count; i++)
            {
                //find maxAge
                if (this.lKandidati[i].getAge() > maxAge)
                {
                    maxAge = this.lKandidati[i].getAge();
                }

                //find maxEducationLevel
                if(this.lKandidati[i].StrucnaSprema.StepenObrazovanja > maxEducationLevel)
                {
                    maxEducationLevel = this.lKandidati[i].StrucnaSprema.StepenObrazovanja.Value;
                }

            }//end loop
        }


        public int getMaxAge()
        {
            return this.maxAge;
        }

        public int getMaxEducationLevel()
        {
            return this.maxEducationLevel;
        }



    }
}
