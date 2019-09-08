namespace auto_skolaUI.Termini
{
    partial class TerminAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminAdd));
            this.label6 = new System.Windows.Forms.Label();
            this.automobilList = new System.Windows.Forms.ComboBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.napomenaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.kandidatiList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instruktorList = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Automobil:";
            // 
            // automobilList
            // 
            this.automobilList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.automobilList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.automobilList.ForeColor = System.Drawing.Color.White;
            this.automobilList.FormattingEnabled = true;
            this.automobilList.Location = new System.Drawing.Point(127, 180);
            this.automobilList.Name = "automobilList";
            this.automobilList.Size = new System.Drawing.Size(230, 24);
            this.automobilList.TabIndex = 16;
            this.automobilList.Validating += new System.ComponentModel.CancelEventHandler(this.automobilList_Validating);
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(332, 380);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(100, 37);
            this.sacuvajButton.TabIndex = 22;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = false;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // napomenaInput
            // 
            this.napomenaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.napomenaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.napomenaInput.ForeColor = System.Drawing.Color.White;
            this.napomenaInput.Location = new System.Drawing.Point(127, 281);
            this.napomenaInput.Multiline = true;
            this.napomenaInput.Name = "napomenaInput";
            this.napomenaInput.Size = new System.Drawing.Size(230, 38);
            this.napomenaInput.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Napomena:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(244, 237);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(113, 22);
            this.timePicker.TabIndex = 19;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(127, 237);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(113, 22);
            this.datePicker.TabIndex = 18;
            this.datePicker.Validating += new System.ComponentModel.CancelEventHandler(this.datePicker_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kandidat:";
            // 
            // kandidatiList
            // 
            this.kandidatiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.kandidatiList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kandidatiList.ForeColor = System.Drawing.Color.White;
            this.kandidatiList.FormattingEnabled = true;
            this.kandidatiList.Location = new System.Drawing.Point(127, 129);
            this.kandidatiList.Name = "kandidatiList";
            this.kandidatiList.Size = new System.Drawing.Size(230, 24);
            this.kandidatiList.TabIndex = 14;
            this.kandidatiList.Validating += new System.ComponentModel.CancelEventHandler(this.kandidatiList_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 87);
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
            this.instruktorList.Location = new System.Drawing.Point(127, 80);
            this.instruktorList.Name = "instruktorList";
            this.instruktorList.Size = new System.Drawing.Size(230, 24);
            this.instruktorList.TabIndex = 15;
            this.instruktorList.Validating += new System.ComponentModel.CancelEventHandler(this.instruktorList_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Termin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Copperplate Gothic Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(55, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 41);
            this.label11.TabIndex = 33;
            this.label11.Text = "Dodaj termin";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(403, -3);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 32;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // TerminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(445, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.automobilList);
            this.Controls.Add(this.sacuvajButton);
            this.Controls.Add(this.napomenaInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kandidatiList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instruktorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TerminAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajTermin";
            this.Load += new System.EventHandler(this.TerminAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox automobilList;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.TextBox napomenaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kandidatiList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox instruktorList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label closeForm;
    }
}