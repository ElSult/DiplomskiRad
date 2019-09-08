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

namespace auto_skolaUI
{
    public partial class LoginForm : Form
    {
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:55368", "api/Uloge");


        public LoginForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Prijava()
        {
         if (this.ValidateChildren()) {             
            HttpResponseMessage response = korisniciService.GetResponse(korisnickoImeInput.Text);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show(Messages.login_user_err, " Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (response.IsSuccessStatusCode)
            {
                asp_Korisnici_SelectByUsername_Result k = response.Content.ReadAsAsync<asp_Korisnici_SelectByUsername_Result>().Result;

                if (k.LozinkaHash == UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt))
                {
                    HttpResponseMessage response1 = ulogeService.GetActionResponse("GetUlogeByKorisnikId", k.KorisnikId);
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
                        Uloge = response1.Content.ReadAsAsync<List<Uloge>>().Result
                    };

                    //MessageBox.Show("Dobro dosli " + k.Ime+" "+k.Prezime);
                    DialogResult = DialogResult.OK;
                    Global.prijavljeniKorisnik = korisnik;
                    Close();
                }
                else
                {
                    MessageBox.Show(Messages.login_pass_err, " Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lozinkaInput.Text = String.Empty;
                }
            }
            
            else
                MessageBox.Show("Error Code:" + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
        private void prijavaButton_Click(object sender, EventArgs e)
        {
            Prijava();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.login_username_req);
            }
            else
            {
                errorProvider.SetError(korisnickoImeInput,null);

            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.login_pass_req);
            }
            else
            {
                errorProvider.SetError(lozinkaInput, null);
            }

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
