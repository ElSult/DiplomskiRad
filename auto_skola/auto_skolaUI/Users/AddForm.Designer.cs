namespace auto_skolaUI
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.imeInput = new System.Windows.Forms.TextBox();
            this.imeLbL = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adresaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.napomenaInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeInput
            // 
            this.imeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.imeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imeInput.ForeColor = System.Drawing.Color.White;
            this.imeInput.Location = new System.Drawing.Point(186, 70);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(245, 22);
            this.imeInput.TabIndex = 0;
            this.imeInput.TextChanged += new System.EventHandler(this.imeInput_TextChanged);
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // imeLbL
            // 
            this.imeLbL.AutoSize = true;
            this.imeLbL.Location = new System.Drawing.Point(74, 75);
            this.imeLbL.Name = "imeLbL";
            this.imeLbL.Size = new System.Drawing.Size(34, 17);
            this.imeLbL.TabIndex = 11;
            this.imeLbL.Text = "Ime:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.prezimeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prezimeInput.ForeColor = System.Drawing.Color.White;
            this.prezimeInput.Location = new System.Drawing.Point(186, 115);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(245, 22);
            this.prezimeInput.TabIndex = 1;
            this.prezimeInput.TextChanged += new System.EventHandler(this.prezimeInput_TextChanged);
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prezime:";
            // 
            // adresaInput
            // 
            this.adresaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.adresaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adresaInput.ForeColor = System.Drawing.Color.White;
            this.adresaInput.Location = new System.Drawing.Point(186, 161);
            this.adresaInput.Name = "adresaInput";
            this.adresaInput.Size = new System.Drawing.Size(245, 22);
            this.adresaInput.TabIndex = 2;
            this.adresaInput.TextChanged += new System.EventHandler(this.adresaInput_TextChanged);
            this.adresaInput.Validating += new System.ComponentModel.CancelEventHandler(this.adresaInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adresa";
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.ForeColor = System.Drawing.Color.White;
            this.emailInput.Location = new System.Drawing.Point(186, 202);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(245, 22);
            this.emailInput.TabIndex = 3;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon:";
            // 
            // telefonInput
            // 
            this.telefonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.telefonInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefonInput.ForeColor = System.Drawing.Color.White;
            this.telefonInput.Location = new System.Drawing.Point(186, 252);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(245, 22);
            this.telefonInput.TabIndex = 4;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Korisnicko ime:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.korisnickoImeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.korisnickoImeInput.ForeColor = System.Drawing.Color.White;
            this.korisnickoImeInput.Location = new System.Drawing.Point(186, 469);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(245, 22);
            this.korisnickoImeInput.TabIndex = 6;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lozinkaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lozinkaInput.ForeColor = System.Drawing.Color.White;
            this.lozinkaInput.Location = new System.Drawing.Point(187, 513);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(245, 22);
            this.lozinkaInput.TabIndex = 7;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lozinka:";
            // 
            // napomenaInput
            // 
            this.napomenaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.napomenaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.napomenaInput.ForeColor = System.Drawing.Color.White;
            this.napomenaInput.Location = new System.Drawing.Point(187, 563);
            this.napomenaInput.Name = "napomenaInput";
            this.napomenaInput.Size = new System.Drawing.Size(245, 22);
            this.napomenaInput.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 568);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Napomena:";
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajButton.Location = new System.Drawing.Point(410, 680);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 37);
            this.dodajButton.TabIndex = 10;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ulogeList
            // 
            this.ulogeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ulogeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulogeList.ForeColor = System.Drawing.Color.White;
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(186, 606);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(245, 53);
            this.ulogeList.TabIndex = 9;
            this.ulogeList.Validating += new System.ComponentModel.CancelEventHandler(this.ulogeList_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Uloge:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajSlikuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajSlikuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajSlikuButton.Location = new System.Drawing.Point(435, 295);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(75, 28);
            this.dodajSlikuButton.TabIndex = 5;
            this.dodajSlikuButton.Text = "Dodaj";
            this.dodajSlikuButton.UseVisualStyleBackColor = false;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(232, 329);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(134, 134);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 27;
            this.pictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Slika:";
            // 
            // slikaInput
            // 
            this.slikaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.slikaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slikaInput.ForeColor = System.Drawing.Color.White;
            this.slikaInput.Location = new System.Drawing.Point(184, 298);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(245, 22);
            this.slikaInput.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 2);
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
            this.label11.Location = new System.Drawing.Point(70, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(351, 41);
            this.label11.TabIndex = 33;
            this.label11.Text = "Dodaj korisnika";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(490, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 32;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(532, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.dodajSlikuButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.napomenaInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresaInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.imeLbL);
            this.Controls.Add(this.imeInput);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajKorisnika";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label imeLbL;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox napomenaInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label closeForm;
    }
}