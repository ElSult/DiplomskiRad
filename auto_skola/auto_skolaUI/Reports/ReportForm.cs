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
    public partial class ReportForm : Form
    {
        public WebAPIHelper rezultatService = new WebAPIHelper("http://localhost:55368", "api/Rezultat");
        public WebAPIHelper testService = new WebAPIHelper("http://localhost:55368", "api/Test");
        public WebAPIHelper kandidatiService = new WebAPIHelper("http://localhost:55368", "api/Kandidati");

        public ReportForm()
        {
            InitializeComponent();
            BindTestoviList();
            BindKandidatiList();
        }

        private void BindKandidatiList()
        {
            HttpResponseMessage response = kandidatiService.GetActionResponse("GetKandidatImePrezime");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Kandidati_SpojenoImePrezime_Result> kandidati = response.Content.ReadAsAsync<List<asp_Kandidati_SpojenoImePrezime_Result>>().Result;
                kandidati.Insert(0, new asp_Kandidati_SpojenoImePrezime_Result());
                kandidatList.DataSource = kandidati;
                kandidatList.DisplayMember = "ImePrezime";

                kandidatList.ValueMember = "KandidatId";
            }
        }

        private void BindTestoviList()
        {
            HttpResponseMessage response = testService.GetResponseAction("GetTestPodkategorija");
            if (response.IsSuccessStatusCode)
            {
                List<asp_Test_NazivPodkategorija_Result> tests = response.Content.ReadAsAsync<List<asp_Test_NazivPodkategorija_Result>>().Result;
                tests.Insert(0, new asp_Test_NazivPodkategorija_Result());
                testoviList.DataSource = tests;
                testoviList.DisplayMember = "Naziv";
                testoviList.ValueMember = "TestId";
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            
            
            int testId = Convert.ToInt32(testoviList.SelectedValue);
            int kandidatId = Convert.ToInt32(kandidatList.SelectedValue);
            if (testId == 0 && kandidatId==0)
            {
                this.reportViewer1.LocalReport.DataSources.Clear();

                 HttpResponseMessage response = rezultatService.GetActionResponse("GetReport", odDtp.Value.ToString("yyyy-MM-dd") + "/" + DoDtp.Value.ToString("yyyy-MM-dd") + "/NULL" + "/NULL");

                List <asp_report_Result> rezultati = response.Content.ReadAsAsync<List<asp_report_Result>>().Result;

                ReportDataSource rds = new ReportDataSource("RezultatiTestova", rezultati);
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                this.reportViewer1.RefreshReport();
            }
            else if(testId!=0 && kandidatId == 0)
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                string testID = testId.ToString();
                 HttpResponseMessage response = rezultatService.GetActionResponse("GetReport", odDtp.Value.ToString("yyyy-MM-dd") + "/" + DoDtp.Value.ToString("yyyy-MM-dd") + "/" + testID+ "/NULL");

                List<asp_report_Result> rezultati = response.Content.ReadAsAsync<List<asp_report_Result>>().Result;

                ReportDataSource rds = new ReportDataSource("RezultatiTestova", rezultati);
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                this.reportViewer1.RefreshReport();
            }
            else if(kandidatId!=0 && testId==0)
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                string kandidatID = kandidatId.ToString();
                string testID = testId.ToString();
                HttpResponseMessage response = rezultatService.GetActionResponse("GetReport", odDtp.Value.ToString("yyyy-MM-dd") + "/" + DoDtp.Value.ToString("yyyy-MM-dd") + "/NULL"+"/"+kandidatID);
                List<asp_report_Result> rezultati = response.Content.ReadAsAsync<List<asp_report_Result>>().Result;
                ReportDataSource rds = new ReportDataSource("RezultatiTestova", rezultati);
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                string kandidatID = kandidatId.ToString();
                string testID = testId.ToString();
                HttpResponseMessage response = rezultatService.GetActionResponse("GetReport", odDtp.Value.ToString("yyyy-MM-dd") + "/" + DoDtp.Value.ToString("yyyy-MM-dd") + "/" + testID + "/" + kandidatID);
                List<asp_report_Result> rezultati = response.Content.ReadAsAsync<List<asp_report_Result>>().Result;
                ReportDataSource rds = new ReportDataSource("RezultatiTestova", rezultati);
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
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
