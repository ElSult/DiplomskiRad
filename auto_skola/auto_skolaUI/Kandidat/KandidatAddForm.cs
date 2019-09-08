using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI.Kandidat
{
    public partial class KandidatAddForm : Form
    {
        public WebAPIHelper kandidatService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper spolService = new WebAPIHelper("http://localhost:55368", "api/Spol");



        public KandidatAddForm()
        {
            InitializeComponent();
            bindSpol();

            this.AutoValidate = AutoValidate.Disable;
        }

        private void bindSpol()
        {
            HttpResponseMessage response = spolService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Spol> spolovi = response.Content.ReadAsAsync<List<Spol>>().Result;
                spolovi.Insert(0, new Spol());
                spolList.DataSource = spolovi;
                spolList.DisplayMember = "Naziv";
                spolList.ValueMember = "SpolId";

            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Kandidati k = new Kandidati();

            if (this.ValidateChildren())
            {

                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Adresa = adresaInput.Text;
                k.Telefon = telefonInput.Text;
                k.Email = emailInput.Text;
                k.SpolId = Convert.ToInt32(spolList.SelectedValue);
                k.DatumRodjenja = datumRodjenja.Value;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = Util.UIHelper.GenerateSalt();
                k.LozinkaHash = Util.UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.Napomena = napomenaInput.Text;
                k.DatumRegistracije = DateTime.Now;

                if (statusCbx.Checked)
                {
                    k.Status = true;
                }
                else
                    k.Status = false;

                HttpResponseMessage response = kandidatService.PostActionResponse("CustomPostKandidati", k);
                if (response.IsSuccessStatusCode)
                {
                    //MessageBox.Show(Messages.add_kandidat_succ);
                    // HttpResponseMessage responseMessage = kandidatService.GetActionResponse("GetByUsername", korisnickoImeInput.Text);
                    Kandidati kan = response.Content.ReadAsAsync<Kandidati>().Result;
                    Upis.UpisujeIndexForm f = new Upis.UpisujeIndexForm(kan.KandidatId);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
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

            if (String.IsNullOrEmpty(lozinkaInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_req);
            }
            else if (lozinkaInput.TextLength < 6)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.pass_err);
            }
            else
            {
                errorProvider.SetError(lozinkaInput, null);
            }


            //var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            //var hasMiniMaxChars = new Regex(@".{8,15}");
            //var hasLowerChar = new Regex(@"[a-z]+");
            //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            //else  if (!hasNumber.IsMatch(lozinkaInput.Text))
            // {

            //     e.Cancel = true;
            //     errorProvider.SetError(lozinkaInput, "Lozinka mora sadržavati brojeve");
            // }
            // else if (!hasUpperChar.IsMatch(lozinkaInput.Text))
            // {
            //     e.Cancel = true;
            //     errorProvider.SetError(lozinkaInput, "Lozinka mora sadržavati velika slova");
            // }
            // else if (!hasMiniMaxChars.IsMatch(lozinkaInput.Text))
            // {
            //     e.Cancel = true;
            //     errorProvider.SetError(lozinkaInput, "Lozinka mora biti u rasponu od 8 do 15");
            // }
            // else if (!hasLowerChar.IsMatch(lozinkaInput.Text))
            // {
            //     e.Cancel = true;
            //     errorProvider.SetError(lozinkaInput, "Lozinka mora sadržavati mala slova");
            // }
            // else if (!hasSymbols.IsMatch(lozinkaInput.Text))
            // {
            //     e.Cancel = true;
            //     errorProvider.SetError(lozinkaInput, "Lozinka mora sadržavati znakove");
            // }
            // else
            // {
            //     e.Cancel = false;
            //     errorProvider.SetError(lozinkaInput, null);

            // }
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

        private void spolList_Validating(object sender, CancelEventArgs e)
        {

            if (spolList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(spolList, Messages.spol_req);

            }
            else
                errorProvider.SetError(spolList, null);

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KandidatAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
     
        }

        private void KandidatAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
