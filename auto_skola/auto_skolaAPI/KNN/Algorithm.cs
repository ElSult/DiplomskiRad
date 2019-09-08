using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using auto_skolaAPI.Models;

namespace auto_skolaAPI.KNN
{
    class Algorithm
    {
        int kNN;
        int totalTrainset;
        List<Kandidati> trainset;
        List<Kandidati> KandidatSet;

        Distance [] distances;

        int maxAge;
        int maxEducationLevel;

        public Algorithm(  int k, List <Kandidati> train, List <Kandidati> Kandidati )
        {
            this.kNN = k;//k neighbor
           
            this.trainset = train;//trainset
            this.KandidatSet = Kandidati;//Kandidati
            this.totalTrainset = train.Count;//total of Kandidati

            distances = new Distance [this.totalTrainset];

            //get max value of each column need to normalize
            MaximumValue maximum = new MaximumValue(train);
            maximum.findAllMax();

            maxAge = maximum.getMaxAge();
            maxEducationLevel = maximum.getMaxEducationLevel();


        }

        public void setBrojIzlazaka( Kandidati kandidat )
        {
            //normalize kandidat
            Normalize norm_kandidat = new Normalize(kandidat, maxAge, maxEducationLevel);


            //calculate all distances
            for (int i = 0; i < this.totalTrainset; i++)
            {
                distances[i] = new Distance();
                distances[i].distance = 0;
                distances[i].index = i;

                //normalize element
                Normalize tmp = new Normalize(this.trainset[i], maxAge, maxEducationLevel);


                //distance between two age normalized
                distances[i].distance = distances[i].distance + getDistance( norm_kandidat.age , tmp.age);

                //distance between two gender
                distances[i].distance = distances[i].distance + getDistance(kandidat.SpolId, this.trainset[i].SpolId);

                //distance between two education levels normalized
                distances[i].distance = distances[i].distance + getDistance(norm_kandidat.educationLevel, tmp.educationLevel);

            }// end loop


            //sort
            for (int i = 0; i < totalTrainset - 1; i++)
            {
                for (int j = i + 1; j < totalTrainset; j++)
                {
                    if (distances[i].distance > distances[j].distance)
                    {
                        Distance tmp = distances[i];
                        distances[i] = distances[j];
                        distances[j] = tmp;
                    }//swap
                }//end j loop

            }//end i loop



            //select k nearest neighbor
            int sumaBrojaIzlazaka = 0;

            for (int i = 0; i < kNN; i++)
            {
                Kandidati tmp = trainset[ distances[i].index ];
                sumaBrojaIzlazaka += tmp.BrojIzlazakaNaVoznju;
            }

            //set response value for unknown Kandidati
            kandidat.PredvidjeniBrojIzlazakaNaVoznju = (int)Math.Round(sumaBrojaIzlazaka / (double)kNN);
            
        }
        
        public float getDistance(float a, float b)
        {
            return (a - b) * (a - b);
        }

        public void runkNN()
        {
            for (int i = 0; i < this.KandidatSet.Count; i++)
            {
                setBrojIzlazaka(this.KandidatSet[i]);
            }
        }

        public List<Kandidati> getKandidatList()
        {
            return this.KandidatSet;
        }


    }
}
