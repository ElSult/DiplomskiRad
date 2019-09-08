using auto_skola_PCL.Model;
using auto_skola_PCL.Util;
using auto_skolaSolution.Converters;
using Newtonsoft.Json;
using Plugin.InputKit.Shared.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace auto_skolaSolution.Testovi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrikaziPitanje : ContentPage
    {
        private WebAPIHelper pitanjaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Pitanje");
        private WebAPIHelper odgovoriService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Odgovor");
        private WebAPIHelper oznaceniOdgovoriService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/OznaceniOdgovori");

        private Polaze polaze { get; set; }
        private int trenutnoPitanje { get; set; } = 0;
        private List<Pitanje> listaPitanja;
        private List<Odgovor> listaOdgovora;



        public PrikaziPitanje()
        {
            InitializeComponent();

            UpdateButtons();
        }

        public PrikaziPitanje(Polaze obj)
        {
            polaze = obj;

            InitializeComponent();

            LoadPageData(polaze.TestId);
        }


        public void UpdateButtons()
        {
            NazadButton.Text = "Nazad";
            if (trenutnoPitanje == 0)
            {
                NazadButton.IsEnabled = false;
            }
            else
            {
                NazadButton.IsEnabled = true;
            }

            if (trenutnoPitanje == listaPitanja.Count - 1)
            {
                DaljeButton.Text = "Zavrsi";
            }
            else
            {
                DaljeButton.Text = "Dalje";
            }
        }

        private void LoadPageData(int TestId)
        {

            HttpResponseMessage response = pitanjaService.GetActionResponse("GetPitanjaByTestID", TestId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                listaPitanja = JsonConvert.DeserializeObject<List<Pitanje>>(jsonResult.Result);


                if (listaPitanja.Count > 0)
                {
                    ucitajPitanje(trenutnoPitanje);
                }

            };


        }

        private string GetTekstPitanja()
        {
            return (trenutnoPitanje + 1) + "/" + listaPitanja.Count + " : " + listaPitanja[trenutnoPitanje].Pitanje1;
        }

        private void PrikaziOdgovore(int PitanjeId)
        {

            HttpResponseMessage response = odgovoriService.GetActionResponse("GetOdgovoriByPitanjeId", PitanjeId);
            HttpResponseMessage response_oznaceni = oznaceniOdgovoriService.GetActionResponse("GetOznaceniOdgovoriByPitanjeId", polaze.PolazeId + "/" + PitanjeId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                listaOdgovora = JsonConvert.DeserializeObject<List<Odgovor>>(jsonResult.Result);

                var jsonResult_oznaceni = response_oznaceni.Content.ReadAsStringAsync();
                List<OznaceniOdgovori> listaOznacenihOdgovora = JsonConvert.DeserializeObject<List<OznaceniOdgovori>>(jsonResult_oznaceni.Result);

             

                    foreach (var oznaceniOdg in listaOznacenihOdgovora)
                    {
                        for (int i = 0; i < listaOdgovora.Count; i++)
                        {
                            if (oznaceniOdg.OdgovorId == listaOdgovora[i].OdgovorId)
                            {
                                listaOdgovora[i].Oznacen = true;
                                break;
                            }
                        }
                    }

                   
                    odgovoriList.ItemsSource = listaOdgovora;                
               

            };

        }

        private void OdgovoriList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null)
                return;

            // do stuff 

            ((ListView)sender).SelectedItem = null;
        }

        private void DaljeButton_Clicked(object sender, EventArgs e)
        {
            if (trenutnoPitanje + 1 < listaPitanja.Count)
            {
                SpremiOdgovore();

                trenutnoPitanje++;
                ucitajPitanje(trenutnoPitanje);


            }
            else if (trenutnoPitanje + 1 == listaPitanja.Count)
            {
                SpremiOdgovore();

                Application.Current.MainPage = new Testovi.Rezultati(polaze);

            }
        }

        private void ucitajPitanje(int trenutnoPitanje)
        {
            if (trenutnoPitanje >= 0 && trenutnoPitanje < listaPitanja.Count)
            {
                PitanjeTekst.Text = GetTekstPitanja();

                byte[] bytes = listaPitanja[trenutnoPitanje].SlikaThumb as byte[];
                if (bytes != null)
                {
                    ImageSource source = ImageSource.FromStream(() => new MemoryStream(bytes));

                    Slika.Source = source;
                    Slika.IsVisible = true;

                }
                else { 
                    Slika.Source = null;
                    Slika.IsVisible = false;
                }
                PrikaziOdgovore(listaPitanja[trenutnoPitanje].PitanjeId);
                UpdateButtons();
            }
        }

        private void NazadButton_Clicked(object sender, EventArgs e)
        {
            if (trenutnoPitanje > 0)
            {
                SpremiOdgovore();

                trenutnoPitanje--;
                ucitajPitanje(trenutnoPitanje);
            }
        }

        private void SpremiOdgovore()
        {
            oznaceniOdgovoriService.GetActionResponse("IzbrisiOznaceneOdgovoreByPitanjeId", polaze.PolazeId + "/" + listaPitanja[trenutnoPitanje].PitanjeId);

      

                foreach (Odgovor item in odgovoriList.ItemsSource)
                {
                    if (item.Oznacen)
                    {
                        OznaceniOdgovori obj = new OznaceniOdgovori
                        {
                            PolazeId = polaze.PolazeId,
                            PitanjeId = item.PitanjeId,
                            OdgovorId = item.OdgovorId
                        };

                        HttpResponseMessage responsePost = oznaceniOdgovoriService.PostActionResponse("CustomPostOznaceniOdgovori", obj);
                    }
                }
        }
    }
}