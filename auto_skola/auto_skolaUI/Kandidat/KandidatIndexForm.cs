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

namespace auto_skolaUI.Kandidat
{
    public partial class KandidatIndexForm : Form
    {
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");

        public KandidatIndexForm()
        {
            InitializeComponent();
            kandidatGridView.BorderStyle = BorderStyle.None;

            kandidatGridView.EnableHeadersVisualStyles = false;
            kandidatGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kandidatGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            kandidatGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            kandidatGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            kandidatGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            kandidatGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kandidatGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            kandidatGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            kandidatGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            kandidatGridView.AutoGenerateColumns = false;
        }

        private void dodajKandidataButton_Click(object sender, EventArgs e)
        {
            Kandidat.KandidatAddForm frm = new KandidatAddForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void BindForm()
        {
            HttpResponseMessage response = kandidatiService.GetActionResponse("SearchByName", imePrezimeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                List<asp_Kandidati_SearchByName_Result> lst = response.Content.ReadAsAsync<List<asp_Kandidati_SearchByName_Result>>().Result;
                kandidatGridView.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void KandidatIndexForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            BindForm();
        }



        private void imePrezimeInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                imePrezimeInput.Text = "";
            }
            BindForm();
        }

        private void kandidatGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (kandidatGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.kandidat_select_req);
            }
            else
            {
                int index = -1;
                for (int i = 0; i < kandidatGridView.SelectedRows[0].Cells.Count; i++)
                {
                    if (kandidatGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "KandidatId")
                    {
                        index = i;
                        break;
                    }
                }
                Kandidat.KandidatEditForm edit = new KandidatEditForm(Convert.ToInt32(kandidatGridView.SelectedRows[0].Cells[index].Value));
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    BindForm();
                }
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindForm();
        }
    }
}
