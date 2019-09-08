namespace auto_skolaUI
{
    partial class PotvdaIzlaskaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upozorenje";
            // 
            // closeForm
            // 
            this.closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(404, 5);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 30;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(71, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Da li želite izbirsati odabranu stavku?";
            // 
            // btnDa
            // 
            this.btnDa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnDa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnDa.Location = new System.Drawing.Point(92, 113);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(100, 37);
            this.btnDa.TabIndex = 32;
            this.btnDa.Text = "Da";
            this.btnDa.UseVisualStyleBackColor = false;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNe
            // 
            this.btnNe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnNe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnNe.Location = new System.Drawing.Point(260, 113);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(100, 37);
            this.btnNe.TabIndex = 33;
            this.btnNe.Text = "Ne";
            this.btnNe.UseVisualStyleBackColor = false;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // PotvdaIzlaskaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(446, 173);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PotvdaIzlaskaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upozorenje";
            this.Load += new System.EventHandler(this.PotvdaIzlaskaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button btnNe;
    }
}