using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI.Postavke
{
    public partial class postavkeIndexForm : Form
    {
        public WebAPIHelper izborService = new WebAPIHelper("http://localhost:55368", "api/Izbor");
        public asp_Izbor_GetIzborById_Result urediIzbor { get; set; }
        private bool daLiSeUredjuje { get; set; }
        public Izbor noviIzbor { get; set; }
        public postavkeIndexForm()
        {
            InitializeComponent();
            postavkeGridView.BorderStyle = BorderStyle.None;

            postavkeGridView.EnableHeadersVisualStyles = false;
            postavkeGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            postavkeGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 76, 78);
            postavkeGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            postavkeGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            postavkeGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 32, 31);
            postavkeGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            postavkeGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 56, 55);
            postavkeGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            postavkeGridView.BackgroundColor = Color.FromArgb(30, 32, 31);
            postavkeGridView.AutoGenerateColumns = false;
            this.AutoValidate = AutoValidate.Disable;
            urediIzbor = null;
            bindForm();
            noviIzbor = new Izbor();


        }

        private void bindForm()
        {
            HttpResponseMessage response = izborService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<asp_Izbor_SelectAll_Result> izbor = response.Content.ReadAsAsync<List<asp_Izbor_SelectAll_Result>>().Result;
                postavkeGridView.DataSource = izbor;
                postavkeGridView.AutoGenerateColumns = false;

            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message:" + response.ReasonPhrase);
            }
        }


        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void postavkeGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            var result = (new PotvdaIzlaskaForm()).ShowDialog();
            if (result == DialogResult.Yes)
            {
                int index = 0;
                if (postavkeGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Niste odabrali niti jedu stavku");
                }
                else
                {
                    for (int i = 0; i < postavkeGridView.SelectedRows[0].Cells.Count; i++)
                    {
                        if (postavkeGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "IzborId")
                        {
                            index = i;
                            break;
                        }
                    }
                }
                int pozicija = (Convert.ToInt32(postavkeGridView.SelectedRows[0].Cells[index].Value));

                HttpResponseMessage response = izborService.DeleteResponse(pozicija);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno obrisana stavka.");
                    bindForm();

                }
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            noviIzbor.KorisnikId = Global.prijavljeniKorisnik.KorisnikId;
            noviIzbor.Naziv = nazivStavkeInput.Text;
            noviIzbor.DatumIzmjene = DateTime.Now;
            if (daLiSeUredjuje != true)
            {
                noviIzbor.DatumUpisivanja = DateTime.Now;

                HttpResponseMessage response = izborService.PostResponse(noviIzbor);
                if (response.IsSuccessStatusCode)
                {
                    // DialogResult = DialogResult.OK;
                    nazivStavkeInput.Clear();
                    slikaInput.Clear();
                    pictureBox.Image = null;
                    MessageBox.Show("Stavka u početnom meniju dodana.");
                    bindForm();

                    //Close();
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
                noviIzbor.IzborId = urediIzbor.IzborId;
                HttpResponseMessage response = izborService.PutResponse(noviIzbor.IzborId,noviIzbor);
                if (response.IsSuccessStatusCode)
                {
                    // DialogResult = DialogResult.OK;
                    MessageBox.Show("Stavka u početnom meniju izmjenjena.");
                    bindForm();
                   // Close();
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

        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                slikaInput.Text = openFileDialog1.FileName;
                Image originalImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, ImageFormat.Jpeg);
                noviIzbor.Slika = ms.ToArray();


                int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                int croppedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageWidth"]);
                int croppedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageHeight"]);


                Image resizedImage = originalImage;
                Image croppedImage;
                if (originalImage.Width > resizedImageWidth && originalImage.Height > resizedImageHeight)
                {
                    resizedImage = Util.UIHelper.ResizeImage(originalImage, new Size(resizedImageWidth, resizedImageHeight));
                    croppedImage = resizedImage;

                    ms = new MemoryStream();
                    resizedImage.Save(ms, ImageFormat.Jpeg);
                    noviIzbor.Slika = ms.ToArray();

                    pictureBox.Image = resizedImage;
                }

            }
        }

        private void postavkeIndexForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_OcistiFormu_Click(object sender, EventArgs e)
        {
            nazivStavkeInput.Clear();
            slikaInput.Clear();
            pictureBox.Image = null;
        }

        private void postavkeGridView_MouseClick(object sender, MouseEventArgs e)
        {
            urediIzbor = null;
            daLiSeUredjuje = true;

            urediIzbor = new asp_Izbor_GetIzborById_Result();

            int index = 0;
            if (postavkeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali niti jedu stavku");

            }
            else
            {
                for (int i = 0; i < postavkeGridView.SelectedRows[0].Cells.Count; i++)
                {
                    if (postavkeGridView.SelectedRows[0].Cells[i].OwningColumn.Name == "IzborId")
                    {
                        index = i;
                        break;
                    }
                }
                HttpResponseMessage response = izborService.GetResponse((Convert.ToInt32(postavkeGridView.SelectedRows[0].Cells[index].Value)).ToString());
                if (response.IsSuccessStatusCode)
                {
                    urediIzbor = response.Content.ReadAsAsync<asp_Izbor_GetIzborById_Result>().Result;
                    nazivStavkeInput.Text = urediIzbor.Naziv;
                    if (urediIzbor.Slika != null)
                    {
                        byte[] image = urediIzbor.Slika;
                        MemoryStream ms = new MemoryStream(image);
                        Image i = Image.FromStream(ms);
                        pictureBox.Image = i;
                    }
                }
            }
        }
    }
}
