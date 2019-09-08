namespace auto_skolaUI.Termini
{
    partial class TerminAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminAddForm));
            this.terminiGridView = new System.Windows.Forms.DataGridView();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Automobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOdrzan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imePrezimelbl = new System.Windows.Forms.Label();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TraziButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.OznaciOdrzanBtn = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terminiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // terminiGridView
            // 
            this.terminiGridView.AllowUserToAddRows = false;
            this.terminiGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.terminiGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.terminiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.terminiGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.terminiGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.terminiGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.terminiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminId,
            this.ImePrezimeKo,
            this.ImePrezimeKa,
            this.Automobil,
            this.Datum,
            this.Vrijeme,
            this.Napomena,
            this.IsOdrzan});
            this.terminiGridView.Location = new System.Drawing.Point(29, 133);
            this.terminiGridView.MultiSelect = false;
            this.terminiGridView.Name = "terminiGridView";
            this.terminiGridView.ReadOnly = true;
            this.terminiGridView.RowTemplate.Height = 24;
            this.terminiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terminiGridView.Size = new System.Drawing.Size(1221, 397);
            this.terminiGridView.TabIndex = 11;
            this.terminiGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.terminiGridView_MouseDoubleClick);
            // 
            // TerminId
            // 
            this.TerminId.DataPropertyName = "TerminId";
            this.TerminId.HeaderText = "TerminId";
            this.TerminId.Name = "TerminId";
            this.TerminId.ReadOnly = true;
            this.TerminId.Visible = false;
            // 
            // ImePrezimeKo
            // 
            this.ImePrezimeKo.DataPropertyName = "ImePrezimeKo";
            this.ImePrezimeKo.HeaderText = "Instruktor";
            this.ImePrezimeKo.Name = "ImePrezimeKo";
            this.ImePrezimeKo.ReadOnly = true;
            // 
            // ImePrezimeKa
            // 
            this.ImePrezimeKa.DataPropertyName = "ImePrezimeKa";
            this.ImePrezimeKa.HeaderText = "Kandidat";
            this.ImePrezimeKa.Name = "ImePrezimeKa";
            this.ImePrezimeKa.ReadOnly = true;
            // 
            // Automobil
            // 
            this.Automobil.DataPropertyName = "Automobil";
            this.Automobil.HeaderText = "Automobil";
            this.Automobil.Name = "Automobil";
            this.Automobil.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // IsOdrzan
            // 
            this.IsOdrzan.DataPropertyName = "IsOdrzan";
            this.IsOdrzan.FalseValue = "0";
            this.IsOdrzan.HeaderText = "Termin održan";
            this.IsOdrzan.Name = "IsOdrzan";
            this.IsOdrzan.ReadOnly = true;
            this.IsOdrzan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsOdrzan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsOdrzan.TrueValue = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
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
            this.label3.Size = new System.Drawing.Size(210, 52);
            this.label3.TabIndex = 31;
            this.label3.Text = "Termini";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imePrezimelbl
            // 
            this.imePrezimelbl.AutoSize = true;
            this.imePrezimelbl.ForeColor = System.Drawing.Color.White;
            this.imePrezimelbl.Location = new System.Drawing.Point(26, 70);
            this.imePrezimelbl.Name = "imePrezimelbl";
            this.imePrezimelbl.Size = new System.Drawing.Size(172, 17);
            this.imePrezimelbl.TabIndex = 33;
            this.imePrezimelbl.Text = "Ime ili prezime instruktora:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.imePrezimeInput);
            this.panel1.Location = new System.Drawing.Point(204, 64);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(252, 28);
            this.panel1.TabIndex = 36;
            // 
            // TraziButton
            // 
            this.TraziButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.TraziButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraziButton.ForeColor = System.Drawing.Color.White;
            this.TraziButton.Image = ((System.Drawing.Image)(resources.GetObject("TraziButton.Image")));
            this.TraziButton.Location = new System.Drawing.Point(462, 64);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(46, 28);
            this.TraziButton.TabIndex = 35;
            this.TraziButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "*Duplim klikom na termin iz tabele otvara se forma za uređivanje";
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajBtn.FlatAppearance.BorderSize = 0;
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajBtn.Location = new System.Drawing.Point(945, 69);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(143, 28);
            this.dodajBtn.TabIndex = 38;
            this.dodajBtn.Text = "Dodaj termin";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // OznaciOdrzanBtn
            // 
            this.OznaciOdrzanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.OznaciOdrzanBtn.FlatAppearance.BorderSize = 0;
            this.OznaciOdrzanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OznaciOdrzanBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.OznaciOdrzanBtn.Location = new System.Drawing.Point(1107, 69);
            this.OznaciOdrzanBtn.Name = "OznaciOdrzanBtn";
            this.OznaciOdrzanBtn.Size = new System.Drawing.Size(143, 28);
            this.OznaciOdrzanBtn.TabIndex = 39;
            this.OznaciOdrzanBtn.Text = "Označi kao održan";
            this.OznaciOdrzanBtn.UseVisualStyleBackColor = false;
            this.OznaciOdrzanBtn.Click += new System.EventHandler(this.OznaciOdrzanBtn_Click);
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(1241, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 40;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // TerminAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1283, 547);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.OznaciOdrzanBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.imePrezimelbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.terminiGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TerminAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termini";
            this.Load += new System.EventHandler(this.TerminAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terminiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView terminiGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOdrzan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imePrezimelbl;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button OznaciOdrzanBtn;
        private System.Windows.Forms.Label closeForm;
    }
}