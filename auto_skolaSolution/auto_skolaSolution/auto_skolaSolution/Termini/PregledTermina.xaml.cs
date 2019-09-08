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

namespace auto_skolaSolution.Termini
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PregledTermina : ContentPage
	{
        private WebAPIHelper terminService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Termin");
        public PregledTermina()
        {
            InitializeComponent();

            HttpResponseMessage response = terminService.GetActionResponse("GetByKandidatId", Global.prijavljeniKandidat.KandidatId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult1 = response.Content.ReadAsStringAsync();
                List<Termin> listaTermina = JsonConvert.DeserializeObject<List<Termin>>(jsonResult1.Result);

                terminiList.ItemsSource = listaTermina;
            }
        }
	}
}