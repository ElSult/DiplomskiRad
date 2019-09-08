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

namespace auto_skolaUI.VozackiIspit1
{
    public partial class EvidencijaForm : Form
    {
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper tipIspitaService = new WebAPIHelper("http://localhost:55368", "api/TipIspita");
        public WebAPIHelper vozackiIspitService = new WebAPIHelper("http://localhost:55368", "api/VozackiIspit");


        public EvidencijaForm()
        {
            InitializeComponent();
            BindKandidati();
            BindTipIspita();
            BindGrid();

        }

        private void BindGrid()
        {
            
            HttpResponseMessage response = vozackiIspitService.GetActionResponse("GetByImePrezime", imePrezimeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                List<asp_VozackiIspit_Result> lst = response.Content.ReadAsAsync<List<asp_VozackiIspit_Result>>().Result;
                vozackiIspitGridView.DataSource = lst;
                vozackiIspitGridView.AutoGenerateColumns = false;
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void BindTipIspita()
        {
            HttpResponseMessage response = tipIspitaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<asp_Tip_Ispita_SelectAll_Result> tipoviIspita = response.Content.ReadAsAsync<List<asp_Tip_Ispita_SelectAll_Result>>().Result;
                tipoviIspita.Insert(0, new asp_Tip_Ispita_SelectAll_Result());
                tipIspitaList.DataSource = tipoviIspita;
                tipIspitaList.DisplayMember = "Naziv";

                tipIspitaList.ValueMember = "TipIspitaId";
            }
        }

        private void BindKandidati()
        {
            HttpResponseMessage response = kandidatiService.GetActionResponse("GetNepolozeniKandidati");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Podaci_Za_KNN_Result> kandidati = response.Content.ReadAsAsync<List<asp_Podaci_Za_KNN_Result>>().Result;
                kandidati.Insert(0, new asp_Podaci_Za_KNN_Result());
                kandidatiList.DataSource = kandidati;
                kandidatiList.DisplayMember = "ImePrezime";

                kandidatiList.ValueMember = "KandidatId";
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            VozackiIspit vi = new VozackiIspit();
            vi.Datum = datePicker.Value;
            vi.IsPolozio = cbxIsPolozio.Checked;
            vi.KandidatId = Convert.ToInt32(kandidatiList.SelectedValue);
            vi.TipIspitaId = Convert.ToInt32(tipIspitaList.SelectedValue);
           


            HttpResponseMessage response = vozackiIspitService.PostResponse(vi);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Korisnik uspjesno dodan!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string msg = response.ReasonPhrase;
                if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                    msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + msg);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EvidencijaForm_Load(object sender, EventArgs e)
        {

        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void imePrezimeInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                imePrezimeInput.Text = "";
            }
            BindGrid();
        }
    }
}
