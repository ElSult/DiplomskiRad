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

namespace auto_skolaUI.Upis
{
    public partial class UpisujeIndexForm : Form
    {
        public WebAPIHelper instruktoriService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper uplataService = new WebAPIHelper("http://localhost:55368", "api/Uplata");
        public WebAPIHelper upisujeService = new WebAPIHelper("http://localhost:55368", "api/Upisuje");
        public WebAPIHelper podkategorijaService = new WebAPIHelper("http://localhost:55368", "api/Podkategorija");

        public int KandidatId { get; set; }
        public Upisuje u { get; set; }
        public UpisujeIndexForm()
        {
            InitializeComponent();
            upisiGridView.BorderStyle = BorderStyle.None;

            upisiGridView.EnableHeadersVisualStyles = false;
            upisiGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            upisiGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            upisiGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            upisiGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            upisiGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            upisiGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            upisiGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            upisiGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            upisiGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            upisiGridView.AutoGenerateColumns = false;
            KandidatId = 0;
            this.AutoValidate = AutoValidate.Disable;
            u = new Upisuje();
            bindInstruktori();
            bindKandidati();
            bindUplata();

            //bindGrid();
        }


        public UpisujeIndexForm(int kandidatId)
        {
            InitializeComponent();
            upisiGridView.BorderStyle = BorderStyle.None;

            upisiGridView.EnableHeadersVisualStyles = false;
            upisiGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            upisiGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            upisiGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            upisiGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            upisiGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            upisiGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            upisiGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            upisiGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            upisiGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            upisiGridView.AutoGenerateColumns = false;
            KandidatId = kandidatId;
            this.AutoValidate = AutoValidate.Disable;
            u = new Upisuje();
            bindInstruktori();
            bindKandidati1();
            bindUplata();

        }

        private void bindKandidati1()
        {
            HttpResponseMessage response = kandidatiService.GetActionResponse("GetKandidatImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Kandidati_SpojenoImePrezime_Result> kandidati = response.Content.ReadAsAsync<List<asp_Kandidati_SpojenoImePrezime_Result>>().Result;
                kandidati.Insert(0, kandidati.Where(x => x.KandidatId == KandidatId).SingleOrDefault());
                kandidatiList.DataSource = kandidati;
                kandidatiList.DisplayMember = "ImePrezime";
                kandidatiList.ValueMember = "KandidatId";
                kandidatiList.Enabled = false;
            }
        }

        private void bindGrid()
        {
            HttpResponseMessage response = upisujeService.GetActionResponse("SearchByName", imePrezimeInput.Text);
            // HttpResponseMessage response = upisujeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<asp_upisuje_SellectAll_Result> lst = response.Content.ReadAsAsync<List<asp_upisuje_SellectAll_Result>>().Result;
                upisiGridView.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }

        }

