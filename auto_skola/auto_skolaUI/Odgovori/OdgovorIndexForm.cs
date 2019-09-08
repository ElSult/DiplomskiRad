using auto_skolaAPI.Models;
using auto_skolaUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI.Odgovori
{
    public partial class OdgovorIndexForm : Form
    {
        public WebAPIHelper pitanjeService = new WebAPIHelper("http://localhost:55368", "api/Pitanje");
        public WebAPIHelper odgovorService = new WebAPIHelper("http://localhost:55368", "api/Odgovor");
        public Odgovor o { get; set; }
        public bool VecPostoji;
        public OdgovorIndexForm(int pitanjeId, bool vecPostoji)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            o = new Odgovor();
            VecPostoji = vecPostoji;
            o.PitanjeId = pitanjeId;
            HttpResponseMessage response = pitanjeService.GetResponsee(pitanjeId);
            Pitanje p = response.Content.ReadAsAsync<Pitanje>().Result;
            pitanjeInput.Text = p.Pitanje1;

            if (p.SlikaThumb != null)
            {
                byte[] image = p.SlikaThumb;
                MemoryStream ms = new MemoryStream(image);
                Image i = Image.FromStream(ms);
                pictureBox.Image = i;
            }
            if (vecPostoji)
            {
                bindForm();
            }

        }
        public OdgovorIndexForm(int pitanjeId)
        {
            InitializeComponent();
            o = new Odgovor();
            o.PitanjeId = pitanjeId;
            HttpResponseMessage response = pitanjeService.GetResponsee(pitanjeId);
            Pitanje p = response.Content.ReadAsAsync<Pitanje>().Result;
            pitanjeInput.Text = p.Pitanje1;

            if (p.SlikaThumb != null)
            {
                byte[] image = p.SlikaThumb;
                MemoryStream ms = new MemoryStream(image);
                Image i = Image.FromStream(ms);
                pictureBox.Image = i;
            }
        }

        private void bindForm()
        {
            HttpResponseMessage response = odgovorService.GetActionResponse("GetOdgovoriByPitanjeId", o.PitanjeId);
            List<Odgovor> odgovori = response.Content.ReadAsAsync<List<Odgovor>>().Result;
            for (int i = 0; i < odgovori.Count; i++)
            {
                if (i == 0)
                {
                    odgovor1Input.Text = odgovori[i].Odgovor1;
                    if (odgovori[i].IsTacan == true)
                        IsTacan1Cbx.Checked = odgovori[i].IsTacan.HasValue;
                }

                else if (i == 1)
                {
                    odgovor2Input.Text = odgovori[i].Odgovor1;

                    if (odgovori[i].IsTacan == true)
                        IsTacan2Cbx.Checked = odgovori[i].IsTacan.HasValue;

                }
                else if (i == 2)
                {
                    odgovor3Input.Text = odgovori[i].Odgovor1;

                    if (odgovori[i].IsTacan == true)
                        IsTacan3Cbx.Checked = odgovori[i].IsTacan.HasValue;

                }
                else if (i == 3)
                {
                    odgovor4Input.Text = odgovori[i].Odgovor1;

                    if (odgovori[i].IsTacan == true)
                        IsTacan4Cbx.Checked = odgovori[i].IsTacan.HasValue;

                }
            }


        }

        private void OdgovorIndexForm_Load(object sender, EventArgs e)
        {
            if (!VecPostoji)
            {
                this.ControlBox = false;
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (IsTacan1Cbx.Checked == false && IsTacan2Cbx.Checked == false && IsTacan3Cbx.Checked == false)
                {
                    MessageBox.Show("Niste označili označili niti jedan odgovor kao tačan");
                }
                else {
                    List<Odgovor> odgovori = new List<Odgovor>();
                    if (VecPostoji)
                    {
                        HttpResponseMessage response = odgovorService.GetActionResponse("GetOdgovoriByPitanjeId", o.PitanjeId);
                        odgovori = response.Content.ReadAsAsync<List<Odgovor>>().Result;
                    }
                    try
                    {
                        if (!String.IsNullOrEmpty(odgovor1Input.Text))
                        {
                            o.Odgovor1 = odgovor1Input.Text;
                            o.IsTacan = IsTacan1Cbx.Checked;
                            if (VecPostoji)
                            {
                                o.OdgovorId = odgovori[0].OdgovorId;
                                HttpResponseMessage responsePut = odgovorService.PutResponse(odgovori[0].OdgovorId, o);
                            }
                            else
                            {

                                HttpResponseMessage response = odgovorService.PostResponse(o);
                            }
                        }
                        else
                        {
                            if (VecPostoji)
                            {
                                odgovorService.DeleteResponse(odgovori[0].OdgovorId);
                            }
                        }

                        if (!String.IsNullOrEmpty(odgovor2Input.Text))
                        {
                            o.Odgovor1 = odgovor2Input.Text;
                            o.IsTacan = IsTacan2Cbx.Checked;
                            if (VecPostoji && odgovori.Count >= 2)
                            {
                                o.OdgovorId = odgovori[1].OdgovorId;
                                HttpResponseMessage responsePut = odgovorService.PutResponse(odgovori[1].OdgovorId, o);
                            }
                            else
                            {

                                HttpResponseMessage response = odgovorService.PostResponse(o);
                            }
                        }
                        else
                        {
                            if (VecPostoji && odgovori.Count >= 2)
                            {
                                odgovorService.DeleteResponse(odgovori[1].OdgovorId);
                            }
                        }

                        if (!String.IsNullOrEmpty(odgovor3Input.Text))
                        {
                            o.Odgovor1 = odgovor3Input.Text;
                            o.IsTacan = IsTacan3Cbx.Checked;
                            if (VecPostoji && odgovori.Count >= 3)
                            {
                                o.OdgovorId = odgovori[2].OdgovorId;
                                HttpResponseMessage responsePut = odgovorService.PutResponse(odgovori[2].OdgovorId, o);
                            }
                            else
                            {

                                HttpResponseMessage response = odgovorService.PostResponse(o);
                            }
                        }
                        else
                        {
                            if (VecPostoji && odgovori.Count >= 3)
                            {
                                odgovorService.DeleteResponse(odgovori[2].OdgovorId);
                            }
                        }

                        if (!String.IsNullOrEmpty(odgovor4Input.Text))
                        {
                            o.Odgovor1 = odgovor4Input.Text;
                            o.IsTacan = IsTacan4Cbx.Checked;
                            if (VecPostoji && odgovori.Count >= 4)
                            {
                                o.OdgovorId = odgovori[3].OdgovorId;
                                HttpResponseMessage responsePut = odgovorService.PutResponse(odgovori[3].OdgovorId, o);
                            }
                            else
                            {

                                HttpResponseMessage response = odgovorService.PostResponse(o);
                            }
                        }
                        else
                        {
                            if (VecPostoji && odgovori.Count >= 4)
                            {
                                odgovorService.DeleteResponse(odgovori[3].OdgovorId);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška");
                    }
                    MessageBox.Show(Messages.add_odgovor_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }


        }

        private void odgovor1Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(odgovor1Input.Text))
            {

                e.Cancel = true;
                errorProvider.SetError(odgovor1Input, Messages.odgovor1_req);
                this.ControlBox = false;
            }
            else
            {
                errorProvider.SetError(odgovor1Input, null);
            }
        }

        private void odgovor2Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(odgovor2Input.Text))
            {

                e.Cancel = true;
                errorProvider.SetError(odgovor2Input, Messages.odgovor2_req);
                this.ControlBox = false;
            }
            else
            {
                errorProvider.SetError(odgovor2Input, null);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
