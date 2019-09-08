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
    public partial class TerminAddForm : Form
    {
        public WebAPIHelper termini = new WebAPIHelper("http://localhost:55368", "api/Termin");
        public TerminAddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }


        private void TerminAddForm_Load(object sender, EventArgs e)
        {
            terminiGridView.BorderStyle = BorderStyle.None;

            terminiGridView.EnableHeadersVisualStyles = false;
            terminiGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            terminiGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            terminiGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            terminiGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            terminiGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            terminiGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            terminiGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            terminiGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            terminiGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            terminiGridView.AutoGenerateColumns = false;
            bindDataGrid();
           
        }



        private void bindDataGrid()
        {
            HttpResponseMessage response = termini.GetActionResponse("SearchByName", imePrezimeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                List<asp_Termin_SelectAll_Result> termini = response.Content.ReadAsAsync<List<asp_Termin_SelectAll_Result>>().Result;
                terminiGridView.DataSource = termini;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message:" + response.ReasonPhrase);
            }
        }


        private void TraziButton_Click(object sender, EventArgs e)
        {
            bindDataGrid();
        }





        private void dodajBtn_Click(object sender, EventArgs e)
        {
            TerminAdd add = new TerminAdd();
            if (add.ShowDialog() == DialogResult.OK)
            {
                bindDataGrid();
            }
        }

        private void OznaciOdrzanBtn_Click(object sender, EventArgs e)
        {
            if (terminiGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.termin_select_req);
                return;
            }

            int TerminId = int.Parse(terminiGridView.SelectedRows[0].Cells[0].Value.ToString());
            HttpResponseMessage response = termini.GetResponsee(TerminId);
            if (response.IsSuccessStatusCode)
            {
                var termin = response.Content.ReadAsAsync<Termin>().Result;
                if(termin.IsOdrzan)
                {
                    MessageBox.Show("Vožnja je prethodno održana!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                termin.IsOdrzan = true;

                HttpResponseMessage response1 = termini.PutResponse(termin.TerminId, termin);
                if (response1.IsSuccessStatusCode)
                {
                    MessageBox.Show("Vožnja je održana.", "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindDataGrid();
                }
                else
                {
                    MessageBox.Show("Error code", response1.StatusCode + " Message: " + response1.ReasonPhrase);
                }
            }

        }

        private void terminiGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (terminiGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.termin_select_req);
            }
            else
            {
                int index = 0;
                for (int i = 0; i < terminiGridView.SelectedRows[0].Cells.Count; i++)
                {
                    if (terminiGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "TerminId")
                    {
                        index = i;
                        break;
                    }
                }
                TerminEditForm edit = new TerminEditForm(Convert.ToInt32(terminiGridView.SelectedRows[0].Cells[index].Value));
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    bindDataGrid();
                }
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imePrezimeInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                imePrezimeInput.Text = "";
            }
            bindDataGrid();
        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            bindDataGrid();
        }
    }
}
