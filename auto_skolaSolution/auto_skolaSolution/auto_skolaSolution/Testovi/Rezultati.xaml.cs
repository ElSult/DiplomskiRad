using auto_skola_PCL.Model;
using auto_skola_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace auto_skolaSolution.Testovi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rezultati : ContentPage
    {
        private WebAPIHelper rezultatService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Rezultat");
        private WebAPIHelper pitanjaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Pitanje");
        private WebAPIHelper odgovoriService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Odgovor");
        private WebAPIHelper oznaceniOdgovoriService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/OznaceniOdgovori");
        private WebAPIHelper polazeService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Polaze");
        private WebAPIHelper testService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Test");
        private WebAPIHelper korisniciService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Korisnici");

        public Rezultati()
        {
            InitializeComponent();
        }

        private Rezultat GetRezultat(Polaze polaze)
        {

            HttpResponseMessage response_test = testService.GetResponsee(polaze.TestId);
            var jsonResult_test = response_test.Content.ReadAsStringAsync();
            Test test = JsonConvert.DeserializeObject<Test>(jsonResult_test.Result);

            HttpResponseMessage response1 = pitanjaService.GetActionResponse("GetPitanjaByTestID", polaze.TestId);

            int BrojPitanja = 0,
                UkupnoBodova = 0;
            double OsvojeniBodovi = 0;

            Rezultat obj = new Rezultat();
            obj.Rezultat1 = 0;
            obj.BrojacTacnihOdgovora = 0;

            if (response1.IsSuccessStatusCode)
            {
                var jsonResult1 = response1.Content.ReadAsStringAsync();
                List<Pitanje> listaPitanja = JsonConvert.DeserializeObject<List<Pitanje>>(jsonResult1.Result);

                BrojPitanja = listaPitanja.Count;

                if (BrojPitanja > 0)
                {
                    foreach (Pitanje pitanje in listaPitanja)
                    {
                        if (pitanje.TipPitanjaId == 1)
                            UkupnoBodova += 1;
                        else
                            UkupnoBodova += 3;

                        HttpResponseMessage response2 = odgovoriService.GetActionResponse("GetOdgovoriByPitanjeId", pitanje.PitanjeId);
                        var jsonResult2 = response2.Content.ReadAsStringAsync();
                        List<Odgovor> listaOdgovora = JsonConvert.DeserializeObject<List<Odgovor>>(jsonResult2.Result);

                        HttpResponseMessage response_oznaceni = oznaceniOdgovoriService.GetActionResponse("GetOznaceniOdgovoriByPitanjeId", polaze.PolazeId + "/" + pitanje.PitanjeId);
                        var jsonResult_oznaceni = response_oznaceni.Content.ReadAsStringAsync();
                        List<OznaceniOdgovori> listaOznacenihOdgovora = JsonConvert.DeserializeObject<List<OznaceniOdgovori>>(jsonResult_oznaceni.Result);

                        bool netacno = true;
                        double BodovaZaDodati = 0;


                        if (pitanje.TipPitanjaId == 1) // SINGLE
                        {
                            BodovaZaDodati = 1;

                            foreach (OznaceniOdgovori oznaceni in listaOznacenihOdgovora)
                            {
                                bool prekid = false;
                                foreach (Odgovor odgovor in listaOdgovora)
                                {
                                    if (odgovor.OdgovorId == oznaceni.OdgovorId)
                                    {
                                        if (odgovor.IsTacan.Value == true)
                                        {
                                            netacno = false;
                                        }
                                        else if (odgovor.IsTacan.Value == false)
                                        {
                                            netacno = true;
                                            prekid = true;
                                            break;
                                        }
                                        break;
                                    }
                                }
                                if (prekid)
                                    break;


                            }
                        }
                        else if (pitanje.TipPitanjaId == 2) // MULTIPLE CHOICE
                        {
                            int oznacenoTacnih = 0;
                            int ukupnoTacnih = 0;
                            bool odgovorioNetacno = false;
                            foreach (Odgovor odgovor in listaOdgovora)
                            {
                                if (odgovor.IsTacan.Value == true)
                                    ukupnoTacnih++;
                            }

                            foreach (OznaceniOdgovori oznaceni in listaOznacenihOdgovora)
                            {
                                foreach (Odgovor odgovor in listaOdgovora)
                                {
                                    if (odgovor.OdgovorId == oznaceni.OdgovorId)
                                    {
                                        if (odgovor.IsTacan.Value == true)
                                        {
                                            oznacenoTacnih++;
                                        }
                                        else if (odgovor.IsTacan.Value == false)
                                        {
                                            odgovorioNetacno = true;
                                            break;
                                        }
                                        break;
                                    }
                                }
                                if (odgovorioNetacno)
                                    break;


                            }

                            if (!odgovorioNetacno)
                            {
                                if(test.ParcijalnoBodovanje)
                                {
                                    netacno = false;
                                    BodovaZaDodati = (double)oznacenoTacnih / ukupnoTacnih * 3;
                                }
                                else
                                {
                                    if(oznacenoTacnih == ukupnoTacnih)
                                    {
                                        netacno = false;
                                        BodovaZaDodati = 3;
                                    }
                                }
                            }

                        }


                        if (netacno == false)
                        {
                            OsvojeniBodovi += BodovaZaDodati;
                            obj.BrojacTacnihOdgovora++;
                        }
                    }

                }
            }
            else
                DisplayAlert("Greška", "Učitavanje pitanja neuspješno.", "OK");

            obj.Rezultat1 = OsvojeniBodovi / UkupnoBodova * 100;

            return obj;
        }

        public Rezultati(Polaze polaze)
        {
            InitializeComponent();

            Rezultat obj = GetRezultat(polaze);

            HttpResponseMessage responsePost = rezultatService.PostActionResponse("CustomPostRezultat", obj);

            if (responsePost.IsSuccessStatusCode)
            {
                Procenat.Text = obj.Rezultat1.ToString("0.00") + "%";

                var jsonResult = responsePost.Content.ReadAsStringAsync();
                Rezultat rezultat = JsonConvert.DeserializeObject<Rezultat>(jsonResult.Result);

                polaze.RezultatId = rezultat.RezultatId;
                polaze.VrijemeZavrsetka = DateTime.Now;

                HttpResponseMessage responsePut = polazeService.PutResponse(polaze.PolazeId, polaze);
                if(responsePut.IsSuccessStatusCode)
                {
                    SistemPreporuke();
                }

            }
            else
                DisplayAlert("Greška", "Izracunavanje rezultata neuspješno.", "OK");
        }

        private void SistemPreporuke()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("RecommendInstruktor", Global.prijavljeniKandidat.KandidatId.ToString());
            if (response.IsSuccessStatusCode)
            {

                preporuceniInstruktori.Text = "Preporuceni instruktor/i";
                var jsonResult1 = response.Content.ReadAsStringAsync();
                recommenderList.ItemsSource = JsonConvert.DeserializeObject<List<Korisnik>>(jsonResult1.Result);
                //Korisnik preporuceniInstruktor = JsonConvert.DeserializeObject<Korisnik>(jsonResult1.Result);

            }
        }

        private void Nazad_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Navigation.MyPage();
        }


    }
}