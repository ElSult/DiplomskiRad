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
using auto_skolaAPI.Models;


namespace auto_skolaUI.Tests
{
    public partial class TestIndexForm : Form
    {
        public WebAPIHelper podkategorijeService = new WebAPIHelper("http://localhost:55368", "api/Podkategorija");
        public WebAPIHelper testService = new WebAPIHelper("http://localhost:55368", "api/Test");
        public Test urediTest { get; set; }
        public TestIndexForm()
        {

            InitializeComponent();
            testGridView.BorderStyle = BorderStyle.None;

            testGridView.EnableHeadersVisualStyles = false;
            testGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            testGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            testGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            testGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            testGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            testGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            testGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            testGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            testGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            testGridView.AutoGenerateColumns = false;
            bindKategorija();
            this.AutoValidate = AutoValidate.Disable;

        }

        private void bindForm()
        {
            HttpResponseMessage response = testService.GetActionResponse("GetTestByName", pretragaInput.Text);
            if (response.IsSuccessStatusCode)
            {
                List<asp_Test_Select_All_Result> testovi = response.Content.ReadAsAsync<List<asp_Test_Select_All_Result>>().Result;
                testGridView.DataSource = testovi;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message:" + response.ReasonPhrase);
            }
        }

        private void bindKategorija()
        {
            HttpResponseMessage response = podkategorijeService.GetResponse();

            if (urediTest != null)
            {
                if (response.IsSuccessStatusCode)
                {
                    List<asp_Podkategorija_SelectAll_Result> lst = response.Content.ReadAsAsync<List<asp_Podkategorija_SelectAll_Result>>().Result;
                    lst.Insert(0, lst.Where(x => x.PodkategorijaId == urediTest.PodkategorijaId).SingleOrDefault());
                    PodkategorijaList.DataSource = lst;
                    PodkategorijaList.DisplayMember = "Naziv";
                    PodkategorijaList.ValueMember = "PodKategorijaId";
                }


            }
            else
            {
                if (response.IsSuccessStatusCode)
                {
                    List<asp_Podkategorija_SelectAll_Result> lst = response.Content.ReadAsAsync<List<asp_Podkategorija_SelectAll_Result>>().Result;
                    lst.Insert(0, new asp_Podkategorija_SelectAll_Result());
                    PodkategorijaList.DataSource = lst;
                    PodkategorijaList.DisplayMember = "Naziv";
                    PodkategorijaList.ValueMember = "PodKategorijaId";
                }
            }
        }

        private void TestIndexForm_Load(object sender, EventArgs e)
        {
            bindForm();

        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (urediTest == null)
                {
                    Test noviTest = new Test();
                    noviTest.PodkategorijaId = Convert.ToInt32(PodkategorijaList.SelectedValue);
                    noviTest.Naziv = nazivTestaInput.Text;
                    noviTest.ParcijalnoBodovanje = parcijalnoBodovanjeCbx.Checked;

                    HttpResponseMessage response = testService.PostResponse(noviTest);

                    if (response.IsSuccessStatusCode)
                    {
                        DialogResult = DialogResult.OK;
                        nazivTestaInput.Clear();
                        PodkategorijaList.SelectedIndex = 0;
                        parcijalnoBodovanjeCbx.Checked = false;
                        bindForm();

                    }
                    else
                    {
                        string msg = response.ReasonPhrase;
                        if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                            msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

                        MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + msg);
                    }
                }
                else
                {
                    urediTest.PodkategorijaId = Convert.ToInt32(PodkategorijaList.SelectedValue);
                    urediTest.Naziv = nazivTestaInput.Text;
                    urediTest.ParcijalnoBodovanje = parcijalnoBodovanjeCbx.Checked;
                    HttpResponseMessage response = testService.PutResponse(urediTest.TestId,urediTest);
                    if (response.IsSuccessStatusCode)
                    {
                        DialogResult = DialogResult.OK;
                        nazivTestaInput.Clear();
                        PodkategorijaList.SelectedIndex = 0;
                        parcijalnoBodovanjeCbx.Checked = false;

                        bindForm();

                    }
                    else
                    {
                        string msg = response.ReasonPhrase;
                        if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                            msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

                        MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + msg);
                    }

                }
            }
        }

        private void nazivTestaInput_Validating(object sender, CancelEventArgs e)
        {
            int PodkategorijaId = Convert.ToInt32(PodkategorijaList.SelectedValue);
            string Naziv = nazivTestaInput.Text;
            if (String.IsNullOrEmpty(nazivTestaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTestaInput, Messages.testNaziv_req);
            }
            else
            {
                errorProvider.SetError(nazivTestaInput, null);
            }
            if (urediTest == null)
            {
                if (!String.IsNullOrEmpty(nazivTestaInput.Text))
                {
                    HttpResponseMessage response = testService.GetActionResponse("DaLiPostojiTestSaPodkategorijom", Naziv + "/" + PodkategorijaId);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(nazivTestaInput, Messages.testNaziv_uniq);
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        errorProvider.SetError(nazivTestaInput, null);
                    }
                }
            }
            else
                errorProvider.SetError(nazivTestaInput, null);

        }

        private void PodkategorijaList_Validating(object sender, CancelEventArgs e)
        {
            if (urediTest == null)
            {
                if (PodkategorijaList.SelectedIndex == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(PodkategorijaList, Messages.podkategorija_req);

                }
                else
                    errorProvider.SetError(PodkategorijaList, null);
            }
            else
                errorProvider.SetError(PodkategorijaList, null);
        }


        private void TraziButton_Click(object sender, EventArgs e)
        {
            bindForm();

        }

        private void testGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            urediTest = new Test();

            int index = 0;
            if (testGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.user_select_req);
            }
            else
            {
                for (int i = 0; i < testGridView.SelectedRows[0].Cells.Count; i++)
                {
                    if (testGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "TestId")
                    {
                        index = i;
                        break;
                    }
                }
                HttpResponseMessage response = testService.GetResponse((Convert.ToInt32(testGridView.SelectedRows[0].Cells[index].Value)).ToString());
                if (response.IsSuccessStatusCode)
                {
                    urediTest = response.Content.ReadAsAsync<Test>().Result;
                    nazivTestaInput.Text = urediTest.Naziv;
                    parcijalnoBodovanjeCbx.Checked = urediTest.ParcijalnoBodovanje;
                    bindKategorija();
                }
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void testGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_OcistiFormu_Click(object sender, EventArgs e)
        {
            urediTest = null;
            nazivTestaInput.Clear();
            PodkategorijaList.SelectedIndex = 0;
            parcijalnoBodovanjeCbx.Checked = false;
        }

        private void pretragaInput_TextChanged(object sender, EventArgs e)
        {
            bindForm();
        }

        private void pretragaInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pretragaInput.Text = "";
            }
            bindForm();
        }
    }
}
