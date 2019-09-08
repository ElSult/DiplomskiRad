namespace auto_skolaUI.Tests
{
    partial class TestIndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestIndexForm));
            this.testGridView = new System.Windows.Forms.DataGridView();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcijalnoBodovanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.parcijalnoBodovanjeCbx = new System.Windows.Forms.CheckBox();
            this.imeLbL = new System.Windows.Forms.Label();
            this.nazivTestaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PodkategorijaList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pretragaInput = new System.Windows.Forms.TextBox();
            this.TraziButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_OcistiFormu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testGridView
            // 
            this.testGridView.AllowUserToAddRows = false;
            this.testGridView.AllowUserToDeleteRows = false;
            this.testGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.testGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.testGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestId,
            this.Naziv,
            this.Kategorija,
            this.ParcijalnoBodovanje});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.testGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.testGridView.Location = new System.Drawing.Point(28, 380);
            this.testGridView.Name = "testGridView";
            this.testGridView.ReadOnly = true;
            this.testGridView.RowTemplate.Height = 24;
            this.testGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testGridView.Size = new System.Drawing.Size(583, 176);
            this.testGridView.TabIndex = 32;
            this.testGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testGridView_CellContentClick);
            this.testGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.testGridView_MouseDoubleClick);
            // 
            // TestId
            // 
            this.TestId.DataPropertyName = "TestId";
            this.TestId.HeaderText = "TestId";
            this.TestId.Name = "TestId";
            this.TestId.ReadOnly = true;
            this.TestId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv testa";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // ParcijalnoBodovanje
            // 
            this.ParcijalnoBodovanje.DataPropertyName = "ParcijalnoBodovanje";
            this.ParcijalnoBodovanje.HeaderText = "Parcijalno bodovanje";
            this.ParcijalnoBodovanje.Name = "ParcijalnoBodovanje";
            this.ParcijalnoBodovanje.ReadOnly = true;
            this.ParcijalnoBodovanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ParcijalnoBodovanje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Naziv testa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sacuvajButton);
            this.groupBox1.Controls.Add(this.parcijalnoBodovanjeCbx);
            this.groupBox1.Controls.Add(this.imeLbL);
            this.groupBox1.Controls.Add(this.nazivTestaInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PodkategorijaList);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(134, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 206);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi test";
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(167, 152);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(100, 37);
            this.sacuvajButton.TabIndex = 42;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = false;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // parcijalnoBodovanjeCbx
            // 
            this.parcijalnoBodovanjeCbx.AutoSize = true;
            this.parcijalnoBodovanjeCbx.ForeColor = System.Drawing.Color.White;
            this.parcijalnoBodovanjeCbx.Location = new System.Drawing.Point(146, 112);
            this.parcijalnoBodovanjeCbx.Name = "parcijalnoBodovanjeCbx";
            this.parcijalnoBodovanjeCbx.Size = new System.Drawing.Size(162, 21);
            this.parcijalnoBodovanjeCbx.TabIndex = 41;
            this.parcijalnoBodovanjeCbx.Text = "Parcijalno bodovanje";
            this.parcijalnoBodovanjeCbx.UseVisualStyleBackColor = true;
            // 
            // imeLbL
            // 
            this.imeLbL.AutoSize = true;
            this.imeLbL.ForeColor = System.Drawing.Color.White;
            this.imeLbL.Location = new System.Drawing.Point(20, 37);
            this.imeLbL.Name = "imeLbL";
            this.imeLbL.Size = new System.Drawing.Size(82, 17);
            this.imeLbL.TabIndex = 40;
            this.imeLbL.Text = "Naziv testa:";
            // 
            // nazivTestaInput
            // 
            this.nazivTestaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.nazivTestaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nazivTestaInput.Location = new System.Drawing.Point(110, 34);
            this.nazivTestaInput.Name = "nazivTestaInput";
            this.nazivTestaInput.Size = new System.Drawing.Size(245, 22);
            this.nazivTestaInput.TabIndex = 36;
            this.nazivTestaInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivTestaInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kategorija:";
            // 
            // PodkategorijaList
            // 
            this.PodkategorijaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PodkategorijaList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PodkategorijaList.ForeColor = System.Drawing.Color.White;
            this.PodkategorijaList.FormattingEnabled = true;
            this.PodkategorijaList.Location = new System.Drawing.Point(110, 71);
            this.PodkategorijaList.Name = "PodkategorijaList";
            this.PodkategorijaList.Size = new System.Drawing.Size(245, 24);
            this.PodkategorijaList.TabIndex = 37;
            this.PodkategorijaList.Validating += new System.ComponentModel.CancelEventHandler(this.PodkategorijaList_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 42;
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
            this.label3.Size = new System.Drawing.Size(218, 52);
            this.label3.TabIndex = 41;
            this.label3.Text = "Testovi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(603, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 43;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pretragaInput);
            this.panel1.Location = new System.Drawing.Point(118, 307);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(252, 28);
            this.panel1.TabIndex = 44;
            // 
            // pretragaInput
            // 
            this.pretragaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pretragaInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pretragaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretragaInput.ForeColor = System.Drawing.Color.White;
            this.pretragaInput.Location = new System.Drawing.Point(8, 8);
            this.pretragaInput.Name = "pretragaInput";
            this.pretragaInput.Size = new System.Drawing.Size(240, 15);
            this.pretragaInput.TabIndex = 16;
            this.pretragaInput.TextChanged += new System.EventHandler(this.pretragaInput_TextChanged);
            this.pretragaInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pretragaInput_KeyUp);
            // 
            // TraziButton
            // 
            this.TraziButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.TraziButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraziButton.ForeColor = System.Drawing.Color.White;
            this.TraziButton.Image = ((System.Drawing.Image)(resources.GetObject("TraziButton.Image")));
            this.TraziButton.Location = new System.Drawing.Point(385, 307);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(46, 28);
            this.TraziButton.TabIndex = 45;
            this.TraziButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "*Duplim klikom na test iz tabele otvara se forma za uređivanje";
            // 
            // btn_OcistiFormu
            // 
            this.btn_OcistiFormu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_OcistiFormu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OcistiFormu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_OcistiFormu.Location = new System.Drawing.Point(499, 305);
            this.btn_OcistiFormu.Name = "btn_OcistiFormu";
            this.btn_OcistiFormu.Size = new System.Drawing.Size(100, 37);
            this.btn_OcistiFormu.TabIndex = 47;
            this.btn_OcistiFormu.Text = "Očisti formu";
            this.btn_OcistiFormu.UseVisualStyleBackColor = false;
            this.btn_OcistiFormu.Click += new System.EventHandler(this.btn_OcistiFormu_Click);
            // 
            // TestIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(645, 582);
            this.Controls.Add(this.btn_OcistiFormu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestIndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testovi";
            this.Load += new System.EventHandler(this.TestIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView testGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox parcijalnoBodovanjeCbx;
        private System.Windows.Forms.Label imeLbL;
        private System.Windows.Forms.TextBox nazivTestaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PodkategorijaList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pretragaInput;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ParcijalnoBodovanje;
        private System.Windows.Forms.Button btn_OcistiFormu;
    }
}