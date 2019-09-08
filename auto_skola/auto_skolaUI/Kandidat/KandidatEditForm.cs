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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI.Kandidat
{
    public partial class KandidatEditForm : Form
    {
        Kandidati k { get; set; }
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper spolService = new WebAPIHelper("http://localhost:55368", "api/Spol");

        public KandidatEditForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = kandidatiService.GetResponse(id.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                k = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Kandidati>().Result;
                if (k.SpolId != null)
                {
                    bindSpol();
                }
                else
                {
                    bindSpolNew();
                }

                FillForm();
            }
 
        }

        private void bindSpolNew()
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

        private void bindSpol()
        {
            HttpResponseMessage response = spolService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Spol> spolovi = response.Content.ReadAsAsync<List<Spol>>().Result;
                spolovi.Insert(0,  spolovi.Where(x=>x.SpolId==k.SpolId).SingleOrDefault());
                spolList.DataSource = spolovi;
                spolList.DisplayMember = "Naziv";
                spolList.ValueMember = "SpolId";

            }
        }

        private void FillForm()
        {
            imeInput.Text= k.Ime ;
            prezimeInput.Text= k.Prezime ;
            adresaInput.Text= k.Adresa ;
            datumRodjenja.Value = k.DatumRodjenja;
            telefonInput.Text = k.Telefon ;
            emailInput.Text= k.Email ;
            korisnickoImeInput.Text= k.KorisnickoIme;
            k.Napomena = napomenaInput.Text;
            if (k.Status==true)
             statusCbx.Checked = true;
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (k != null)
                {
                    k.Ime = imeInput.Text;
                    k.Prezime = prezimeInput.Text;
                    k.Adresa = adresaInput.Text;
                    k.Email = emailInput.Text;
                    k.SpolId = Convert.ToInt32(spolList.SelectedValue);
                    k.DatumRodjenja = datumRodjenja.Value;
                    k.Telefon = telefonInput.Text;
                    k.KorisnickoIme = korisnickoImeInput.Text;
                    if (lozinkaInput.Text != String.Empty)
                    {
                        k.LozinkaSalt = UIHelper.GenerateSalt();
                        k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                    }
                    k.Napomena = napomenaInput.Text;
                    if (statusCbx.Checked)
                        k.Status = true;
                    else
                        k.Status = false;
                }
                HttpResponseMessage response = kandidatiService.PutResponse(k.KandidatId, k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_user_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error code", response.StatusCode + " Message: " + response.ReasonPhrase);
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

        private void spolList_Validating(object sender, CancelEventArgs e)
        {
            if (k.SpolId == null)
            {
                if (spolList.SelectedIndex == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(spolList, Messages.spol_req);

                }
                else
                    errorProvider.SetError(spolList, null);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
