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
	public partial class TestoviPage : ContentPage
	{
        private WebAPIHelper testoviService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Test");
        private WebAPIHelper pitanjaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Pitanje");
        private int brojPitanja;
        public TestoviPage()
		{
			InitializeComponent ();
		}

        public TestoviPage(int PodkategorijaId)
        {
            InitializeComponent();

            LoadPageData(PodkategorijaId);
        }
        public TestoviPage(string naziv)
        {
            InitializeComponent();

            HttpResponseMessage response = testoviService.GetActionResponse("GetTestoviByIzbor", naziv);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<Test> lista = JsonConvert.DeserializeObject<List<Test>>(jsonResult.Result);

                testoviList.ItemsSource = lista;
            }
        }

            private void LoadPageData(int PodkategorijaId)
        {

            HttpResponseMessage response = testoviService.GetActionResponse("GetTestoviByPodkategorijaID", PodkategorijaId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<Test> lista = JsonConvert.DeserializeObject<List<Test>>(jsonResult.Result);

                testoviList.ItemsSource = lista;

            };


        }

        private void TestoviList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                Test pk = e.Item as Test;
                HttpResponseMessage response = pitanjaService.GetActionResponse("GetPitanjaByTestID", pk.TestId);
                var jsonResult = response.Content.ReadAsStringAsync();
                List<Pitanje> listaPitanja = JsonConvert.DeserializeObject<List<Pitanje>>(jsonResult.Result);
                brojPitanja = listaPitanja.Count;
                if (brojPitanja > 0)
                {
                    this.Navigation.PushAsync(new Testovi.PokreniTest(pk));
                }
                else
                {
                    DisplayAlert("Upozorenje", "Test ne sadrži niti jedno pitanje, odaberite drugi.", "OK");
                }
            }
        }
    }
}