namespace auto_skolaUI.Kandidat
{
    partial class KandidatIndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KandidatIndexForm));
            this.kandidatGridView = new System.Windows.Forms.DataGridView();
            this.KandidatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOdrzanihUplacenihCasova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ZadnjeUplaceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TraziButton = new System.Windows.Forms.Button();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.dodajKandidataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kandidatGridView
            // 
            this.kandidatGridView.AllowUserToAddRows = false;
            this.kandidatGridView.AllowUserToDeleteRows = false;
            this.kandidatGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kandidatGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.kandidatGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kandidatGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kandidatGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kandidatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kandidatGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KandidatId,
            this.ImePrezime,
            this.Adresa,
            this.Telefon,
            this.Email,
            this.DatumRegistracije,
            this.BrojOdrzanihUplacenihCasova,
            this.Status,
            this.ZadnjeUplaceno});
            this.kandidatGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.kandidatGridView.Location = new System.Drawing.Point(29, 133);
            this.kandidatGridView.Margin = new System.Windows.Forms.Padding(4);
            this.kandidatGridView.MultiSelect = false;
            this.kandidatGridView.Name = "kandidatGridView";
            this.kandidatGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kandidatGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.kandidatGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kandidatGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.kandidatGridView.RowTemplate.Height = 24;
            this.kandidatGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kandidatGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kandidatGridView.Size = new System.Drawing.Size(1221, 397);
            this.kandidatGridView.TabIndex = 12;
            this.kandidatGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.kandidatGridView_MouseDoubleClick);
            // 
            // KandidatId
            // 
            this.KandidatId.DataPropertyName = "KandidatId";
            this.KandidatId.HeaderText = "KandidatId";
            this.KandidatId.Name = "KandidatId";
            this.KandidatId.ReadOnly = true;
            this.KandidatId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.FillWeight = 90.50179F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.FillWeight = 90.50179F;
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.FillWeight = 90.50179F;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 151.4055F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DatumRegistracije
            // 
            this.DatumRegistracije.DataPropertyName = "DatumRegistracije";
            this.DatumRegistracije.FillWeight = 105.5837F;
            this.DatumRegistracije.HeaderText = "Datum registracije";
            this.DatumRegistracije.Name = "DatumRegistracije";
            this.DatumRegistracije.ReadOnly = true;
            // 
            // BrojOdrzanihUplacenihCasova
            // 
            this.BrojOdrzanihUplacenihCasova.DataPropertyName = "BrojOdrzanihUplacenihCasova";
            this.BrojOdrzanihUplacenihCasova.FillWeight = 90.50179F;
            this.BrojOdrzanihUplacenihCasova.HeaderText = "Odrzano / Uplaceno";
            this.BrojOdrzanihUplacenihCasova.Name = "BrojOdrzanihUplacenihCasova";
            this.BrojOdrzanihUplacenihCasova.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FalseValue = "0";
            this.Status.FillWeight = 90.50179F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.TrueValue = "1";
            // 
            // ZadnjeUplaceno
            // 
            this.ZadnjeUplaceno.DataPropertyName = "Zadnje_uplaceno";
            this.ZadnjeUplaceno.FillWeight = 90.50179F;
            this.ZadnjeUplaceno.HeaderText = "Zadnje uplaceno";
            this.ZadnjeUplaceno.Name = "ZadnjeUplaceno";
            this.ZadnjeUplaceno.ReadOnly = true;
            // 
            // imePrezimelbl
            // 
            this.imePrezimelbl.AutoSize = true;
            this.imePrezimelbl.Location = new System.Drawing.Point(-144, 99);
            this.imePrezimelbl.Name = "imePrezimelbl";
            this.imePrezimelbl.Size = new System.Drawing.Size(95, 17);
            this.imePrezimelbl.TabIndex = 10;
            this.imePrezimelbl.Text = "Ime i prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime i prezime:";
            // 
            // TraziButton
            // 
            this.TraziButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.TraziButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraziButton.ForeColor = System.Drawing.Color.White;
            this.TraziButton.Image = ((System.Drawing.Image)(resources.GetObject("TraziButton.Image")));
            this.TraziButton.Location = new System.Drawing.Point(390, 65);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(46, 28);
            this.TraziButton.TabIndex = 17;
            this.TraziButton.UseVisualStyleBackColor = false;
            this.TraziButton.Click += new System.EventHandler(this.TraziButton_Click);
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.imePrezimeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imePrezimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imePrezimeInput.ForeColor = System.Drawing.Color.White;
            this.imePrezimeInput.Location = new System.Drawing.Point(8, 8);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(240, 15);
            this.imePrezimeInput.TabIndex = 16;
            this.imePrezimeInput.TextChanged += new System.EventHandler(this.imePrezimeInput_TextChanged);
            this.imePrezimeInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.imePrezimeInput_KeyUp);
            // 
            // dodajKandidataButton
            // 
            this.dodajKandidataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajKandidataButton.FlatAppearance.BorderSize = 0;
            this.dodajKandidataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajKandidataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajKandidataButton.Location = new System.Drawing.Point(1107, 73);
            this.dodajKandidataButton.Name = "dodajKandidataButton";
            this.dodajKandidataButton.Size = new System.Drawing.Size(143, 28);
            this.dodajKandidataButton.TabIndex = 14;
            this.dodajKandidataButton.Text = "Dodaj kandidata";
            this.dodajKandidataButton.UseVisualStyleBackColor = false;
            this.dodajKandidataButton.Click += new System.EventHandler(this.dodajKandidataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "*Duplim klikom na kandidata iz tabele otvara se forma za uređivanje";
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(1237, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 21;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 52);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kandidati";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.imePrezimeInput);
            this.panel1.Location = new System.Drawing.Point(132, 65);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(252, 28);
            this.panel1.TabIndex = 29;
            // 
            // KandidatIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1283, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.dodajKandidataButton);
            this.Controls.Add(this.kandidatGridView);
            this.Controls.Add(this.imePrezimelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KandidatIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kandidati";
            this.Load += new System.EventHandler(this.KandidatIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kandidatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kandidatGridView;
        private System.Windows.Forms.Label imePrezimelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Button dodajKandidataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn KandidatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOdrzanihUplacenihCasova;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZadnjeUplaceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}