namespace auto_skolaUI.Upis
{
    partial class UpisujeIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpisujeIndexForm));
            this.upisiGridView = new System.Windows.Forms.DataGridView();
            this.UpisujeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uplata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brUplCasova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uplataList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.kandidatiList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instruktorList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upisiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upisiGridView
            // 
            this.upisiGridView.AllowUserToAddRows = false;
            this.upisiGridView.AllowUserToDeleteRows = false;
            this.upisiGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.upisiGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.upisiGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.upisiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upisiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpisujeId,
            this.ImePrezimeKo,
            this.ImePrezimeKa,
            this.Uplata,
            this.brUplCasova});
            this.upisiGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.upisiGridView.Location = new System.Drawing.Point(37, 417);
            this.upisiGridView.Name = "upisiGridView";
            this.upisiGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.upisiGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.upisiGridView.RowTemplate.Height = 24;
            this.upisiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upisiGridView.Size = new System.Drawing.Size(610, 168);
            this.upisiGridView.TabIndex = 13;
            // 
            // UpisujeId
            // 
            this.UpisujeId.DataPropertyName = "UpisujeId";
            this.UpisujeId.HeaderText = "UpisujeId";
            this.UpisujeId.Name = "UpisujeId";
            this.UpisujeId.ReadOnly = true;
            this.UpisujeId.Visible = false;
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
            // Uplata
            // 
            this.Uplata.DataPropertyName = "Uplata";
            this.Uplata.HeaderText = "Uplata";
            this.Uplata.Name = "Uplata";
            this.Uplata.ReadOnly = true;
            this.Uplata.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // brUplCasova
            // 
            this.brUplCasova.DataPropertyName = "brUplCasova";
            this.brUplCasova.HeaderText = "Broj uplaćenih časova";
            this.brUplCasova.Name = "brUplCasova";
            this.brUplCasova.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ime ili prezime:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sacuvajButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uplataList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kandidatiList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.instruktorList);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(128, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 278);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova uplata";
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(184, 218);
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
            this.label4.Location = new System.Drawing.Point(38, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Uplata:";
            // 
            // uplataList
            // 
            this.uplataList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.uplataList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uplataList.ForeColor = System.Drawing.Color.White;
            this.uplataList.FormattingEnabled = true;
            this.uplataList.Location = new System.Drawing.Point(132, 176);
            this.uplataList.Name = "uplataList";
            this.uplataList.Size = new System.Drawing.Size(230, 24);
            this.uplataList.TabIndex = 15;
            this.uplataList.Validating += new System.ComponentModel.CancelEventHandler(this.uplataList_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(132, 130);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 22);
            this.datePicker.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
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
            this.kandidatiList.Location = new System.Drawing.Point(132, 81);
            this.kandidatiList.Name = "kandidatiList";
            this.kandidatiList.Size = new System.Drawing.Size(230, 24);
            this.kandidatiList.TabIndex = 13;
            this.kandidatiList.Validating += new System.ComponentModel.CancelEventHandler(this.kandidatiList_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Instruktor:";
            // 
            // instruktorList
            // 
            this.instruktorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.instruktorList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instruktorList.ForeColor = System.Drawing.Color.White;
            this.instruktorList.FormattingEnabled = true;
            this.instruktorList.Location = new System.Drawing.Point(132, 32);
            this.instruktorList.Name = "instruktorList";
            this.instruktorList.Size = new System.Drawing.Size(230, 24);
            this.instruktorList.TabIndex = 12;
            this.instruktorList.Validating += new System.ComponentModel.CancelEventHandler(this.instruktorList_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.imePrezimeInput);
            this.panel1.Location = new System.Drawing.Point(142, 365);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(252, 28);
            this.panel1.TabIndex = 30;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(400, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 28);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.TraziButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 33;
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
            this.label6.Location = new System.Drawing.Point(76, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 52);
            this.label6.TabIndex = 32;
            this.label6.Text = "Uplate/Upisi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(644, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 34;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // UpisujeIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(686, 612);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upisiGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpisujeIndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpisKandidata";
            this.Load += new System.EventHandler(this.UpisujeIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upisiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView upisiGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uplataList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kandidatiList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox instruktorList;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpisujeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uplata;
        private System.Windows.Forms.DataGridViewTextBoxColumn brUplCasova;
    }
}