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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI
{
    public partial class AddForm : Form
    {
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:55368", "api/Uloge");
        private Korisnici k { get; set; }
        public AddForm()
        {
            InitializeComponent();
            k = new Korisnici();
            this.AutoValidate = AutoValidate.Disable;
        }



        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {             
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Adresa = adresaInput.Text;
                k.Email = emailInput.Text;
                k.Telefon = telefonInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = Util.UIHelper.GenerateSalt();
                k.LozinkaHash = Util.UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.Napomena = napomenaInput.Text;
                k.Status = true;
              List< Uloge> lista=new List<Uloge>();
                foreach (asp_Uloge_SelectAll_Result item in ulogeList.CheckedItems)
                {
                    lista.Add( new Uloge
                    {
                        UlogaId = item.UlogaId,
                        Naziv = item.Naziv,
                        Opis = item.Opis
                    });
                }
                k.Uloge = lista;

                HttpResponseMessage response = korisniciService.PostResponse(k);
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
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulogeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<asp_Uloge_SelectAll_Result>>().Result;
                ulogeList.DisplayMember = "Naziv";
                ulogeList.ClearSelected();
            }
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Messages.fname_req);
            }
            else
            {
                errorProvider.SetError(imeInput, null);
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Messages.lname_req);
            }
            else
            {
                errorProvider.SetError(prezimeInput, null);
            }
        }

        private void adresaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(adresaInput, Messages.adrr_req);
            }
            else
            {
                errorProvider.SetError(adresaInput, null);
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Messages.email_req);
            }
            else if (!String.IsNullOrEmpty(emailInput.Text))
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Messages.email_err);

                }
            }
            else
            {
                errorProvider.SetError(emailInput, null);
            }
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.uname_req);
            }
            else if (korisnickoImeInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.uname_lng);
            }
            else
            {
                errorProvider.SetError(korisnickoImeInput, null);
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_req);
            }
            else if (lozinkaInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_err);
            }
            else
            {
                errorProvider.SetError(lozinkaInput, null);
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInput.Text) || !telefonInput.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, Messages.tel_req);
            }
            else
            {
                errorProvider.SetError(telefonInput, null);
            }
        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedIndices.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Messages.uloge_req);
            }
            else
            {
                errorProvider.SetError(ulogeList, null);
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
                k.Slika = ms.ToArray();
                /*
                 resizedImageWidth
                 resizedImageHeight
                 croppedImageWidth
                 croppedImageHeight
                 */

                int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedUserImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedUserImageHeight"]);
                int croppedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageWidth"]);
                int croppedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageHeight"]);


                Image resizedImage = originalImage;
                Image croppedImage;
                if (originalImage.Width > resizedImageWidth && originalImage.Height > resizedImageHeight)
                {
                    resizedImage = Util.UIHelper.ResizeImage(originalImage, new Size(resizedImageWidth, resizedImageHeight));
                    croppedImage = resizedImage;
                }

                //if (resizedImage.Width >= croppedImageWidth && resizedImage.Height >= croppedImageHeight)
                //{
                //    if (resizedImage.Width > 120 && resizedImage.Height > 120)
                //    {
                //        int croppedPositionX = 0;
                //        int croppedPositionY = 0;
                //        croppedImage = Util.UIHelper.CropImage(resizedImage, new Rectangle(croppedPositionX, croppedPositionY, croppedImageWidth, croppedImageHeight));

                //        ms = new MemoryStream();
                //        croppedImage.Save(ms, ImageFormat.Jpeg);
                //        p.SlikaThumb = ms.ToArray();
                //        pictureBox.Image = croppedImage;

                ms = new MemoryStream();
                resizedImage.Save(ms, ImageFormat.Jpeg);
                k.SlikaThumb = ms.ToArray();

                pictureBox.Image = resizedImage;
                //    }
                //}

            }

        }

        private void prezimeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void imeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
