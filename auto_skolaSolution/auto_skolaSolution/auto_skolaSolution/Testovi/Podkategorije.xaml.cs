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
    public partial class Podkategorije : ContentPage
    {
        private WebAPIHelper podkategorijaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Podkategorija");
      
        public Podkategorije()
        {
            InitializeComponent();

        }

        public Podkategorije(int KategorijaId)
        {
            InitializeComponent();

            LoadPageData(KategorijaId);
        }

        private void LoadPageData(int KategorijaId)
        {

            HttpResponseMessage response = podkategorijaService.GetActionResponse("GetPodkategorijeByKategorijaId", KategorijaId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<Podkategorija> lista = JsonConvert.DeserializeObject<List<Podkategorija>>(jsonResult.Result);

                podkategorijeList.ItemsSource = lista;

            };


            
        }

        private void PodkategorijeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            if (e.Item != null)
            {
                Podkategorija pk = e.Item as Podkategorija;

                this.Navigation.PushAsync(new Testovi.TestoviPage(pk.PodkategorijaId));

            }
        }
    }
}