        private void bindUplata()
        {
            HttpResponseMessage response = uplataService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<asp_Uplate_SelectAll_Result> uplate = response.Content.ReadAsAsync<List<asp_Uplate_SelectAll_Result>>().Result;
                //uplate.Insert(0, new asp_Uplate_SelectAll_Result());
                uplataList.DataSource = uplate;
                uplataList.DisplayMember = "Uplata";
                uplataList.ValueMember = "UplataId";

            }
        }

        private void bindKandidati()
        {
            HttpResponseMessage response = kandidatiService.GetActionResponse("GetKandidatImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Kandidati_SpojenoImePrezime_Result> kandidati = response.Content.ReadAsAsync<List<asp_Kandidati_SpojenoImePrezime_Result>>().Result;
                kandidati.Insert(0, new asp_Kandidati_SpojenoImePrezime_Result());
                kandidatiList.DataSource = kandidati;
                kandidatiList.DisplayMember = "ImePrezime";
                kandidatiList.ValueMember = "KandidatId";
            }
        }

        private void bindInstruktori()
        {
            HttpResponseMessage response = instruktoriService.GetActionResponse("GetKorisnikImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Korisnici_SpojenoImePrezime_Result> korisnici = response.Content.ReadAsAsync<List<asp_Korisnici_SpojenoImePrezime_Result>>().Result;
                korisnici.Insert(0, korisnici.Where(x => x.KorisnikId == Global.prijavljeniKorisnik.KorisnikId).SingleOrDefault());
                instruktorList.DataSource = korisnici;
                instruktorList.DisplayMember = "ImePrezime";
                instruktorList.ValueMember = "KorisnikId";
                instruktorList.Enabled = false;
            }
        }



        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                u.DatumUpisa = datePicker.Value.Date;
                u.KandidatId = Convert.ToInt32(kandidatiList.SelectedValue);
                u.KorisnikId = Convert.ToInt32(instruktorList.SelectedValue);


                if (Convert.ToInt32(uplataList.SelectedValue) == 5)
                {
                    u.BrojUplacenihCasova = 45;
                }
                else if (Convert.ToInt32(uplataList.SelectedValue) == 2)
                {
                    u.BrojUplacenihCasova = 15;
                }
                else if (Convert.ToInt32(uplataList.SelectedValue) == 3)
                {
                    u.BrojUplacenihCasova = 30;
                }
                else if (Convert.ToInt32(uplataList.SelectedValue) == 4)
                {
                    u.BrojUplacenihCasova = 45;
                }
                else
                {
                    u.BrojUplacenihCasova = 0;
                }
                u.UplataId = Convert.ToInt32(uplataList.SelectedValue);
                HttpResponseMessage response = upisujeService.PostResponse(u);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_upis_succ);
                    DialogResult = DialogResult.OK;
                    kandidatiList.SelectedIndex = 0;
                    instruktorList.SelectedIndex = 0;
                    uplataList.SelectedValue = 0;
                    bindGrid();
                }
                else
                {
                    MessageBox.Show("Error Code:" + response.StatusCode + " Message: ");
                }
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            bindGrid();
        }



        private void instruktorList_Validating(object sender, CancelEventArgs e)
        {
            if (Global.prijavljeniKorisnik == null)
            {
                if (instruktorList.SelectedIndex == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(instruktorList, Messages.user_req);

                }
                else
                    errorProvider.SetError(instruktorList, null);
            }
        }

        private void kandidatiList_Validating(object sender, CancelEventArgs e)
        {
            if (KandidatId == 0)
            {
                if (kandidatiList.SelectedIndex == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(kandidatiList, Messages.kandidat_req);

                }
                else
                    errorProvider.SetError(kandidatiList, null);
            }
        }

        private void uplataList_Validating(object sender, CancelEventArgs e)
        {
            int kandidatId = Convert.ToInt32(kandidatiList.SelectedValue);
            int uplataId = Convert.ToInt32(uplataList.SelectedValue);

            //string kandidatID = kandidatId.ToString();
            HttpResponseMessage response = upisujeService.GetActionResponse("ProvjeraUplate", kandidatId + "/" + uplataId);
            if (response.IsSuccessStatusCode)
            {
                List<asp_Provjera_Uplate_Result> uplate = response.Content.ReadAsAsync<List<asp_Provjera_Uplate_Result>>().Result;
                if (uplate.Count > 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(uplataList, Messages.uplata_uniq + uplate[0].Nacin);
                }
                else
                    errorProvider.SetError(uplataList, null);
            }
            HttpResponseMessage response2 = upisujeService.GetActionResponse("ProvjeraNacinaPlacanja", kandidatId + "/" + uplataId);

            if (response.IsSuccessStatusCode)
            {
                string poruka = response2.Content.ReadAsAsync<string>().Result;
                if (poruka != "nista")
                {
                    e.Cancel = true;
                    errorProvider.SetError(uplataList, poruka);
                }
                else
                    errorProvider.SetError(uplataList, null);
            }
        }

        private void UpisujeIndexForm_Load(object sender, EventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void imePrezimeInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                imePrezimeInput.Text = "";
            }
            bindGrid();

        }
    }
}
