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

namespace auto_skolaUI.Tests
{
    public partial class PitanjeEditForm : Form
    {
        public WebAPIHelper pitanjeService = new WebAPIHelper("http://localhost:55368", "api/Pitanje");
        public WebAPIHelper tipPitanjaService = new WebAPIHelper("http://localhost:55368", "api/TipPitanja");
        public WebAPIHelper testService = new WebAPIHelper("http://localhost:55368", "api/Test");
        public static Pitanje p { get; set; }

        public PitanjeEditForm(int pitanjeId)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = pitanjeService.GetResponsee(pitanjeId);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                p = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                p = response.Content.ReadAsAsync<Pitanje>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            pitanjeInput.Text = p.Pitanje1;
            if (p.SlikaThumb != null)
            {
                byte[] image = p.SlikaThumb;
                MemoryStream ms = new MemoryStream(image);
                Image i = Image.FromStream(ms);
                pictureBox.Image = i;
            }
            BindTipPitanja();
            BindTest();

        }


        private void BindTipPitanja()
        {
            HttpResponseMessage response = tipPitanjaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<asp_TipPitanja_SelectAll_Result> lst = response.Content.ReadAsAsync<List<asp_TipPitanja_SelectAll_Result>>().Result;
                lst.Insert(0, lst.Where(x => x.TipPitanjaId == p.TipPitanjaId).SingleOrDefault());
                tipPitanjaList.DataSource = lst;
                tipPitanjaList.DisplayMember = "Tip";
                tipPitanjaList.ValueMember = "TipPitanjaId";
            };
        }


        private void BindTest()
        {
            HttpResponseMessage response = testService.GetResponseA("GetTestPodkategorija");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Test_NazivPodkategorija_Result> lst = response.Content.ReadAsAsync<List<asp_Test_NazivPodkategorija_Result>>().Result; 
                lst.Insert(0, lst.Where(x => x.TestId == p.TestId).SingleOrDefault());
                testList.DataSource = lst;
                testList.DisplayMember = "Naziv";
                testList.ValueMember = "TestId";
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogE.ShowDialog() == DialogResult.OK)
            {
                slikaInput.Text = openFileDialogE.FileName;
                Image originalImage = Image.FromFile(openFileDialogE.FileName);
                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, ImageFormat.Jpeg);
                p.Slika = ms.ToArray();
            

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
                }



                ms = new MemoryStream();
                resizedImage.Save(ms, ImageFormat.Jpeg);
                p.SlikaThumb = ms.ToArray();

                pictureBox.Image = resizedImage;
      

            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (p != null)
                {
                    if (!String.IsNullOrEmpty(pitanjeInput.Text))
                    {
                        p.Pitanje1 = pitanjeInput.Text;
                    }
                    p.TestId = Convert.ToInt32(testList.SelectedValue);
                    p.TipPitanjaId = Convert.ToInt32(tipPitanjaList.SelectedValue);
                }
                HttpResponseMessage response = pitanjeService.PutResponse(p.PitanjeId, p);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_pitanje_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error code", response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
        }

        private void pitanjeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(pitanjeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(pitanjeInput, Messages.pitanje_req);
            }
            else
            {
                errorProvider.SetError(pitanjeInput, null);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
