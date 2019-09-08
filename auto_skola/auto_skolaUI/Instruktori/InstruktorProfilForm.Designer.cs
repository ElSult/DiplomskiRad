namespace auto_skolaUI.Instruktori
{
    partial class InstruktorProfilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstruktorProfilForm));
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.napomenaLbL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.korisnickoImeLbL = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adresaInput = new System.Windows.Forms.TextBox();
            this.imePrezimeLbL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.rejtingLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(318, 493);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(105, 28);
            this.sacuvajButton.TabIndex = 9;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = false;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // napomenaLbL
            // 
            this.napomenaLbL.AutoSize = true;
            this.napomenaLbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napomenaLbL.Location = new System.Drawing.Point(354, 148);
            this.napomenaLbL.Name = "napomenaLbL";
            this.napomenaLbL.Size = new System.Drawing.Size(90, 17);
            this.napomenaLbL.TabIndex = 17;
            this.napomenaLbL.Text = "Napomena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lozinka:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lozinkaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lozinkaInput.ForeColor = System.Drawing.Color.White;
            this.lozinkaInput.Location = new System.Drawing.Point(173, 445);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(245, 22);
            this.lozinkaInput.TabIndex = 6;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // korisnickoImeLbL
            // 
            this.korisnickoImeLbL.AutoSize = true;
            this.korisnickoImeLbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisnickoImeLbL.Location = new System.Drawing.Point(354, 118);
            this.korisnickoImeLbL.Name = "korisnickoImeLbL";
            this.korisnickoImeLbL.Size = new System.Drawing.Size(108, 17);
            this.korisnickoImeLbL.TabIndex = 15;
            this.korisnickoImeLbL.Text = "KorisnickoIme";
            // 
            // telefonInput
            // 
            this.telefonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.telefonInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefonInput.ForeColor = System.Drawing.Color.White;
            this.telefonInput.Location = new System.Drawing.Point(173, 395);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(245, 22);
            this.telefonInput.TabIndex = 4;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.ForeColor = System.Drawing.Color.White;
            this.emailInput.Location = new System.Drawing.Point(173, 345);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(245, 22);
            this.emailInput.TabIndex = 3;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adresa:";
            // 
            // adresaInput
            // 
            this.adresaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.adresaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adresaInput.ForeColor = System.Drawing.Color.White;
            this.adresaInput.Location = new System.Drawing.Point(173, 305);
            this.adresaInput.Name = "adresaInput";
            this.adresaInput.Size = new System.Drawing.Size(245, 22);
            this.adresaInput.TabIndex = 2;
            this.adresaInput.Validating += new System.ComponentModel.CancelEventHandler(this.adresaInput_Validating);
            // 
            // imePrezimeLbL
            // 
            this.imePrezimeLbL.AutoSize = true;
            this.imePrezimeLbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imePrezimeLbL.Location = new System.Drawing.Point(352, 89);
            this.imePrezimeLbL.Name = "imePrezimeLbL";
            this.imePrezimeLbL.Size = new System.Drawing.Size(158, 17);
            this.imePrezimeLbL.TabIndex = 10;
            this.imePrezimeLbL.Text = "ImePrezimeKorisnika";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajSlikuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dodajSlikuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajSlikuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajSlikuButton.Location = new System.Drawing.Point(435, 262);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(75, 28);
            this.dodajSlikuButton.TabIndex = 28;
            this.dodajSlikuButton.Text = "Dodaj";
            this.dodajSlikuButton.UseVisualStyleBackColor = false;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(74, 79);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(134, 134);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 31;
            this.pictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Slika:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // slikaInput
            // 
            this.slikaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.slikaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slikaInput.ForeColor = System.Drawing.Color.White;
            this.slikaInput.Location = new System.Drawing.Point(173, 265);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(245, 22);
            this.slikaInput.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(230, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Rejting:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rejtingLbl
            // 
            this.rejtingLbl.AutoSize = true;
            this.rejtingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rejtingLbl.Location = new System.Drawing.Point(354, 176);
            this.rejtingLbl.Name = "rejtingLbl";
            this.rejtingLbl.Size = new System.Drawing.Size(40, 17);
            this.rejtingLbl.TabIndex = 33;
            this.rejtingLbl.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Korisnik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Napomena:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Korisnicko ime:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 40;
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
            this.label11.Location = new System.Drawing.Point(66, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(430, 41);
            this.label11.TabIndex = 39;
            this.label11.Text = "Prijavljeni Korisnik";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(541, 3);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 41;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // InstruktorProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(573, 561);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rejtingLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajSlikuButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.sacuvajButton);
            this.Controls.Add(this.napomenaLbL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.korisnickoImeLbL);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresaInput);
            this.Controls.Add(this.imePrezimeLbL);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstruktorProfilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moj profil";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.Label napomenaLbL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label korisnickoImeLbL;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresaInput;
        private System.Windows.Forms.Label imePrezimeLbL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label rejtingLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label closeForm;
    }
}