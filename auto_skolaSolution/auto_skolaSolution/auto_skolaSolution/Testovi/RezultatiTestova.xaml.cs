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
	public partial class RezultatiTestova : ContentPage
	{
        private WebAPIHelper polazeService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Polaze");
   
        public RezultatiTestova()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            HttpResponseMessage response = polazeService.GetActionResponse("GetPolazeByKandidatId", Global.prijavljeniKandidat.KandidatId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<PolazeResult> lista = JsonConvert.DeserializeObject<List<PolazeResult>>(jsonResult.Result);
                rezultatiList.ItemsSource = lista;


            }
        }

        private void RezultatiList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                PolazeResult p = e.Item as PolazeResult; 

                this.Navigation.PushAsync(new Testovi.PrikazRezultata(p.PolazeId));

            }
        }
    }
}