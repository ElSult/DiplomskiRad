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
	public partial class Kategorije : ContentPage
    {
        private WebAPIHelper kategorijaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Kategorija");

        public Kategorije ()
		{
			InitializeComponent ();
            LoadPageData();
		}

        private void LoadPageData()
        {

            HttpResponseMessage response = kategorijaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<Kategorija> lista = JsonConvert.DeserializeObject<List<Kategorija>>(jsonResult.Result);

                kategorijeList.ItemsSource = lista;

            };

        }

        private void KategorijeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                Kategorija k = e.Item as Kategorija;

                this.Navigation.PushAsync(new Podkategorije(k.KategorijaId));

            }
        }
    }
}