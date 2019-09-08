using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using Microsoft.Reporting.Map.WebForms.BingMaps;
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

namespace auto_skolaUI.Instruktori
{
    public partial class RejtingInstruktora : Form
    {
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");
        //public WebAPIHelper korisnikService = new WebAPIHelper("http://localhost:55368", "api/Korisnici");

        public RejtingInstruktora()
        {
            InitializeComponent();
        }

        private void RejtingInstruktora_Load(object sender, EventArgs e)
        {
          BindInstruktori();
        }

        private void BindInstruktori()
        {
           // string str="";
            HttpResponseMessage response = korisniciService.GetResponseA("GetRejting");
            if (response.IsSuccessStatusCode)
            {
                List<asp_rejting_korisnika_Result> instruktori = response.Content.ReadAsAsync<List<asp_rejting_korisnika_Result>>().Result;
                instruktoriList.DataSource = instruktori;
            }
        }
    }
}
