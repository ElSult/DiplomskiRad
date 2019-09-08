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

namespace auto_skolaSolution.Rate
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RateInstruktor : ContentPage
    {
        private WebAPIHelper ocjeneService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Ocjene");
        private WebAPIHelper korisniciService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Korisnici");

        public RateInstruktor()
        {
            InitializeComponent();
            LoadPageData();
        }

        private void LoadPageData()
        {

            HttpResponseMessage response = korisniciService.GetResponse("GetInstruktori");

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                instruktorList.ItemsSource = JsonConvert.DeserializeObject<List<Korisnik>>(jsonResult.Result);
            };
        }

        private void InstruktorList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            if (e.Item != null)
            {
                Korisnik item = e.Item as Korisnik;

                HttpResponseMessage response = ocjeneService.GetActionResponse("DaLiPostojiOcjena", Global.prijavljeniKandidat.KandidatId + "/" + item.KorisnikId);
                if(response.IsSuccessStatusCode)
                {
                    DisplayAlert("Greška", "Već ste ocijenili ovog instruktora", "OK");
                }
                else
                {
                    this.Navigation.PushAsync(new Rate.OdaberiOcjenu(item));

                }

            }
        }


    }
}