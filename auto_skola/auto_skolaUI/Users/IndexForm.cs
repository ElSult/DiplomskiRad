using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using auto_skolaUI.Users;

namespace auto_skolaUI
{
    public partial class IndexForm : Form
    {
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public IndexForm()
        {
            InitializeComponent();
            korisnikGridView.BorderStyle = BorderStyle.None;

            korisnikGridView.EnableHeadersVisualStyles = false;
            korisnikGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            korisnikGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            korisnikGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            korisnikGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            korisnikGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            korisnikGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            korisnikGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            korisnikGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            korisnikGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            korisnikGridView.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
  

        private void IndexForm_Load(object sender, EventArgs e)
        {
            //BindForm();
        }
        void BindForm()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchByName", imePrezimeInput.Text);

            if (response.IsSuccessStatusCode)
            {
                List<asp_Korisnici_SearchByName_Result> users = response.Content.ReadAsAsync<List<asp_Korisnici_SearchByName_Result>>().Result; 
               korisnikGridView.DataSource = users;
               // korisnikGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
        private void dodajKorisnikaButton_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
           if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
                BindForm();

        }





        private void korisnikGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = 0;
            if (korisnikGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.user_select_req);
            }
            else
            {
                for (int i = 0; i < korisnikGridView.SelectedRows[0].Cells.Count; i++)
                {
                    if (korisnikGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "KorisnikId")
                    {
                        index = i;
                        break;
                    }
                }
                EditForm edit = new EditForm(Convert.ToInt32(korisnikGridView.SelectedRows[0].Cells[index].Value));
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    BindForm();
                }
            }
        }

        private void TraziButton_Click_1(object sender, EventArgs e)
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
