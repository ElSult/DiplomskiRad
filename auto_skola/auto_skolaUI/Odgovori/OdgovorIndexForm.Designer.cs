namespace auto_skolaUI.Odgovori
{
    partial class OdgovorIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdgovorIndexForm));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pitanjeInput = new System.Windows.Forms.TextBox();
            this.odgovor1Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.odgovor2Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.odgovor4Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.odgovor3Input = new System.Windows.Forms.TextBox();
            this.IsTacan1Cbx = new System.Windows.Forms.CheckBox();
            this.IsTacan2Cbx = new System.Windows.Forms.CheckBox();
            this.IsTacan4Cbx = new System.Windows.Forms.CheckBox();
            this.IsTacan3Cbx = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.closeForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pitanje:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pitanjeInput
            // 
            this.pitanjeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pitanjeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pitanjeInput.Enabled = false;
            this.pitanjeInput.ForeColor = System.Drawing.Color.White;
            this.pitanjeInput.HideSelection = false;
            this.pitanjeInput.Location = new System.Drawing.Point(54, 106);
            this.pitanjeInput.Multiline = true;
            this.pitanjeInput.Name = "pitanjeInput";
            this.pitanjeInput.ReadOnly = true;
            this.pitanjeInput.Size = new System.Drawing.Size(691, 53);
            this.pitanjeInput.TabIndex = 4;
            this.pitanjeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // odgovor1Input
            // 
            this.odgovor1Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.odgovor1Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.odgovor1Input.ForeColor = System.Drawing.Color.White;
            this.odgovor1Input.Location = new System.Drawing.Point(309, 313);
            this.odgovor1Input.Name = "odgovor1Input";
            this.odgovor1Input.Size = new System.Drawing.Size(189, 22);
            this.odgovor1Input.TabIndex = 0;
            this.odgovor1Input.Validating += new System.ComponentModel.CancelEventHandler(this.odgovor1Input_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odgovor 1:";
            // 
            // odgovor2Input
            // 
            this.odgovor2Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.odgovor2Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.odgovor2Input.ForeColor = System.Drawing.Color.White;
            this.odgovor2Input.Location = new System.Drawing.Point(309, 354);
            this.odgovor2Input.Name = "odgovor2Input";
            this.odgovor2Input.Size = new System.Drawing.Size(189, 22);
            this.odgovor2Input.TabIndex = 2;
            this.odgovor2Input.Validating += new System.ComponentModel.CancelEventHandler(this.odgovor2Input_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odgovor 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Odgovor 4:";
            // 
            // odgovor4Input
            // 
            this.odgovor4Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.odgovor4Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.odgovor4Input.ForeColor = System.Drawing.Color.White;
            this.odgovor4Input.Location = new System.Drawing.Point(309, 444);
            this.odgovor4Input.Name = "odgovor4Input";
            this.odgovor4Input.Size = new System.Drawing.Size(189, 22);
            this.odgovor4Input.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odgovor 3:";
            // 
            // odgovor3Input
            // 
            this.odgovor3Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.odgovor3Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.odgovor3Input.ForeColor = System.Drawing.Color.White;
            this.odgovor3Input.Location = new System.Drawing.Point(309, 403);
            this.odgovor3Input.Name = "odgovor3Input";
            this.odgovor3Input.Size = new System.Drawing.Size(189, 22);
            this.odgovor3Input.TabIndex = 4;
            // 
            // IsTacan1Cbx
            // 
            this.IsTacan1Cbx.AutoSize = true;
            this.IsTacan1Cbx.Location = new System.Drawing.Point(550, 313);
            this.IsTacan1Cbx.Name = "IsTacan1Cbx";
            this.IsTacan1Cbx.Size = new System.Drawing.Size(70, 21);
            this.IsTacan1Cbx.TabIndex = 1;
            this.IsTacan1Cbx.Text = "Tačno";
            this.IsTacan1Cbx.UseVisualStyleBackColor = true;
            // 
            // IsTacan2Cbx
            // 
            this.IsTacan2Cbx.AutoSize = true;
            this.IsTacan2Cbx.Location = new System.Drawing.Point(550, 354);
            this.IsTacan2Cbx.Name = "IsTacan2Cbx";
            this.IsTacan2Cbx.Size = new System.Drawing.Size(70, 21);
            this.IsTacan2Cbx.TabIndex = 3;
            this.IsTacan2Cbx.Text = "Tačno";
            this.IsTacan2Cbx.UseVisualStyleBackColor = true;
            // 
            // IsTacan4Cbx
            // 
            this.IsTacan4Cbx.AutoSize = true;
            this.IsTacan4Cbx.Location = new System.Drawing.Point(550, 444);
            this.IsTacan4Cbx.Name = "IsTacan4Cbx";
            this.IsTacan4Cbx.Size = new System.Drawing.Size(70, 21);
            this.IsTacan4Cbx.TabIndex = 7;
            this.IsTacan4Cbx.Text = "Tačno";
            this.IsTacan4Cbx.UseVisualStyleBackColor = true;
            // 
            // IsTacan3Cbx
            // 
            this.IsTacan3Cbx.AutoSize = true;
            this.IsTacan3Cbx.Location = new System.Drawing.Point(550, 404);
            this.IsTacan3Cbx.Name = "IsTacan3Cbx";
            this.IsTacan3Cbx.Size = new System.Drawing.Size(70, 21);
            this.IsTacan3Cbx.TabIndex = 5;
            this.IsTacan3Cbx.Text = "Tačno";
            this.IsTacan3Cbx.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(329, 165);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(134, 134);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sacuvajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sacuvajButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sacuvajButton.Location = new System.Drawing.Point(329, 509);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(134, 28);
            this.sacuvajButton.TabIndex = 8;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = false;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(758, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 22;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.TabIndex = 30;
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
            this.label6.Location = new System.Drawing.Point(85, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 52);
            this.label6.TabIndex = 29;
            this.label6.Text = "Odgovori";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OdgovorIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.sacuvajButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.IsTacan4Cbx);
            this.Controls.Add(this.IsTacan3Cbx);
            this.Controls.Add(this.IsTacan2Cbx);
            this.Controls.Add(this.IsTacan1Cbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odgovor4Input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odgovor3Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odgovor2Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odgovor1Input);
            this.Controls.Add(this.pitanjeInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdgovorIndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odgovori";
            this.Load += new System.EventHandler(this.OdgovorIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox odgovor1Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox odgovor2Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox odgovor4Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox odgovor3Input;
        private System.Windows.Forms.CheckBox IsTacan1Cbx;
        private System.Windows.Forms.CheckBox IsTacan2Cbx;
        private System.Windows.Forms.CheckBox IsTacan4Cbx;
        private System.Windows.Forms.CheckBox IsTacan3Cbx;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox pitanjeInput;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}