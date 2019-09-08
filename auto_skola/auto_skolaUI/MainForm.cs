using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI
{
    public partial class MainForm : Form
    {
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        public WebAPIHelper terminiService = new WebAPIHelper("http://localhost:55368", "api/Termin");

        public MainForm()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.DarkGray;
                }
            }

            notifyIcon.Icon = this.Icon;
        }


        private void KorisniciButton_Click(object sender, EventArgs e)
        {
            IndexForm f = new IndexForm();
            f.ShowDialog();
        }
        
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadBrojNovihKandidata();

            await RefreshDetalji();

            UpdateDatumPrijave();

            RefreshAdminMenu();

        }

        private void UpdateDatumPrijave()
        {
            if (Global.prijavljeniKorisnik != null)
            {
                Global.prijavljeniKorisnik.DatumPrijave = DateTime.Now;
                HttpResponseMessage responsePut = korisniciService.PutResponse(Global.prijavljeniKorisnik.KorisnikId, Global.prijavljeniKorisnik);
            }
        }

        private async Task LoadBrojNovihKandidata()
        {
            HttpResponseMessage response = await kandidatiService.GetActionResponseAsync("GetBrojNovihKandidata", Global.prijavljeniKorisnik.KorisnikId);
            if (response.IsSuccessStatusCode)
            {
                int brKorisnika = response.Content.ReadAsAsync<int>().Result;

                if (brKorisnika > 0)
                {
                    notifyIcon.ShowBalloonTip(4000, "Novi korisnici", "Broj korisnika: " + brKorisnika, ToolTipIcon.Info);
                }
            }
        }

        private async Task RefreshDetalji()
        {
            HttpResponseMessage response1 = await kandidatiService.GetActionResponseAsync("GetBrojKandidata");
            if (response1.IsSuccessStatusCode)
            {
                int brKandidata = response1.Content.ReadAsAsync<int>().Result;
                lblBrojKandidata.Text = brKandidata.ToString();
            }

            if(Global.prijavljeniKorisnik != null)
            {
                lblDobrodosli.Text = "Dobrodošli, " + Global.prijavljeniKorisnik.Ime + "!";

                HttpResponseMessage response2 = await terminiService.GetActionResponseAsync("GetIduciTermin", Global.prijavljeniKorisnik.KorisnikId);
                if (response2.IsSuccessStatusCode)
                {
                    var termin = response2.Content.ReadAsAsync<asp_Termin_SelectAll_Result>().Result;

                    string datum = termin.Datum.ToShortDateString();
                    if (termin.Datum == DateTime.Now.Date)
                        datum = "Danas u";
                    else if (termin.Datum == DateTime.Now.Date.AddDays(1))
                        datum = "Sutra u";

                    string vrijeme = termin.Vrijeme.Substring(0, 5);

                    lblSljedecaVoznjaDatum.Text = datum + " " + vrijeme + " (" + termin.ImePrezimeKa + ")";
                }
            }
        }

        private void RefreshAdminMenu()
        {
            bool IsAdmin = false;
            if (Global.prijavljeniKorisnik?.Uloge != null)
            {
                foreach (var uloga in Global.prijavljeniKorisnik.Uloge)
                {
                    if (uloga.Naziv == "Administrator")
                        IsAdmin = true;
                }
            }
            btnKorisnici.Visible = IsAdmin;
            btnProperties.Visible = IsAdmin;
            btnRezultati.Enabled = !IsAdmin;
            button1.Enabled = !IsAdmin;
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Kandidat.KandidatIndexForm frm = new Kandidat.KandidatIndexForm();

            frm.ShowDialog();
        }
        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Global.prijavljeniKorisnik = null;
            Close();
        }
        
        private async void btnLogout_Click(object sender, EventArgs e)
        {
            Global.prijavljeniKorisnik = null;

            LoginForm login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                await LoadBrojNovihKandidata();

                await RefreshDetalji();

                UpdateDatumPrijave();

                RefreshAdminMenu();
            }
        }
 
        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            var frm = new Instruktori.InstruktorProfilForm();
            frm.ShowDialog();
        }

        private void btnKorisnici1_Click(object sender, EventArgs e)
        {
            var frm = new IndexForm();
            frm.ShowDialog();
        }

        private void btnKandidati_Click(object sender, EventArgs e)
        {
            var frm = new Kandidat.KandidatIndexForm();
            frm.ShowDialog();
        }

        private void btnUplata_Click(object sender, EventArgs e)
        {
            var frm = new Upis.UpisujeIndexForm();
            frm.ShowDialog();
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            var frm = new Termini.TerminAddForm();
            frm.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var frm = new Tests.TestIndexForm();
            frm.ShowDialog();
        }

        private void btnPitanja_Click(object sender, EventArgs e)
        {
            var frm = new Tests.PitanjeIndexForm();
            frm.ShowDialog();
        }

        private void btnRezultati_Click(object sender, EventArgs e)
        {
            Reports.ReportForm frm = new Reports.ReportForm();
            frm.ShowDialog();
        }

        private void btnMojProfil_MouseEnter(object sender, EventArgs e)
        {
            btnMojProfil.FlatStyle = FlatStyle.Popup;
            btnMojProfil.BackColor = Color.FromArgb(47, 50, 49);
            //btnMojProfil.Image = Properties.Resources.user_aktivno;
        }

        private void btnMojProfil_MouseLeave(object sender, EventArgs e)
        {
            btnMojProfil.FlatStyle = FlatStyle.Flat;
            btnMojProfil.BackColor = Color.FromArgb(30, 32, 31);
            //btnMojProfil.Image = Properties.Resources.user;
        }

        private void btnKorisnici_MouseEnter(object sender, EventArgs e)
        {
            btnKorisnici.FlatStyle = FlatStyle.Popup;
            btnKorisnici.BackColor = Color.FromArgb(47, 50, 49);
            //btnKorisnici.Image = Properties.Resources.users_aktivno;
        }

        private void btnKorisnici_MouseLeave(object sender, EventArgs e)
        {
            btnKorisnici.FlatStyle = FlatStyle.Flat;
            btnKorisnici.BackColor = Color.FromArgb(30, 32, 31);
            //btnKorisnici.Image = Properties.Resources.users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.Report_KNN_Form frm = new Reports.Report_KNN_Form();
            frm.ShowDialog();
        }

        private void evidencijaVoznjeButton_Click(object sender, EventArgs e)
        {
            var frm = new VozackiIspit1.EvidencijaForm();
            frm.ShowDialog();
        }

        private void btnProperties_MouseEnter(object sender, EventArgs e)
        {
            btnProperties.FlatStyle = FlatStyle.Popup;
            btnProperties.BackColor = Color.FromArgb(47, 50, 49);
        }

        private void btnProperties_MouseLeave(object sender, EventArgs e)
        {
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.BackColor = Color.FromArgb(30, 32, 31);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            var frm = new Postavke.postavkeIndexForm();
            frm.ShowDialog();
        }
    }
}
