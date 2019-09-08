using auto_skolaAPI.Models;
using auto_skolaUI.Odgovori;
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
    public partial class PitanjeAddForm : Form
    {
        public WebAPIHelper pitanjeService = new WebAPIHelper("http://localhost:55368", "api/Pitanje");
        public WebAPIHelper tipPitanjaService = new WebAPIHelper("http://localhost:55368", "api/TipPitanja");
        public WebAPIHelper testService = new WebAPIHelper("http://localhost:55368", "api/Test");

        public Pitanje pitanje { get; set; }
        int testId { get; set; }
        public PitanjeAddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            pitanje = new Pitanje();
            
        }
        public PitanjeAddForm(int TestId)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            pitanje = new Pitanje();
        }

        private void PitanjeAddForm_Load(object sender, EventArgs e)
        {
            BindTipPitanja();
                BindTest();
        }



        private void BindTipPitanja()
        {
            HttpResponseMessage response = tipPitanjaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<asp_TipPitanja_SelectAll_Result> lst = response.Content.ReadAsAsync<List<asp_TipPitanja_SelectAll_Result>>().Result;
                lst.Insert(0, new asp_TipPitanja_SelectAll_Result());
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
                List<asp_Test_NazivPodkategorija_Result> lst = response.Content.ReadAsAsync<List<asp_Test_NazivPodkategorija_Result>>().Result; ;
                lst.Insert(0, new asp_Test_NazivPodkategorija_Result());
                testList.DataSource = lst;
                testList.DisplayMember = "Naziv";
                testList.ValueMember = "TestId";
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                pitanje.TipPitanjaId = Convert.ToInt32(tipPitanjaList.SelectedValue);
                pitanje.Pitanje1 = pitanjeInput.Text;
                pitanje.TestId = Convert.ToInt32(testList.SelectedValue);
                HttpResponseMessage responsePitanje = pitanjeService.GetActionResponse("GetBrojPitanjaPoTestu", pitanje.TestId);
                int brojPitanja = responsePitanje.Content.ReadAsAsync<int>().Result;
                if (brojPitanja < 20)
                {
                    HttpResponseMessage response = pitanjeService.PostResponse(pitanje);
                    if (response.IsSuccessStatusCode)
                    {
                        HttpResponseMessage responseMessage = pitanjeService.GetResponseAction("GetLastPitanje");
                        Pitanjel_Result p = responseMessage.Content.ReadAsAsync<Pitanjel_Result>().Result;
                        // MessageBox.Show(Messages.add_pitanje_succ);
                        OdgovorIndexForm o = new OdgovorIndexForm(p.PitanjeId);
                        o.ShowDialog();
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
                else
                {
                    MessageBox.Show("Nije moguće dodati više od 20 pitanja za odabrani test");
                }
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                slikaInput.Text = openFileDialog1.FileName;
                Image originalImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, ImageFormat.Jpeg);
                pitanje.Slika = ms.ToArray();


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
                    pitanje.SlikaThumb = ms.ToArray();

                    pictureBox.Image = resizedImage;
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

        private void tipPitanjaList_Validating(object sender, CancelEventArgs e)
        {
            if (tipPitanjaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tipPitanjaList, Messages.tipPitanja_req);

            }
            else
                errorProvider.SetError(tipPitanjaList, null);

        }

        private void testList_Validating(object sender, CancelEventArgs e)
        {
          
                if (testList.SelectedIndex == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(testList, Messages.test_req);
                }
                else
                    errorProvider.SetError(testList, null);
            
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
