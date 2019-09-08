namespace auto_skolaUI.Postavke
{
    partial class postavkeIndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(postavkeIndexForm));
            this.postavkeGridView = new System.Windows.Forms.DataGridView();
            this.IzborId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.DatumUpisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzmjene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.imeLbL = new System.Windows.Forms.Label();
            this.nazivStavkeInput = new System.Windows.Forms.TextBox();
            this.btn_OcistiFormu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postavkeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // postavkeGridView
            // 
            this.postavkeGridView.AllowUserToAddRows = false;
            this.postavkeGridView.AllowUserToDeleteRows = false;
            this.postavkeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postavkeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.postavkeGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.postavkeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.postavkeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavkeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IzborId,
            this.Naziv,
            this.Slika,
            this.DatumUpisa,
            this.DatumIzmjene,
            this.Korisnik});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.postavkeGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.postavkeGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.postavkeGridView.Location = new System.Drawing.Point(28, 462);
            this.postavkeGridView.Name = "postavkeGridView";
            this.postavkeGridView.ReadOnly = true;
            this.postavkeGridView.RowTemplate.Height = 24;
            this.postavkeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postavkeGridView.Size = new System.Drawing.Size(555, 185);
            this.postavkeGridView.TabIndex = 33;
            this.postavkeGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.postavkeGridView_MouseClick);
            this.postavkeGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.postavkeGridView_MouseDoubleClick);
            // 
            // IzborId
            // 
            this.IzborId.DataPropertyName = "IzborId";
            this.IzborId.HeaderText = "IzborId";
            this.IzborId.Name = "IzborId";
            this.IzborId.ReadOnly = true;
            this.IzborId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DatumUpisa
            // 
            this.DatumUpisa.DataPropertyName = "DatumUpisivanja";
            this.DatumUpisa.HeaderText = "Datum upisa";
            this.DatumUpisa.Name = "DatumUpisa";
            this.DatumUpisa.ReadOnly = true;
            // 
            // DatumIzmjene
            // 
            this.DatumIzmjene.DataPropertyName = "DatumIzmjene";
            this.DatumIzmjene.HeaderText = "Datum izmjene";
            this.DatumIzmjene.Name = "DatumIzmjene";
            this.DatumIzmjene.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(588, -6);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 46;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 52);
            this.label3.TabIndex = 44;
            this.label3.Text = "početna stranica";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajSlikuButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slikaInput);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.sacuvajButton);
            this.groupBox1.Controls.Add(this.imeLbL);
            this.groupBox1.Controls.Add(this.nazivStavkeInput);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(62, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 323);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova stavka";
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajSlikuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajSlikuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajSlikuButton.Location = new System.Drawing.Point(384, 60);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(75, 28);
            this.dodajSlikuButton.TabIndex = 46;
            this.dodajSlikuButton.Text = "Dodaj";
            this.dodajSlikuButton.UseVisualStyleBackColor = false;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Slika:";
            // 
            // slikaInput
            // 
            this.slikaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.slikaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slikaInput.ForeColor = System.Drawing.Color.White;
            this.slikaInput.Location = new System.Drawing.Point(111, 63);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(245, 22);
            this.slikaInput.TabIndex = 44;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(163, 105);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(134, 134);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 43;
            this.pictureBox.TabStop = false;
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(178, 261);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(100, 37);
            this.sacuvajButton.TabIndex = 42;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = false;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // imeLbL
            // 
            this.imeLbL.AutoSize = true;
            this.imeLbL.ForeColor = System.Drawing.Color.White;
            this.imeLbL.Location = new System.Drawing.Point(6, 25);
            this.imeLbL.Name = "imeLbL";
            this.imeLbL.Size = new System.Drawing.Size(92, 17);
            this.imeLbL.TabIndex = 40;
            this.imeLbL.Text = "Naziv stavke:";
            // 
            // nazivStavkeInput
            // 
            this.nazivStavkeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.nazivStavkeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nazivStavkeInput.ForeColor = System.Drawing.Color.White;
            this.nazivStavkeInput.Location = new System.Drawing.Point(111, 23);
            this.nazivStavkeInput.Name = "nazivStavkeInput";
            this.nazivStavkeInput.Size = new System.Drawing.Size(245, 22);
            this.nazivStavkeInput.TabIndex = 36;
            // 
            // btn_OcistiFormu
            // 
            this.btn_OcistiFormu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_OcistiFormu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OcistiFormu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_OcistiFormu.Location = new System.Drawing.Point(483, 404);
            this.btn_OcistiFormu.Name = "btn_OcistiFormu";
            this.btn_OcistiFormu.Size = new System.Drawing.Size(100, 37);
            this.btn_OcistiFormu.TabIndex = 49;
            this.btn_OcistiFormu.Text = "Očisti formu";
            this.btn_OcistiFormu.UseVisualStyleBackColor = false;
            this.btn_OcistiFormu.Click += new System.EventHandler(this.btn_OcistiFormu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "*Klikom na stavku iz tabele otvara se forma za uređivanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "*Duplim klikom na stavku iz tabele birše se stavka";
            // 
            // postavkeIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(615, 659);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_OcistiFormu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postavkeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "postavkeIndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "postavkeIndexForm";
            this.Load += new System.EventHandler(this.postavkeIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postavkeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView postavkeGridView;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzborId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUpisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzmjene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.Label imeLbL;
        private System.Windows.Forms.TextBox nazivStavkeInput;
        private System.Windows.Forms.Button btn_OcistiFormu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}