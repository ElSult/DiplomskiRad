using auto_skola_PCL.Model;
using auto_skola_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace auto_skolaSolution.Testovi
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrikazRezultata : ContentPage
    {
        private WebAPIHelper pitanjaService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Pitanje");
        private WebAPIHelper polazeService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Polaze");
        private WebAPIHelper oznaceniOdgovori = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/OznaceniOdgovori");
        private WebAPIHelper odgovoriService = new WebAPIHelper(Application.Current.Resources["ApiAdress"].ToString(), "api/Odgovor");

        private List<Pitanje> listaPitanja;
        private List<Odgovor> listaOdgovora;
        private List<OznaceniOdgovori> listaOznaceniOdgovori;
        private List<Odgovor> ListaOznacenihOdgovoraPoPitanjima;

        private List<Odgovor> listaTacnihOdg;
        private List<Pitanje> listaNetacnihPitanja;
        private int trenutnoPitanje { get; set; } = 0;
        private int polazeId;

        public PrikazRezultata()
        {
            InitializeComponent();
        }

        public PrikazRezultata(int polazeId)
        {
            InitializeComponent();
            this.polazeId = polazeId;
            listaNetacnihPitanja = new List<Pitanje>();
            listaTacnihOdg = new List<Odgovor>();
            ListaOznacenihOdgovoraPoPitanjima = new List<Odgovor>();
            LoadPageData();
        }

        private void UcitajOdgovore(int trenutnoPitanje)
        {
            listaTacnihOdg.Clear();
            int brojOdgovoraPoPitanju = 0;

            HttpResponseMessage response = odgovoriService.GetActionResponse("GetOdgovoriByPitanjeId", listaNetacnihPitanja[trenutnoPitanje].PitanjeId);
            var jsonResult = response.Content.ReadAsStringAsync();
            listaOdgovora = JsonConvert.DeserializeObject<List<Odgovor>>(jsonResult.Result);

            HttpResponseMessage responseOznaceniOdgovori = oznaceniOdgovori.GetActionResponse("GetOznaceniOdgovoriByPitanjeId", polazeId + "/" + listaNetacnihPitanja[trenutnoPitanje].PitanjeId);
            var jsonResult1 = responseOznaceniOdgovori.Content.ReadAsStringAsync();
            var listaOznacenihOdgovora = JsonConvert.DeserializeObject<List<OznaceniOdgovori>>(jsonResult1.Result);


            foreach (Odgovor odgovor in listaOdgovora)
            {

                bool OdgovorOznacen = false;
                foreach (OznaceniOdgovori oznaceniOdg in listaOznacenihOdgovora)
                {
                    if (oznaceniOdg.OdgovorId == odgovor.OdgovorId)
                    {
                        OdgovorOznacen = true;
                        if (odgovor.IsTacan == false)
                            odgovor.IsNetacan = true;
                    }
                }

                if (!OdgovorOznacen && odgovor.IsTacan == true)
                {
                    odgovor.IsNeoznacenTacan = true;
                    odgovor.IsTacan = false;
                }
            }

            odgovoriList.ItemsSource = listaOdgovora;


        }
        private void ucitajPitanje(int trenutnoPitanje)
        {
            if (trenutnoPitanje >= 0 && trenutnoPitanje < listaNetacnihPitanja.Count)
            {
                PitanjeTekst.Text = GetTekstPitanja();
                byte[] bytes = listaNetacnihPitanja[trenutnoPitanje].SlikaThumb as byte[];
                if (bytes != null)
                {
                    ImageSource source = ImageSource.FromStream(() => new MemoryStream(bytes));

                    Slika.Source = source;
                    Slika.IsVisible = true;
                }
                else
                {
                    Slika.Source = null;
                    Slika.IsVisible = false;
                }
                UcitajOdgovore(trenutnoPitanje);
                UpdateButtons();
            }
        }

        private void DaljeButton_Clicked(object sender, EventArgs e)
        {
            if (trenutnoPitanje + 1 < listaNetacnihPitanja.Count)
            {
                trenutnoPitanje++;
                ucitajPitanje(trenutnoPitanje);
            }
            else
            {
                this.Navigation.PushAsync(new Testovi.RezultatiTestova());
            }
        }
        private void NazadButton_Clicked(object sender, EventArgs e)
        {
            if (trenutnoPitanje > 0)
            {
                trenutnoPitanje--;
                ucitajPitanje(trenutnoPitanje);
            }
        }
        public void UpdateButtons()
        {
            NazadButton.Text = "Nazad";
            if (trenutnoPitanje == 0)
            {
                NazadButton.IsEnabled = false;
            }
            else
            {
                NazadButton.IsEnabled = true;
            }

            if (trenutnoPitanje == listaNetacnihPitanja.Count - 1)
            {
                DaljeButton.Text = "Nazad na rezultate";
            }
            else
            {
                DaljeButton.Text = "Dalje";
            }
        }
        private string GetTekstPitanja()
        {
            return (trenutnoPitanje + 1) + "/" + listaNetacnihPitanja.Count + " : " + listaNetacnihPitanja[trenutnoPitanje].Pitanje1;
        }

        private void LoadPageData()
        {
            int testId = 0;

            HttpResponseMessage response = polazeService.GetResponsee(polazeId);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                Polaze polazeById = JsonConvert.DeserializeObject<Polaze>(jsonResult.Result);
                testId = polazeById.TestId;
            }
            HttpResponseMessage responsePitanja = pitanjaService.GetActionResponse("GetPitanjaByTestID", testId);
            if (responsePitanja.IsSuccessStatusCode)
            {
                var jsonResult2 = responsePitanja.Content.ReadAsStringAsync();
                listaPitanja = JsonConvert.DeserializeObject<List<Pitanje>>(jsonResult2.Result);
            }
            for (int i = 0; i < listaPitanja.Count; i++)
            {
                HttpResponseMessage responseOdgovori = odgovoriService.GetActionResponse("GetOdgovoriByPitanjeId", listaPitanja[i].PitanjeId);
                var jsonResult3 = responseOdgovori.Content.ReadAsStringAsync();
                listaOdgovora = JsonConvert.DeserializeObject<List<Odgovor>>(jsonResult3.Result);
                HttpResponseMessage responseOznaceniOdgovori = oznaceniOdgovori.GetActionResponse("GetOznaceniOdgovoriByPitanjeId", polazeId + "/" + listaPitanja[i].PitanjeId);
                var jsonResult4 = responseOznaceniOdgovori.Content.ReadAsStringAsync();
                listaOznaceniOdgovori = JsonConvert.DeserializeObject<List<OznaceniOdgovori>>(jsonResult4.Result);
                int brojacTacnihOdgovora = 0;
                int brojacOznacenih = 0;
                int brojacOznacenihTacnihOdgovora = 0;
                for (int m = 0; m < listaOdgovora.Count; m++)
                {
                    if (listaOdgovora[m].IsTacan == true)
                    {
                        brojacTacnihOdgovora++;
                    }
                }

                for (int j = 0; j < listaOdgovora.Count; j++)
                {

                    for (int k = 0; k < listaOznaceniOdgovori.Count; k++)
                    {
                        if (listaOznaceniOdgovori[k].OdgovorId == listaOdgovora[j].OdgovorId)
                        {
                            ListaOznacenihOdgovoraPoPitanjima.Add(listaOdgovora[j]);
                        }
                        if (listaOdgovora[j].IsTacan == true && listaOznaceniOdgovori[k].OdgovorId == listaOdgovora[j].OdgovorId)
                        {
                            brojacOznacenihTacnihOdgovora++;
                        }
                        if (listaOznaceniOdgovori[k].OdgovorId == listaOdgovora[j].OdgovorId)
                        {
                            brojacOznacenih++;
                        }
                    }

                }
                if (brojacTacnihOdgovora != brojacOznacenih)
                {
                    listaNetacnihPitanja.Add(listaPitanja[i]);
                }
                if(brojacTacnihOdgovora == brojacOznacenih)
                {
                    if(brojacTacnihOdgovora != brojacOznacenihTacnihOdgovora)
                    {
                        listaNetacnihPitanja.Add(listaPitanja[i]);

                    }
                }
                if (brojacTacnihOdgovora == brojacOznacenihTacnihOdgovora && brojacTacnihOdgovora == brojacOznacenih)
                {
                    continue;
                }

            }
            ucitajPitanje(trenutnoPitanje);
        }
    }
}