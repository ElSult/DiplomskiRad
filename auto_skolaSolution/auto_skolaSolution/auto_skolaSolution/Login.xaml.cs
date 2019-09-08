using auto_skola_PCL.Model;
using auto_skola_PCL.Util;
using auto_skolaSolution.Navigation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace auto_skolaSolution
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private WebAPIHelper kandidatiService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Kandidati");
        Entry korisnickoImeInput;
        Entry lozinkaInput;
        public Login()
        {
            StackLayout stek = new StackLayout();
            stek.Margin = 10;
            stek.VerticalOptions = LayoutOptions.CenterAndExpand;
            Label ZaglavljeLabel = new Label()
            {
                Text = "prijava @ auto_skola",
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center
            };
            korisnickoImeInput = new Entry() { Placeholder = "Korisničko ime" };
            lozinkaInput = new Entry() { Placeholder = "******", IsPassword = true };

            Button prijavaButton = new Button() { Text = "Prijava" };
            prijavaButton.Clicked += prijavaButton_Clicked;


            Button registracijaButton = new Button() { Text = "Registracija" };
            registracijaButton.Clicked += (sender, args) =>
            {
                Application.Current.MainPage = new Registracija();
            };

            stek.Children.Add(ZaglavljeLabel);
            stek.Children.Add(korisnickoImeInput);
            stek.Children.Add(lozinkaInput);
            StackLayout stekButtons = new StackLayout();
            stekButtons.Children.Add(registracijaButton);
            stekButtons.Children.Add(prijavaButton);
            stekButtons.Orientation = StackOrientation.Horizontal;
            stekButtons.HorizontalOptions = LayoutOptions.End;

            stek.Children.Add(stekButtons);

            Content = stek;
        }

        private void prijavaButton_Clicked(object sender, EventArgs e)
        {
            Global.prijavljeniKandidat = null;
            try
            {

                HttpResponseMessage response = kandidatiService.GetActionResponse("GetByUsername", korisnickoImeInput.Text);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync();
                    Global.prijavljeniKandidat = JsonConvert.DeserializeObject<Kandidati>(jsonResult.Result);
                    if (Global.prijavljeniKandidat.LozinkaHash == UIHelper.GenerateHash(lozinkaInput.Text, Global.prijavljeniKandidat.LozinkaSalt))
                    {
                        //this.Navigation.PushAsync(new Navigation.MyPage());
                        Application.Current.MainPage = new Navigation.MyPage();
                    }
                    else
                        DisplayAlert("Greška", "Unijeli ste pogresnu lozinku", "OK");
                }
                else
                    DisplayAlert("Greška", "Niste unijeli ispravne podatke za prijavu", "OK");
            }
            catch (Exception ex)
            {

                DisplayAlert("Greška", ex.Message, "OK");

            }
        }



    }
}