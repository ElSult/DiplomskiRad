using auto_skolaAPI.Models;
using auto_skolaUI.Odgovori;
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

namespace auto_skolaUI.Tests
{
    public partial class PitanjeIndexForm : Form
    {
        public WebAPIHelper pitanjeService = new WebAPIHelper("http://localhost:55368", "api/Pitanje");
        public WebAPIHelper odgovorService = new WebAPIHelper("http://localhost:55368", "api/Odgovor");
        public WebAPIHelper testService = new WebAPIHelper("http://localhost:55368", "api/Test");


        public PitanjeIndexForm()
        {
            InitializeComponent();
            PitanjeGridView.BorderStyle = BorderStyle.None;

            PitanjeGridView.EnableHeadersVisualStyles = false;
            PitanjeGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            PitanjeGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            PitanjeGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            PitanjeGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            PitanjeGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            PitanjeGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PitanjeGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            PitanjeGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            PitanjeGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            PitanjeGridView.AutoGenerateColumns = false;
            BindTest();
        }

        private void BindTest()
        {
            HttpResponseMessage response = testService.GetResponseA("GetTestPodkategorija");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Test_NazivPodkategorija_Result> lst = response.Content.ReadAsAsync<List<asp_Test_NazivPodkategorija_Result>>().Result; ;
                lst.Insert(0, new asp_Test_NazivPodkategorija_Result());
                TestList.DataSource = lst;
                TestList.DisplayMember = "Naziv";
                TestList.ValueMember = "TestId";
            }
        }

        void BindForm()
        {
            HttpResponseMessage response = pitanjeService.GetActionResponse("SearchByName",PitanjeInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Pitanjel_Result> users = response.Content.ReadAsAsync<List<Pitanjel_Result>>().Result;
                PitanjeGridView.DataSource = users;
                PitanjeGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }


        void BindFormByTestId(int TestId)
        {

            HttpResponseMessage response = pitanjeService.GetActionResponse("SearchByTestId", TestId);

            if (response.IsSuccessStatusCode)
            {
                List<Pitanjel_Result> users = response.Content.ReadAsAsync<List<Pitanjel_Result>>().Result;
                PitanjeGridView.DataSource = users;
                PitanjeGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            BindForm();
        }

        private void NovoPitanjeButton_Click(object sender, EventArgs e)
        {
            PitanjeAddForm f = new PitanjeAddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }


        private void dodajOdgovorButton_Click(object sender, EventArgs e)
        {
            //HttpResponseMessage response = odgovorService.GetResponse();
            //List<asp_Odgovor_SelectAll_Result> odgovori = response.Content.ReadAsAsync<List<asp_Odgovor_SelectAll_Result>>().Result;

            if (PitanjeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.pitanje_select_req);
                return;
            }

            int index = 0;
            for (int i = 0; i < PitanjeGridView.SelectedRows[0].Cells.Count; i++)
            {
                if (PitanjeGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "PitanjeId")
                {
                    index = i;
                    break;
                }
            }
            bool vecPostoji = false;
            int pitanjeId = Convert.ToInt32(PitanjeGridView.SelectedRows[0].Cells[index].Value);
            HttpResponseMessage response = odgovorService.GetActionResponse("DaLiPostojiOdgovor", pitanjeId);
            if (response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                vecPostoji = true;
            }
            else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                vecPostoji = false;
            }
           
                //if (odgovori.Where(x => x.PitanjeId == Convert.ToInt32(PitanjeGridView.SelectedRows[0].Cells[index].Value)).Any())
                //    pitanjeId = odgovori.Where(x => x.PitanjeId == Convert.ToInt32(PitanjeGridView.SelectedRows[0].Cells[index].Value)).FirstOrDefault().PitanjeId;

                //if (pitanjeId != -1)
            //pitanjeId = 17;
                //else
                //     MessageBox.Show("Pitanju su dodjeljeni već odgovori", "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OdgovorIndexForm o = new OdgovorIndexForm(Convert.ToInt32(PitanjeGridView.SelectedRows[0].Cells[index].Value), vecPostoji);
                if (o.ShowDialog() == DialogResult.OK)
                    BindForm();
            }

        private void TestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TestList.SelectedIndex != 0)
            {
                int TestId = Convert.ToInt32(TestList.SelectedValue);
                if (TestId != 0)
                    BindFormByTestId(TestId);
            }
            else
                PitanjeGridView.DataSource = new List<Pitanjel_Result>();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PitanjeGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PitanjeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.pitanje_select_req);
                return;
            }

            int index = 0;
            for (int i = 0; i < PitanjeGridView.SelectedRows[0].Cells.Count; i++)
            {
                if (PitanjeGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "PitanjeId")
                {
                    index = i;
                    break;
                }
            }
            PitanjeEditForm edit = new PitanjeEditForm(Convert.ToInt32(PitanjeGridView.SelectedRows[0].Cells[index].Value));
            if (edit.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void PitanjeIndexForm_Load(object sender, EventArgs e)
        {

        }

        private void PitanjeInput_TextChanged(object sender, EventArgs e)
        {
            BindForm();
        }

        private void PitanjeInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                PitanjeInput.Text = "";
            }
            BindForm();
        }
    }
}
