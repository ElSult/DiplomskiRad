using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using auto_skola_PCL.Util;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using auto_skola_PCL.Model;
using System.Collections.Generic;

namespace auto_skolaSolution
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registracija : ContentPage
	{
        private WebAPIHelper kandidatiService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Kandidati");
        private WebAPIHelper spolService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Spol");

        public Registracija ()
		{
			InitializeComponent ();
            bindSpol();
            
		}

        private void bindSpol()
        {
            HttpResponseMessage response = spolService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Spol> spolovi = JsonConvert.DeserializeObject<List<Spol>>(jsonObject.Result);


                spolList.ItemsSource = spolovi;
                spolList.ItemDisplayBinding = new Binding("Naziv");

            }
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                return false;
            }
            if ((spolList.SelectedItem as Spol) == null)
            {
                return false;
            }
                if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                return false;
            }
            return true;
        }

        private void RegistracijaButton_Clicked(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                DisplayAlert("Upozorenje","Morate popuniti sva polja za registraciju","OK");
            }
            else {
                HttpResponseMessage response = kandidatiService.GetActionResponse("GetByUsername", korisnickoImeInput.Text);
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    DisplayAlert("Upozorenje", "Korisničko ime je zauzeto, odaberite drugo", "OK");
                    return;
                }
                else
                {
                    Kandidati obj = new Kandidati();
                    obj.Ime = imeInput.Text;
                    obj.Prezime = prezimeInput.Text;
                    obj.Telefon = telefonInput.Text;
                    obj.DatumRodjenja = datumRodjenja.Date;
                    obj.Email = emailInput.Text;
                    obj.SpolId = (spolList.SelectedItem as Spol).SpolId;
                    obj.KorisnickoIme = korisnickoImeInput.Text;
                    obj.DatumRegistracije = DateTime.Now;
                    obj.LozinkaSalt = UIHelper.GenerateSalt();
                    obj.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, obj.LozinkaSalt);
                    obj.Status = false;

                    HttpResponseMessage responsePost = kandidatiService.PostActionResponse("CustomPostKandidati", obj);

                   
                    if (responsePost.IsSuccessStatusCode)
                    {
                        DisplayAlert("Uspjeh", "Uspješno ste se registrovali", "OK");
                        Application.Current.MainPage = new Login();


                    }
                    else
                    {
                        DisplayAlert("Ne", "NE", "nee");
                    }
                }
            }
        }

        private void NazadButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }

        private void SpolList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}