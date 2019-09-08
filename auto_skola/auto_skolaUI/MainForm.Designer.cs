using System.Drawing;
using System.Windows.Forms;

namespace auto_skolaUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.closeForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPitanja = new System.Windows.Forms.Button();
            this.btnKandidati = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnUplata = new System.Windows.Forms.Button();
            this.btnTermin = new System.Windows.Forms.Button();
            this.btnRezultati = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblSljedecaVoznja = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBrojKandidata = new System.Windows.Forms.Label();
            this.lblSljedecaVoznjaDatum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.evidencijaVoznjeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnMojProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            // 
            // closeForm
            // 
            this.closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeForm.AutoSize = true;
            this.closeForm.BackColor = System.Drawing.Color.Transparent;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(2037, 4);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 22;
            this.closeForm.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 64);
            this.label1.TabIndex = 26;
            this.label1.Text = "AutoŠkola \"DINO\"";
            // 
            // btnPitanja
            // 
            this.btnPitanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPitanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnPitanja.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPitanja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPitanja.FlatAppearance.BorderSize = 5;
            this.btnPitanja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPitanja.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPitanja.ForeColor = System.Drawing.Color.White;
            this.btnPitanja.Location = new System.Drawing.Point(1060, 443);
            this.btnPitanja.Name = "btnPitanja";
            this.btnPitanja.Size = new System.Drawing.Size(354, 66);
            this.btnPitanja.TabIndex = 5;
            this.btnPitanja.Text = "Pitanja";
            this.btnPitanja.UseVisualStyleBackColor = false;
            this.btnPitanja.Click += new System.EventHandler(this.btnPitanja_Click);
            // 
            // btnKandidati
            // 
            this.btnKandidati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKandidati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnKandidati.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKandidati.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKandidati.FlatAppearance.BorderSize = 5;
            this.btnKandidati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKandidati.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKandidati.ForeColor = System.Drawing.Color.White;
            this.btnKandidati.Location = new System.Drawing.Point(188, 335);
            this.btnKandidati.Name = "btnKandidati";
            this.btnKandidati.Size = new System.Drawing.Size(354, 66);
            this.btnKandidati.TabIndex = 1;
            this.btnKandidati.Text = "Kandidati";
            this.btnKandidati.UseVisualStyleBackColor = false;
            this.btnKandidati.Click += new System.EventHandler(this.btnKandidati_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTest.FlatAppearance.BorderSize = 5;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTest.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(1060, 335);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(354, 66);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnUplata
            // 
            this.btnUplata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUplata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnUplata.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUplata.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUplata.FlatAppearance.BorderSize = 5;
            this.btnUplata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUplata.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUplata.ForeColor = System.Drawing.Color.White;
            this.btnUplata.Location = new System.Drawing.Point(188, 443);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(354, 66);
            this.btnUplata.TabIndex = 2;
            this.btnUplata.Text = "Uplata";
            this.btnUplata.UseVisualStyleBackColor = false;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // btnTermin
            // 
            this.btnTermin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnTermin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTermin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTermin.FlatAppearance.BorderSize = 5;
            this.btnTermin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTermin.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermin.ForeColor = System.Drawing.Color.White;
            this.btnTermin.Location = new System.Drawing.Point(188, 549);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(354, 66);
            this.btnTermin.TabIndex = 3;
            this.btnTermin.Text = "Termini";
            this.btnTermin.UseVisualStyleBackColor = false;
            this.btnTermin.Click += new System.EventHandler(this.btnTermin_Click);
            // 
            // btnRezultati
            // 
            this.btnRezultati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRezultati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnRezultati.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRezultati.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRezultati.FlatAppearance.BorderSize = 5;
            this.btnRezultati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRezultati.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezultati.ForeColor = System.Drawing.Color.White;
            this.btnRezultati.Location = new System.Drawing.Point(627, 392);
            this.btnRezultati.Name = "btnRezultati";
            this.btnRezultati.Size = new System.Drawing.Size(354, 66);
            this.btnRezultati.TabIndex = 6;
            this.btnRezultati.Text = "Rezultati testova";
            this.btnRezultati.UseVisualStyleBackColor = false;
            this.btnRezultati.Click += new System.EventHandler(this.btnRezultati_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btnProperties);
            this.panel1.Controls.Add(this.btnKorisnici);
            this.panel1.Controls.Add(this.btnMojProfil);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 836);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "Evidencija kandidata";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1083, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 46);
            this.label3.TabIndex = 30;
            this.label3.Text = "Evidencija testova";
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.BackColor = System.Drawing.Color.Transparent;
            this.lblDobrodosli.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDobrodosli.ForeColor = System.Drawing.Color.White;
            this.lblDobrodosli.Location = new System.Drawing.Point(1127, 21);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(159, 37);
            this.lblDobrodosli.TabIndex = 31;
            this.lblDobrodosli.Text = "Dobrodošli";
            // 
            // lblSljedecaVoznja
            // 
            this.lblSljedecaVoznja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSljedecaVoznja.AutoSize = true;
            this.lblSljedecaVoznja.BackColor = System.Drawing.Color.Transparent;
            this.lblSljedecaVoznja.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSljedecaVoznja.ForeColor = System.Drawing.Color.White;
            this.lblSljedecaVoznja.Location = new System.Drawing.Point(31, 17);
            this.lblSljedecaVoznja.Name = "lblSljedecaVoznja";
            this.lblSljedecaVoznja.Size = new System.Drawing.Size(207, 35);
            this.lblSljedecaVoznja.TabIndex = 32;
            this.lblSljedecaVoznja.Text = "Sljedeća vožnja: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lblBrojKandidata);
            this.panel2.Controls.Add(this.lblSljedecaVoznjaDatum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSljedecaVoznja);
            this.panel2.Location = new System.Drawing.Point(278, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 183);
            this.panel2.TabIndex = 33;
            // 
            // lblBrojKandidata
            // 
            this.lblBrojKandidata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrojKandidata.AutoSize = true;
            this.lblBrojKandidata.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojKandidata.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojKandidata.ForeColor = System.Drawing.Color.White;
            this.lblBrojKandidata.Location = new System.Drawing.Point(234, 62);
            this.lblBrojKandidata.Name = "lblBrojKandidata";
            this.lblBrojKandidata.Size = new System.Drawing.Size(22, 35);
            this.lblBrojKandidata.TabIndex = 35;
            this.lblBrojKandidata.Text = "-";
            // 
            // lblSljedecaVoznjaDatum
            // 
            this.lblSljedecaVoznjaDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSljedecaVoznjaDatum.AutoSize = true;
            this.lblSljedecaVoznjaDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblSljedecaVoznjaDatum.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSljedecaVoznjaDatum.ForeColor = System.Drawing.Color.White;
            this.lblSljedecaVoznjaDatum.Location = new System.Drawing.Point(234, 21);
            this.lblSljedecaVoznjaDatum.Name = "lblSljedecaVoznjaDatum";
            this.lblSljedecaVoznjaDatum.Size = new System.Drawing.Size(22, 35);
            this.lblSljedecaVoznjaDatum.TabIndex = 34;
            this.lblSljedecaVoznjaDatum.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 35);
            this.label4.TabIndex = 33;
            this.label4.Text = "Broj kandidata:";
            // 
            // evidencijaVoznjeButton
            // 
            this.evidencijaVoznjeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.evidencijaVoznjeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.evidencijaVoznjeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.evidencijaVoznjeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.evidencijaVoznjeButton.FlatAppearance.BorderSize = 5;
            this.evidencijaVoznjeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.evidencijaVoznjeButton.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.evidencijaVoznjeButton.ForeColor = System.Drawing.Color.White;
            this.evidencijaVoznjeButton.Location = new System.Drawing.Point(1060, 549);
            this.evidencijaVoznjeButton.Name = "evidencijaVoznjeButton";
            this.evidencijaVoznjeButton.Size = new System.Drawing.Size(354, 66);
            this.evidencijaVoznjeButton.TabIndex = 36;
            this.evidencijaVoznjeButton.Text = "Ispiti";
            this.evidencijaVoznjeButton.UseVisualStyleBackColor = false;
            this.evidencijaVoznjeButton.Click += new System.EventHandler(this.evidencijaVoznjeButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(627, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 66);
            this.button1.TabIndex = 35;
            this.button1.Text = "Broj izlazaka";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1484, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(714, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 46);
            this.label6.TabIndex = 37;
            this.label6.Text = "Izvještaji";
            // 
            // btnProperties
            // 
            this.btnProperties.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProperties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProperties.FlatAppearance.BorderSize = 0;
            this.btnProperties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProperties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperties.ForeColor = System.Drawing.Color.Transparent;
            this.btnProperties.Image = global::auto_skolaUI.Properties.Resources.settings;
            this.btnProperties.Location = new System.Drawing.Point(0, 288);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(103, 85);
            this.btnProperties.TabIndex = 28;
            this.btnProperties.TabStop = false;
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            this.btnProperties.MouseEnter += new System.EventHandler(this.btnProperties_MouseEnter);
            this.btnProperties.MouseLeave += new System.EventHandler(this.btnProperties_MouseLeave);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKorisnici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKorisnici.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKorisnici.FlatAppearance.BorderSize = 0;
            this.btnKorisnici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKorisnici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.ForeColor = System.Drawing.Color.Transparent;
            this.btnKorisnici.Image = global::auto_skolaUI.Properties.Resources.users;
            this.btnKorisnici.Location = new System.Drawing.Point(0, 197);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(103, 85);
            this.btnKorisnici.TabIndex = 0;
            this.btnKorisnici.TabStop = false;
            this.btnKorisnici.UseVisualStyleBackColor = false;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici1_Click);
            this.btnKorisnici.MouseEnter += new System.EventHandler(this.btnKorisnici_MouseEnter);
            this.btnKorisnici.MouseLeave += new System.EventHandler(this.btnKorisnici_MouseLeave);
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnMojProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMojProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMojProfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMojProfil.FlatAppearance.BorderSize = 0;
            this.btnMojProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMojProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMojProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojProfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnMojProfil.Image = global::auto_skolaUI.Properties.Resources.user;
            this.btnMojProfil.Location = new System.Drawing.Point(0, 105);
            this.btnMojProfil.Name = "btnMojProfil";
            this.btnMojProfil.Size = new System.Drawing.Size(103, 85);
            this.btnMojProfil.TabIndex = 0;
            this.btnMojProfil.TabStop = false;
            this.btnMojProfil.UseVisualStyleBackColor = false;
            this.btnMojProfil.Click += new System.EventHandler(this.btnMojProfil_Click);
            this.btnMojProfil.MouseEnter += new System.EventHandler(this.btnMojProfil_MouseEnter);
            this.btnMojProfil.MouseLeave += new System.EventHandler(this.btnMojProfil_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(28, 728);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TabStop = false;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 86);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1505, 836);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.evidencijaVoznjeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezultati);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.btnUplata);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnKandidati);
            this.Controls.Add(this.btnPitanja);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "autoSkola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPitanja;
        private System.Windows.Forms.Button btnKandidati;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.Button btnRezultati;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMojProfil;
        private Button btnLogout;
        private Button btnKorisnici;
        private Label label2;
        private Label label3;
        private Label lblDobrodosli;
        private Label lblSljedecaVoznja;
        private Panel panel2;
        private Label lblBrojKandidata;
        private Label lblSljedecaVoznjaDatum;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button evidencijaVoznjeButton;
        private Label label6;
        private Button btnProperties;
    }
}