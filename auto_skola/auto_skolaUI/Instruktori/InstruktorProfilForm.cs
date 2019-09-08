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

namespace auto_skolaUI.Instruktori
{
    public partial class InstruktorProfilForm : Form
    {
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper ocjeneService = new WebAPIHelper("http://localhost:55368", "api/Ocjene");
        private Korisnici k { get; set; }

        public InstruktorProfilForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = korisniciService.GetResponse(Global.prijavljeniKorisnik.KorisnickoIme);
            asp_Korisnici_SelectByUsername_Result k = response.Content.ReadAsAsync<asp_Korisnici_SelectByUsername_Result>().Result;

            Korisnici korisnik = new Korisnici
            {
                Adresa = k.Adresa,
                DatumPrijave = k.DatumPrijave,
                Email = k.Email,
                Ime = k.Ime,
                KorisnickoIme = k.KorisnickoIme,
                KorisnikId = k.KorisnikId,
                LozinkaHash = k.LozinkaHash,
                LozinkaSalt = k.LozinkaSalt,
                Napomena = k.Napomena,
                Prezime = k.Prezime,
                Slika = k.Slika,
                SlikaThumb = k.SlikaThumb,
                Status = k.Status,
                Telefon = k.Telefon,
            };
            
            this.k = korisnik;

            FillForm();
        }

        private void FillForm()
        {
            imePrezimeLbL.Text = k.Ime+" "+k.Prezime;
           // prezimeInput.Text = k.Prezime;
            adresaInput.Text = k.Adresa;
            if (k.SlikaThumb != null)
            {
                byte[] image = k.SlikaThumb;
                MemoryStream ms = new MemoryStream(image);
                Image i = Image.FromStream(ms);
                pictureBox.Image = i;
            }
            emailInput.Text = k.Email;
            telefonInput.Text = k.Telefon;
            korisnickoImeLbL.Text = k.KorisnickoIme;
            napomenaLbL.Text = k.Napomena;

            HttpResponseMessage response = ocjeneService.GetActionResponse("GetRejtingByKorisnikId", k.KorisnikId);
            if (response.IsSuccessStatusCode)
            {
                decimal rejting = response.Content.ReadAsAsync<decimal>().Result;
                rejtingLbl.Text = rejting.ToString("0.00");
            }
            
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (k != null)
                {
                    k.Adresa = adresaInput.Text;
                    k.Email = emailInput.Text;
                    k.Telefon = telefonInput.Text;
                    
                    if (lozinkaInput.Text != String.Empty)
                    {
                        k.LozinkaSalt = UIHelper.GenerateSalt();
                        k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                    }
                }
                HttpResponseMessage response = korisniciService.PutResponse(k.KorisnikId, k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_user_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Error code", response.StatusCode + " Message: " + response.ReasonPhrase);
                }
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

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, Messages.tel_req);
            }
            else
            {
                errorProvider.SetError(telefonInput, null);
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(lozinkaInput.Text))
            {
                if (lozinkaInput.TextLength < 3)
                {
                    e.Cancel = true;
                    errorProvider.SetError(lozinkaInput, Messages.pass_err);
                }
            }
            else
            {
                errorProvider.SetError(lozinkaInput, null);
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

                if (resizedImage.Width >= croppedImageWidth && resizedImage.Height >= croppedImageHeight)
                {
                    if (resizedImage.Width > 120 && resizedImage.Height > 120)
                    {
                        int croppedPositionX = 0;
                        int croppedPositionY = 0;
                        croppedImage = Util.UIHelper.CropImage(resizedImage, new Rectangle(croppedPositionX, croppedPositionY, croppedImageWidth, croppedImageHeight));

                        ms = new MemoryStream();
                        croppedImage.Save(ms, ImageFormat.Jpeg);
                        k.SlikaThumb = ms.ToArray();
                        pictureBox.Image = croppedImage;

                        //ms = new MemoryStream();
                        //resizedImage.Save(ms, ImageFormat.Jpeg);
                        //k.SlikaThumb = ms.ToArray();

                        //pictureBox.Image = resizedImage;
                        pictureBox.Image = croppedImage;
                    }
                }
                else
                {
                    ms = new MemoryStream();
                    resizedImage.Save(ms, ImageFormat.Jpeg);
                    k.SlikaThumb = ms.ToArray();

                    pictureBox.Image = resizedImage;
                }

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
