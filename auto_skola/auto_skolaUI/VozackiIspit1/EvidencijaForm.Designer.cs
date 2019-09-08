namespace auto_skolaUI.VozackiIspit1
{
    partial class EvidencijaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxIsPolozio = new System.Windows.Forms.CheckBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tipIspitaList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.kandidatiList = new System.Windows.Forms.ComboBox();
            this.traziBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vozackiIspitGridView = new System.Windows.Forms.DataGridView();
            this.ImePrezimeKa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VozackiIspitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipIspita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPolozio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozackiIspitGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(694, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 37;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 52);
            this.label6.TabIndex = 35;
            this.label6.Text = "Evidencija Ispita";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxIsPolozio);
            this.groupBox1.Controls.Add(this.sacuvajButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tipIspitaList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kandidatiList);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(128, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 305);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova ispit";
            // 
            // cbxIsPolozio
            // 
            this.cbxIsPolozio.AutoSize = true;
            this.cbxIsPolozio.ForeColor = System.Drawing.Color.White;
            this.cbxIsPolozio.Location = new System.Drawing.Point(134, 193);
            this.cbxIsPolozio.Name = "cbxIsPolozio";
            this.cbxIsPolozio.Size = new System.Drawing.Size(76, 21);
            this.cbxIsPolozio.TabIndex = 22;
            this.cbxIsPolozio.Text = "Položio";
            this.cbxIsPolozio.UseVisualStyleBackColor = true;
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(185, 239);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(100, 37);
            this.sacuvajButton.TabIndex = 21;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = false;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tip ispita:";
            // 
            // tipIspitaList
            // 
            this.tipIspitaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tipIspitaList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipIspitaList.ForeColor = System.Drawing.Color.White;
            this.tipIspitaList.FormattingEnabled = true;
            this.tipIspitaList.Location = new System.Drawing.Point(134, 151);
            this.tipIspitaList.Name = "tipIspitaList";
            this.tipIspitaList.Size = new System.Drawing.Size(230, 24);
            this.tipIspitaList.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(134, 105);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 22);
            this.datePicker.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kandidat:";
            // 
            // kandidatiList
            // 
            this.kandidatiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.kandidatiList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kandidatiList.ForeColor = System.Drawing.Color.White;
            this.kandidatiList.FormattingEnabled = true;
            this.kandidatiList.Location = new System.Drawing.Point(134, 56);
            this.kandidatiList.Name = "kandidatiList";
            this.kandidatiList.Size = new System.Drawing.Size(230, 24);
            this.kandidatiList.TabIndex = 13;
            // 
            // traziBtn
            // 
            this.traziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.traziBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.traziBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traziBtn.ForeColor = System.Drawing.Color.White;
            this.traziBtn.Image = ((System.Drawing.Image)(resources.GetObject("traziBtn.Image")));
            this.traziBtn.Location = new System.Drawing.Point(421, 438);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(46, 28);
            this.traziBtn.TabIndex = 42;
            this.traziBtn.UseVisualStyleBackColor = false;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.imePrezimeInput);
            this.panel1.Location = new System.Drawing.Point(163, 438);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(252, 28);
            this.panel1.TabIndex = 41;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ime ili prezime:";
            // 
            // vozackiIspitGridView
            // 
            this.vozackiIspitGridView.AllowUserToAddRows = false;
            this.vozackiIspitGridView.AllowUserToDeleteRows = false;
            this.vozackiIspitGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.vozackiIspitGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vozackiIspitGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vozackiIspitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vozackiIspitGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezimeKa,
            this.VozackiIspitId,
            this.Datum,
            this.TipIspita,
            this.IsPolozio});
            this.vozackiIspitGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.vozackiIspitGridView.Location = new System.Drawing.Point(48, 490);
            this.vozackiIspitGridView.Name = "vozackiIspitGridView";
            this.vozackiIspitGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vozackiIspitGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.vozackiIspitGridView.RowTemplate.Height = 24;
            this.vozackiIspitGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vozackiIspitGridView.Size = new System.Drawing.Size(621, 168);
            this.vozackiIspitGridView.TabIndex = 39;
            // 
            // ImePrezimeKa
            // 
            this.ImePrezimeKa.DataPropertyName = "Kandidat";
            this.ImePrezimeKa.HeaderText = "Kandidat";
            this.ImePrezimeKa.Name = "ImePrezimeKa";
            this.ImePrezimeKa.ReadOnly = true;
            // 
            // VozackiIspitId
            // 
            this.VozackiIspitId.DataPropertyName = "VozackiIspitId";
            this.VozackiIspitId.HeaderText = "VozackiIspitId";
            this.VozackiIspitId.Name = "VozackiIspitId";
            this.VozackiIspitId.ReadOnly = true;
            this.VozackiIspitId.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // TipIspita
            // 
            this.TipIspita.DataPropertyName = "TipIspita";
            this.TipIspita.HeaderText = "Tip ispita";
            this.TipIspita.Name = "TipIspita";
            this.TipIspita.ReadOnly = true;
            // 
            // IsPolozio
            // 
            this.IsPolozio.DataPropertyName = "IsPolozio";
            this.IsPolozio.HeaderText = "Polozio";
            this.IsPolozio.Name = "IsPolozio";
            this.IsPolozio.ReadOnly = true;
            // 
            // EvidencijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(736, 699);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vozackiIspitGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvidencijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvidencijaForm";
            this.Load += new System.EventHandler(this.EvidencijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vozackiIspitGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipIspitaList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kandidatiList;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView vozackiIspitGridView;
        private System.Windows.Forms.CheckBox cbxIsPolozio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKa;
        private System.Windows.Forms.DataGridViewTextBoxColumn VozackiIspitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipIspita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPolozio;
    }
}