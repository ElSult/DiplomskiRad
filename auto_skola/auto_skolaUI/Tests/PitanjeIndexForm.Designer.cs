namespace auto_skolaUI.Tests
{
    partial class PitanjeIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PitanjeIndexForm));
            this.PitanjeGridView = new System.Windows.Forms.DataGridView();
            this.PitanjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TestList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PitanjeInput = new System.Windows.Forms.TextBox();
            this.TraziButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            this.NovoPitanjeButton = new System.Windows.Forms.Button();
            this.dodajOdgovorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PitanjeGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PitanjeGridView
            // 
            this.PitanjeGridView.AllowUserToAddRows = false;
            this.PitanjeGridView.AllowUserToDeleteRows = false;
            this.PitanjeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PitanjeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.PitanjeGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PitanjeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PitanjeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PitanjeId,
            this.TestId,
            this.Pitanje,
            this.Naziv,
            this.Tip,
            this.SlikaThumb});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PitanjeGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PitanjeGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.PitanjeGridView.Location = new System.Drawing.Point(29, 133);
            this.PitanjeGridView.MultiSelect = false;
            this.PitanjeGridView.Name = "PitanjeGridView";
            this.PitanjeGridView.ReadOnly = true;
            this.PitanjeGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PitanjeGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PitanjeGridView.RowTemplate.Height = 24;
            this.PitanjeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PitanjeGridView.Size = new System.Drawing.Size(1221, 397);
            this.PitanjeGridView.TabIndex = 0;
            this.PitanjeGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PitanjeGridView_MouseDoubleClick);
            // 
            // PitanjeId
            // 
            this.PitanjeId.DataPropertyName = "PitanjeId";
            this.PitanjeId.HeaderText = "PitanjeId";
            this.PitanjeId.Name = "PitanjeId";
            this.PitanjeId.ReadOnly = true;
            this.PitanjeId.Visible = false;
            // 
            // TestId
            // 
            this.TestId.DataPropertyName = "TestId";
            this.TestId.HeaderText = "TestId";
            this.TestId.Name = "TestId";
            this.TestId.ReadOnly = true;
            this.TestId.Visible = false;
            // 
            // Pitanje
            // 
            this.Pitanje.DataPropertyName = "Pitanje1";
            this.Pitanje.FillWeight = 182.7411F;
            this.Pitanje.HeaderText = "Pitanje";
            this.Pitanje.Name = "Pitanje";
            this.Pitanje.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.FillWeight = 72.41962F;
            this.Naziv.HeaderText = "Naziv testa";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.FillWeight = 72.41962F;
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.FillWeight = 72.41962F;
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pitanje:";
            // 
            // TestList
            // 
            this.TestList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.TestList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TestList.ForeColor = System.Drawing.Color.White;
            this.TestList.FormattingEnabled = true;
            this.TestList.Location = new System.Drawing.Point(656, 91);
            this.TestList.Name = "TestList";
            this.TestList.Size = new System.Drawing.Size(245, 24);
            this.TestList.TabIndex = 7;
            this.TestList.SelectedIndexChanged += new System.EventHandler(this.TestList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(519, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ODABERITE TEST:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.PitanjeInput);
            this.panel1.Location = new System.Drawing.Point(87, 61);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(252, 28);
            this.panel1.TabIndex = 30;
            // 
            // PitanjeInput
            // 
            this.PitanjeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PitanjeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PitanjeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PitanjeInput.ForeColor = System.Drawing.Color.White;
            this.PitanjeInput.Location = new System.Drawing.Point(8, 8);
            this.PitanjeInput.Name = "PitanjeInput";
            this.PitanjeInput.Size = new System.Drawing.Size(240, 15);
            this.PitanjeInput.TabIndex = 16;
            this.PitanjeInput.TextChanged += new System.EventHandler(this.PitanjeInput_TextChanged);
            this.PitanjeInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PitanjeInput_KeyUp);
            // 
            // TraziButton
            // 
            this.TraziButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.TraziButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraziButton.ForeColor = System.Drawing.Color.White;
            this.TraziButton.Image = ((System.Drawing.Image)(resources.GetObject("TraziButton.Image")));
            this.TraziButton.Location = new System.Drawing.Point(345, 61);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(46, 28);
            this.TraziButton.TabIndex = 31;
            this.TraziButton.UseVisualStyleBackColor = false;
            this.TraziButton.Click += new System.EventHandler(this.TraziButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "*Duplim klikom na pitanje iz tabele otvara se forma za uređivanje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 52);
            this.label4.TabIndex = 33;
            this.label4.Text = "Pitanja";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.closeForm.TabIndex = 35;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // NovoPitanjeButton
            // 
            this.NovoPitanjeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.NovoPitanjeButton.FlatAppearance.BorderSize = 0;
            this.NovoPitanjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovoPitanjeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.NovoPitanjeButton.Location = new System.Drawing.Point(958, 63);
            this.NovoPitanjeButton.Name = "NovoPitanjeButton";
            this.NovoPitanjeButton.Size = new System.Drawing.Size(143, 28);
            this.NovoPitanjeButton.TabIndex = 36;
            this.NovoPitanjeButton.Text = "Dodaj pitanje";
            this.NovoPitanjeButton.UseVisualStyleBackColor = false;
            this.NovoPitanjeButton.Click += new System.EventHandler(this.NovoPitanjeButton_Click);
            // 
            // dodajOdgovorButton
            // 
            this.dodajOdgovorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajOdgovorButton.FlatAppearance.BorderSize = 0;
            this.dodajOdgovorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajOdgovorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajOdgovorButton.Location = new System.Drawing.Point(1107, 63);
            this.dodajOdgovorButton.Name = "dodajOdgovorButton";
            this.dodajOdgovorButton.Size = new System.Drawing.Size(143, 28);
            this.dodajOdgovorButton.TabIndex = 37;
            this.dodajOdgovorButton.Text = "Izmjeni odgovor";
            this.dodajOdgovorButton.UseVisualStyleBackColor = false;
            this.dodajOdgovorButton.Click += new System.EventHandler(this.dodajOdgovorButton_Click);
            // 
            // PitanjeIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1283, 547);
            this.Controls.Add(this.dodajOdgovorButton);
            this.Controls.Add(this.NovoPitanjeButton);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PitanjeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PitanjeIndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pitanja";
            this.Load += new System.EventHandler(this.PitanjeIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PitanjeGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PitanjeGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TestList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PitanjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PitanjeInput;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Button NovoPitanjeButton;
        private System.Windows.Forms.Button dodajOdgovorButton;
    }
}