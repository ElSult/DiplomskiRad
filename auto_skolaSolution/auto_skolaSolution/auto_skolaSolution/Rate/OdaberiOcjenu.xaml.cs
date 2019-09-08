using auto_skola_PCL.Model;
using auto_skola_PCL.Util;
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
    public partial class OdaberiOcjenu : ContentPage
    {
        private WebAPIHelper ocjeneService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Ocjene");
        private Korisnik korisnik;

        public OdaberiOcjenu()
        {
            InitializeComponent();
        }
        public OdaberiOcjenu(Korisnik k)
        {
            InitializeComponent();
            korisnik = k;
            LoadPageData();

        }

        private void LoadPageData()
        {
            List<Ocjene> ocjene = new List<Ocjene>();
            for (int i = 1; i <= 5; i++)
            {
                ocjene.Add(new Ocjene
                {
                    KandidatId = Global.prijavljeniKandidat.KandidatId,
                    KorisnikId = korisnik.KorisnikId,
                    Ocjena = i
                });
            }

            ocjeneList.ItemsSource = ocjene;


        }

        private void OcjeneList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                Ocjene item = e.Item as Ocjene;

                HttpResponseMessage response = ocjeneService.GetActionResponse("DaLiPostojiOcjena", Global.prijavljeniKandidat.KandidatId + "/" + item.KorisnikId);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Greška", "Već ste ocijenili ovog instruktora", "OK");
                }
                else
                {
                    HttpResponseMessage responsePost = ocjeneService.PostActionResponse("CustomPostOcjene", item);

                    if (responsePost.IsSuccessStatusCode)
                    {
                        DisplayAlert("Uspjeh", "Uspješno ste ocijenili instruktora!", "OK");
                        this.Navigation.PushAsync(new Rate.RateInstruktor());
                    }
                    else
                    {
                        DisplayAlert("Greška", "Greška prilikom ocjenjivanja instruktora!", "OK");
                    }
                }

            }
        }
    }
}