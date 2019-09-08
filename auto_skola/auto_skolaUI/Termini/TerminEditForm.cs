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
    public partial class TerminEditForm : Form
    {
        public WebAPIHelper kandidati = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper instruktori = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper termini = new WebAPIHelper("http://localhost:55368", "api/Termin");
        public WebAPIHelper vozilo = new WebAPIHelper("http://localhost:55368", "api/Vozilo");
        public Termin termin { get; set; }
        public TerminEditForm(int id)
        {
            InitializeComponent();
            
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = termini.GetResponsee(id);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                termin = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                termin = response.Content.ReadAsAsync<Termin>().Result;
                FillForm();
            }

        }

        private void FillForm()
        {
            bindKandidati();
            bindInstruktori();
            bindAutomobil();
            napomenaInput.Text = termin.Napomena;
            datePicker.Value = termin.Datum;
            // timePicker.Value = termin.Vrijeme;
            DateTime dt = Convert.ToDateTime(termin.Vrijeme.ToString());
            timePicker.Value = dt;
        }

        private void bindAutomobil()
        {
            HttpResponseMessage response = vozilo.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Vozilo> lst = response.Content.ReadAsAsync<List<Vozilo>>().Result;
                lst.Insert(0, lst.Where(x => x.VoziloId == termin.VoziloId).SingleOrDefault());
                automobilList.DataSource = lst;
                automobilList.DisplayMember = "Naziv";
                automobilList.ValueMember = "VoziloId";
            }
        }

        private void bindInstruktori()
        {
            HttpResponseMessage response = instruktori.GetActionResponse("GetKorisnikImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Korisnici_SpojenoImePrezime_Result> lst = response.Content.ReadAsAsync<List<asp_Korisnici_SpojenoImePrezime_Result>>().Result;
                lst.Insert(0, lst.Where(x => x.KorisnikId == termin.KorisnikId).SingleOrDefault());
                instruktorList.DataSource = lst;
                instruktorList.DisplayMember = "ImePrezime";
                instruktorList.ValueMember = "KorisnikId";
            }
        }

        private void bindKandidati()
        {
            HttpResponseMessage response = kandidati.GetActionResponse("GetKandidatImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Kandidati_SpojenoImePrezime_Result> lst = response.Content.ReadAsAsync<List<asp_Kandidati_SpojenoImePrezime_Result>>().Result;
                lst.Insert(0, lst.Where(x => x.KandidatId == termin.KandidatId).SingleOrDefault());
                kandidatiList.DataSource = lst;
                kandidatiList.DisplayMember = "ImePrezime";
                kandidatiList.ValueMember = "KandidatId";
            }
        }


        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (termin != null)
            {
                termin.Datum = datePicker.Value.Date;
                termin.Vrijeme = timePicker.Value.TimeOfDay;
                termin.VoziloId = Convert.ToInt32(automobilList.SelectedValue);
                termin.KorisnikId = Convert.ToInt32(instruktorList.SelectedValue);
                termin.KandidatId = Convert.ToInt32(kandidatiList.SelectedValue);
                termin.Napomena = napomenaInput.Text;
            }
            HttpResponseMessage response = termini.PutResponse(termin.TerminId, termin);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.edit_termin_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error code", response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
