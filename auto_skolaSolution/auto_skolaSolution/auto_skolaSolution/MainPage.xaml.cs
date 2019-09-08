using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using auto_skola_PCL.Model;
using System.IO;
using System.Reflection;
using auto_skola_PCL.Util;
using System.Net.Http;
using Newtonsoft.Json;

namespace auto_skolaSolution
{
    public partial class MainPage : ContentPage
    {
        private WebAPIHelper izborService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Izbor");

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            HttpResponseMessage response = izborService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<Izbor> lista = JsonConvert.DeserializeObject<List<Izbor>>(jsonResult.Result);

                izborList.ItemsSource = lista;

            };


            base.OnAppearing();
        }

        private void IzborList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                Izbor izbor = e.Item as Izbor;
                switch(izbor.IzborId)
                {
                    case 1:
                        this.Navigation.PushAsync(new Testovi.Kategorije());
                        break;
                    case 2:
                        this.Navigation.PushAsync(new Testovi.TestoviPage(izbor.Naziv));
                        break;
                    case 3:
                        this.Navigation.PushAsync(new Testovi.TestoviPage(izbor.Naziv));
                        break;
                    case 4:
                        this.Navigation.PushAsync(new Testovi.TestoviPage(izbor.Naziv));
                        break;
             
                }
            }
        }


    }
}
