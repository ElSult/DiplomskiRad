using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using Microsoft.Reporting.WinForms;
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

namespace auto_skolaUI.Reports
{
    public partial class Report_KNN_Form : Form
    {
        public WebAPIHelper rezultatService = new WebAPIHelper("http://localhost:55368", "api/Rezultat");
        public WebAPIHelper testService = new WebAPIHelper("http://localhost:55368", "api/Test");
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");

        public Report_KNN_Form()
        {
            InitializeComponent();
            BindKandidatiList();
        }

        private void BindKandidatiList()
        {
            HttpResponseMessage response = kandidatiService.GetActionResponse("GetNepolozeniKandidati");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Podaci_Za_KNN_Result> kandidati = response.Content.ReadAsAsync<List<asp_Podaci_Za_KNN_Result>>().Result;
                kandidati.Insert(0, new asp_Podaci_Za_KNN_Result());
                kandidatList.DataSource = kandidati;
                kandidatList.DisplayMember = "ImePrezime";

                kandidatList.ValueMember = "KandidatId";
            }
        }

        private void Report_KNN_Form_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            int kandidatId = Convert.ToInt32(kandidatList.SelectedValue);
            this.reportViewer1.LocalReport.DataSources.Clear();

            HttpResponseMessage response = kandidatiService.GetActionResponse("ReportKNN", kandidatId);

            List<asp_ReportKNN_Result> rezultati = response.Content.ReadAsAsync<List<asp_ReportKNN_Result>>().Result;

            ReportDataSource rds = new ReportDataSource("ReportKNN", rezultati);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
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
