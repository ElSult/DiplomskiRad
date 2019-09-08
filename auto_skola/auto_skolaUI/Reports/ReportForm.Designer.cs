namespace auto_skolaUI.Reports
{
    partial class ReportForm
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
            this.asp_Rezultat_GetRezultatiTestovaReport_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.testoviList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kandidatList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odDtp = new System.Windows.Forms.DateTimePicker();
            this.DoDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.osvjeziBtn = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.asp_Rezultat_GetRezultatiTestovaReport_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // asp_Rezultat_GetRezultatiTestovaReport_ResultBindingSource
            // 
            this.asp_Rezultat_GetRezultatiTestovaReport_ResultBindingSource.DataSource = typeof(auto_skolaAPI.Models.asp_Rezultat_GetRezultatiTestovaReport_Result);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "auto_skolaUI.Reports.RezultatiTestova.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1252, 610);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Od:";
            // 
            // testoviList
            // 
            this.testoviList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.testoviList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testoviList.ForeColor = System.Drawing.Color.White;
            this.testoviList.FormattingEnabled = true;
            this.testoviList.Location = new System.Drawing.Point(616, 62);
            this.testoviList.Name = "testoviList";
            this.testoviList.Size = new System.Drawing.Size(150, 24);
            this.testoviList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kandidatList
            // 
            this.kandidatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.kandidatList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kandidatList.ForeColor = System.Drawing.Color.White;
            this.kandidatList.FormattingEnabled = true;
            this.kandidatList.Location = new System.Drawing.Point(402, 62);
            this.kandidatList.Name = "kandidatList";
            this.kandidatList.Size = new System.Drawing.Size(150, 24);
            this.kandidatList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kandidat:";
            // 
            // odDtp
            // 
            this.odDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.odDtp.Location = new System.Drawing.Point(77, 41);
            this.odDtp.Name = "odDtp";
            this.odDtp.Size = new System.Drawing.Size(200, 22);
            this.odDtp.TabIndex = 8;
            // 
            // DoDtp
            // 
            this.DoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoDtp.Location = new System.Drawing.Point(77, 79);
            this.DoDtp.Name = "DoDtp";
            this.DoDtp.Size = new System.Drawing.Size(200, 22);
            this.DoDtp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Do:";
            // 
            // osvjeziBtn
            // 
            this.osvjeziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.osvjeziBtn.FlatAppearance.BorderSize = 0;
            this.osvjeziBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.osvjeziBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.osvjeziBtn.Location = new System.Drawing.Point(810, 58);
            this.osvjeziBtn.Name = "osvjeziBtn";
            this.osvjeziBtn.Size = new System.Drawing.Size(143, 28);
            this.osvjeziBtn.TabIndex = 15;
            this.osvjeziBtn.Text = "Osvježi";
            this.osvjeziBtn.UseVisualStyleBackColor = false;
            this.osvjeziBtn.Click += new System.EventHandler(this.osvjeziBtn_Click);
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(1223, -1);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 22;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1252, 733);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.osvjeziBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoDtp);
            this.Controls.Add(this.odDtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kandidatList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testoviList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asp_Rezultat_GetRezultatiTestovaReport_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox testoviList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kandidatList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker odDtp;
        private System.Windows.Forms.DateTimePicker DoDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource asp_Rezultat_GetRezultatiTestovaReport_ResultBindingSource;
        private System.Windows.Forms.Button osvjeziBtn;
        private System.Windows.Forms.Label closeForm;
    }
}