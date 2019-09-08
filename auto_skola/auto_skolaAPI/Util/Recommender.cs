using auto_skolaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace auto_skolaAPI.Util
{
    public class Recommender
    {
        auto_skolaEntities db = new auto_skolaEntities();
        Dictionary<int, List<Ocjene>> kOcjene = new Dictionary<int, List<Ocjene>>();

        public List<asp_Korisnici_GetById_Result> getInstruktori(int kandidatId)
        {
            int korisnikId = UcitajInstruktore(kandidatId);
            List<asp_Korisnici_GetById_Result> preporuceniInstruktori = new List<asp_Korisnici_GetById_Result>();

            if (korisnikId != 0)
            {
                List<Ocjene> ocjenePosmatranogKorisnika = db.Ocjene.Where(x => x.KorisnikId == korisnikId).OrderBy(x => x.KandidatId).ToList();
                List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
                List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
                // asp_Korisnici_GetById_Result preporuceniInstruktor = new asp_Korisnici_GetById_Result();

                foreach (var item in kOcjene)
                {
                    foreach (Ocjene o in ocjenePosmatranogKorisnika)
                    {
                        if (item.Value.Where(x => x.KandidatId == o.KandidatId).Any())
                        {

                            zajednickeOcjene1.Add(o);
                            zajednickeOcjene2.Add(item.Value.Where(x => x.KandidatId == o.KandidatId).First());
                        }
                    }
                    double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                    if (slicnost > 0.7)
                    {

                        preporuceniInstruktori.Add(db.asp_Korisnici_GetById(item.Key).FirstOrDefault());
                    }


                    zajednickeOcjene1.Clear();
                    zajednickeOcjene2.Clear();
                }

            }
            else
            {
                List<asp_Korisnici_GetRecommendedInstruktori_Result> Instruktori = db.asp_Korisnici_GetRecommendedInstruktori().ToList();
                foreach (var item in Instruktori)
                {
                    preporuceniInstruktori.Add(db.asp_Korisnici_GetById(item.KorisnikId).FirstOrDefault());
                }

            }
            return preporuceniInstruktori;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count() != zajednickeOcjene2.Count())
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;
            for (int i = 0; i < zajednickeOcjene1.Count(); i++)
            {
                brojnik += Convert.ToDouble(zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena);
                nazivnik1 += Convert.ToDouble(zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena);
                nazivnik2 += Convert.ToDouble(zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena);
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        private int UcitajInstruktore(int kandidatId)
        {
            //LOGOVANI KANDIDAT
            asp_Kandidati_GetById_Result k = db.asp_Kandidati_GetById(kandidatId).FirstOrDefault();

            //INSTRUKTOR KOJI JE ZADNJI DOBIO OCJENU OD LOGOVANOG KANDIDATA
            Ocjene ocjenaZadnjeOcjenjenogInstruktora = db.Ocjene.Where(x => x.KandidatId == kandidatId).ToList().LastOrDefault();

            //AKO KANDIDAT NIKAD NIJE OCIJENIO INSTRUKTORA UZIMA SE NAJBOLJE RANGIRANI INSTRUKTOR
            if (ocjenaZadnjeOcjenjenogInstruktora == null)
            {
                asp_Korisnici_GetRecommendedInstruktori_Result instruktor = db.asp_Korisnici_GetRecommendedInstruktori().ToList().FirstOrDefault();
                ocjenaZadnjeOcjenjenogInstruktora = db.Ocjene.Where(x => x.KorisnikId == instruktor.KorisnikId).ToList().LastOrDefault();
                if (ocjenaZadnjeOcjenjenogInstruktora == null)
                {
                    int kId = 0;
                    return kId;
                }
            }

            //INSTRUKTORI KOJI SU DOBILI OCJENE OD KANDIDATA KOJI SU SLIČNI LOGOVANOM KANDIDATU PO SPOLU ILI GODINAMA, TE NISU
            // INSTRUKTOR KOJI JE VEĆ PRETHODNO ODREĐEN
            List<asp_Korisnici_GetSlicnePoKandidatu_Result> instruktori = new List<asp_Korisnici_GetSlicnePoKandidatu_Result>();
            instruktori = db.asp_Korisnici_GetSlicnePoKandidatu(k.SpolId, ocjenaZadnjeOcjenjenogInstruktora.KorisnikId, k.DatumRodjenja).ToList();
            List<Ocjene> ocjene;
            foreach (asp_Korisnici_GetSlicnePoKandidatu_Result item in instruktori)
            {
                ocjene = db.Ocjene.Where(x => x.KorisnikId == item.KorisnikId).ToList();
                if (ocjene.Count > 0)
                {
                    kOcjene.Add(item.KorisnikId, ocjene);
                }
            }
            return ocjenaZadnjeOcjenjenogInstruktora.KorisnikId;
        }


    
    }
}