namespace auto_skolaUI.Tests
{
    partial class PitanjeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PitanjeAddForm));
            this.imeLbL = new System.Windows.Forms.Label();
            this.pitanjeInput = new System.Windows.Forms.TextBox();
            this.tipPitanjaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLbL
            // 
            this.imeLbL.AutoSize = true;
            this.imeLbL.ForeColor = System.Drawing.Color.White;
            this.imeLbL.Location = new System.Drawing.Point(21, 98);
            this.imeLbL.Name = "imeLbL";
            this.imeLbL.Size = new System.Drawing.Size(55, 17);
            this.imeLbL.TabIndex = 12;
            this.imeLbL.Text = "Pitanje:";
            // 
            // pitanjeInput
            // 
            this.pitanjeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pitanjeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pitanjeInput.ForeColor = System.Drawing.Color.White;
            this.pitanjeInput.Location = new System.Drawing.Point(105, 93);
            this.pitanjeInput.Name = "pitanjeInput";
            this.pitanjeInput.Size = new System.Drawing.Size(245, 22);
            this.pitanjeInput.TabIndex = 0;
            this.pitanjeInput.Validating += new System.ComponentModel.CancelEventHandler(this.pitanjeInput_Validating);
            // 
            // tipPitanjaList
            // 
            this.tipPitanjaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tipPitanjaList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipPitanjaList.ForeColor = System.Drawing.Color.White;
            this.tipPitanjaList.FormattingEnabled = true;
            this.tipPitanjaList.Location = new System.Drawing.Point(105, 305);
            this.tipPitanjaList.Name = "tipPitanjaList";
            this.tipPitanjaList.Size = new System.Drawing.Size(245, 24);
            this.tipPitanjaList.TabIndex = 3;
            this.tipPitanjaList.Validating += new System.ComponentModel.CancelEventHandler(this.tipPitanjaList_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tip pitanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Test:";
            // 
            // testList
            // 
            this.testList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.testList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testList.ForeColor = System.Drawing.Color.White;
            this.testList.FormattingEnabled = true;
            this.testList.Location = new System.Drawing.Point(105, 346);
            this.testList.Name = "testList";
            this.testList.Size = new System.Drawing.Size(245, 24);
            this.testList.TabIndex = 4;
            this.testList.Validating += new System.ComponentModel.CancelEventHandler(this.testList_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Slika:";
            // 
            // slikaInput
            // 
            this.slikaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.slikaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slikaInput.ForeColor = System.Drawing.Color.White;
            this.slikaInput.Location = new System.Drawing.Point(105, 131);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(245, 22);
            this.slikaInput.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(157, 159);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(134, 134);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.dodajSlikuButton.Location = new System.Drawing.Point(378, 128);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(75, 28);
            this.dodajSlikuButton.TabIndex = 20;
            this.dodajSlikuButton.Text = "Dodaj";
            this.dodajSlikuButton.UseVisualStyleBackColor = false;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dodajButton.Location = new System.Drawing.Point(353, 431);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 37);
            this.dodajButton.TabIndex = 21;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 37;
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
            this.label11.Location = new System.Drawing.Point(66, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 41);
            this.label11.TabIndex = 36;
            this.label11.Text = "Dodaj pitanje";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(439, 6);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 35;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // PitanjeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(476, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.dodajSlikuButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipPitanjaList);
            this.Controls.Add(this.imeLbL);
            this.Controls.Add(this.pitanjeInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PitanjeAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajPitanje";
            this.Load += new System.EventHandler(this.PitanjeAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeLbL;
        private System.Windows.Forms.TextBox pitanjeInput;
        private System.Windows.Forms.ComboBox tipPitanjaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox testList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label closeForm;
    }
}