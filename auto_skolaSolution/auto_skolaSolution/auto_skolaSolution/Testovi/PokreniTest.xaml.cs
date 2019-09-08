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
	public partial class PokreniTest : ContentPage
	{
        private WebAPIHelper polazeService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Polaze");
        private WebAPIHelper pitanjaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Pitanje");
        private WebAPIHelper testService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Test");

        private int brojPitanja;

        private int IdT = 0;
		public PokreniTest ()
		{
			InitializeComponent ();
		}
        public PokreniTest(Test test)
        {
            InitializeComponent();
            IdT = test.TestId;
            HttpResponseMessage response = pitanjaService.GetActionResponse("GetPitanjaByTestID", IdT);
            var jsonResult = response.Content.ReadAsStringAsync();
          List<Pitanje> listaPitanja = JsonConvert.DeserializeObject<List<Pitanje>>(jsonResult.Result);
             brojPitanja = listaPitanja.Count;
            pokreni.Text = "Test se sastoji od "+brojPitanja +" pitanja, nemojte varati. Parcijalno bodovanje nije uključeno. Sretno";

            HttpResponseMessage response2 = testService.GetResponse( IdT.ToString());
            var jsonResult2 = response2.Content.ReadAsStringAsync();
            Test pronadjenitest = JsonConvert.DeserializeObject<Test>(jsonResult2.Result);
            brojPitanja = listaPitanja.Count;

            if (pronadjenitest.ParcijalnoBodovanje)
            pokreni.Text = "Test se sastoji od " + brojPitanja + " pitanja, nemojte varati. Parcijalno bodovanje je uključeno. Sretno";
            else
                pokreni.Text = "Test se sastoji od " + brojPitanja + " pitanja, nemojte varati. Parcijalno bodovanje nije uključeno. Sretno";


        }
        private void Pokreni_Clicked(object sender, EventArgs e)
        {
            Polaze obj = new Polaze();
            if (brojPitanja > 0)
            {
                obj.KandidatId = Global.prijavljeniKandidat.KandidatId;
                obj.TestId = IdT;
                obj.VrijemePocetka = DateTime.Now;

                HttpResponseMessage responsePost = polazeService.PostActionResponse("CustomPostPolaze", obj);


                if (responsePost.IsSuccessStatusCode)
                {
                    var jsonResult = responsePost.Content.ReadAsStringAsync();
                    Polaze polaze = JsonConvert.DeserializeObject<Polaze>(jsonResult.Result);

                     Application.Current.MainPage = new Testovi.PrikaziPitanje(polaze);
                    //this.Navigation.PushAsync(new Testovi.PrikaziPitanje(polaze));

                }
                else
                    DisplayAlert("Greška", "Kreiranje testa neuspješno.", "OK");
            }
    
        }

    
    }
}