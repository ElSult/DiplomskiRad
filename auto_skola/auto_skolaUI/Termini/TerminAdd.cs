using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI.Termini
{
    public partial class TerminAdd : Form
    {
        public WebAPIHelper kandidati = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper instruktori = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper automobili = new WebAPIHelper("http://localhost:55368", "api/Vozilo");
        public WebAPIHelper termini = new WebAPIHelper("http://localhost:55368", "api/Termin");

        public Termin termin { get; set; }
        public TerminAdd()
        {
     
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            termin = new Termin();
        }

        private void TerminAdd_Load(object sender, EventArgs e)
        {
            bindKandidati();
            bindInstrukori();
            bindAutomobili();
        }

        private void bindAutomobili()
        {
            HttpResponseMessage response = automobili.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Vozilo> vozila = response.Content.ReadAsAsync<List<Vozilo>>().Result;
                vozila.Insert(0, new Vozilo());
                automobilList.DataSource = vozila;
                automobilList.DisplayMember = "Naziv";
                automobilList.ValueMember = "VoziloId";
            }
        }

        private void bindInstrukori()
        {
            HttpResponseMessage response = instruktori.GetActionResponse("GetKorisnikImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Korisnici_SpojenoImePrezime_Result> korisnici = response.Content.ReadAsAsync<List<asp_Korisnici_SpojenoImePrezime_Result>>().Result;
                korisnici.Insert(0, new asp_Korisnici_SpojenoImePrezime_Result());
                instruktorList.DataSource = korisnici;
                instruktorList.DisplayMember = "ImePrezime";
                instruktorList.ValueMember = "KorisnikId";

            }
        }

        private void bindKandidati()
        {
            HttpResponseMessage response = kandidati.GetActionResponse("GetKandidatImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Kandidati_SpojenoImePrezime_Result> kandidati = response.Content.ReadAsAsync<List<asp_Kandidati_SpojenoImePrezime_Result>>().Result;
                kandidati.Insert(0, new asp_Kandidati_SpojenoImePrezime_Result());
                kandidatiList.DataSource = kandidati;
                kandidatiList.DisplayMember = "ImePrezime";

                kandidatiList.ValueMember = "KandidatId";
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                termin.Datum = datePicker.Value.Date;
                termin.Vrijeme = timePicker.Value.TimeOfDay;
                termin.VoziloId = Convert.ToInt32(automobilList.SelectedValue);
                termin.KorisnikId = Convert.ToInt32(instruktorList.SelectedValue);
                termin.KandidatId = Convert.ToInt32(kandidatiList.SelectedValue);
                termin.Napomena = napomenaInput.Text;
                HttpResponseMessage response = termini.PostResponse(termin);
                if (response.IsSuccessStatusCode)
                {
                    string poruka= response.Content.ReadAsAsync<String>().Result; ;
                    if (poruka == "")
                    {
                        MessageBox.Show(Messages.add_termin_succ);
                        DialogResult = DialogResult.OK;
                

                    }
                    else
                    {
                        MessageBox.Show(poruka);
                        DialogResult = DialogResult.OK;

                    }

                }
                else
                {
                    MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
        }

        private void instruktorList_Validating(object sender, CancelEventArgs e)
        {
            if (instruktorList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(instruktorList, Messages.user_req);

            }
            else if (automobilList.SelectedIndex == 0 || instruktorList.SelectedIndex == 0 || kandidatiList.SelectedIndex == 0)
            {
                errorProvider1.SetError(instruktorList, null);
            }
        }

        private void kandidatiList_Validating(object sender, CancelEventArgs e)
        {
            if (kandidatiList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(kandidatiList, Messages.kandidat_req);

            }
            else if (automobilList.SelectedIndex == 0 || instruktorList.SelectedIndex == 0 || kandidatiList.SelectedIndex == 0)
            {
                errorProvider1.SetError(kandidatiList, null);
            }
        }

        private void automobilList_Validating(object sender, CancelEventArgs e)
        {
            if (automobilList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(automobilList, Messages.automobil_req);

            }
            else if (automobilList.SelectedIndex == 0 || instruktorList.SelectedIndex == 0 || kandidatiList.SelectedIndex == 0)
            {
                errorProvider1.SetError(automobilList, null);
            }
        }

        private void datePicker_Validating(object sender, CancelEventArgs e)
        {
            if (automobilList.SelectedIndex == 0 || instruktorList.SelectedIndex == 0 || kandidatiList.SelectedIndex == 0)
                return;

            termin.Datum = datePicker.Value.Date;
            termin.Vrijeme = timePicker.Value.TimeOfDay;
            termin.VoziloId = Convert.ToInt32(automobilList.SelectedValue);
            termin.KorisnikId = Convert.ToInt32(instruktorList.SelectedValue);
            termin.KandidatId = Convert.ToInt32(kandidatiList.SelectedValue);

            HttpResponseMessage response = termini.PostActionResponse("DaLiJeSlobodanTermin", termin);

            if (response.IsSuccessStatusCode)
            {
                Termin zauzetiTermin = response.Content.ReadAsAsync<Termin>().Result;

                e.Cancel = true;

                if (zauzetiTermin.KorisnikId == termin.KorisnikId)
                    errorProvider1.SetError(instruktorList, Messages.instruktor_termin_err);
                else
                    errorProvider1.SetError(instruktorList, null);

                if (zauzetiTermin.KandidatId == termin.KandidatId)
                    errorProvider1.SetError(kandidatiList, Messages.kandidat_termin_err);
                else
                    errorProvider1.SetError(kandidatiList, null);

                if (zauzetiTermin.VoziloId == termin.VoziloId)
                    errorProvider1.SetError(automobilList, Messages.automobil_termin_err);
                else
                    errorProvider1.SetError(automobilList, null);

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                errorProvider1.SetError(automobilList, null);
                errorProvider1.SetError(kandidatiList, null);
                errorProvider1.SetError(instruktorList, null);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
