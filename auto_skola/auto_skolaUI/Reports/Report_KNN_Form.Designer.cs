namespace auto_skolaUI.Reports
{
    partial class Report_KNN_Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kandidatList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.osvjeziBtn = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Label();
            this.asp_ReportKNN_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.asp_ReportKNN_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "ReportKNN";
            reportDataSource1.Value = this.asp_ReportKNN_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "auto_skolaUI.Reports.Report_KNN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1252, 610);
            this.reportViewer1.TabIndex = 0;
            // 
            // kandidatList
            // 
            this.kandidatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.kandidatList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kandidatList.ForeColor = System.Drawing.Color.White;
            this.kandidatList.FormattingEnabled = true;
            this.kandidatList.Location = new System.Drawing.Point(86, 62);
            this.kandidatList.Name = "kandidatList";
            this.kandidatList.Size = new System.Drawing.Size(161, 24);
            this.kandidatList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kandidat:";
            // 
            // osvjeziBtn
            // 
            this.osvjeziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.osvjeziBtn.FlatAppearance.BorderSize = 0;
            this.osvjeziBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.osvjeziBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.osvjeziBtn.Location = new System.Drawing.Point(260, 59);
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
            this.closeForm.Location = new System.Drawing.Point(1210, 9);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(29, 30);
            this.closeForm.TabIndex = 22;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // asp_ReportKNN_ResultBindingSource
            // 
            this.asp_ReportKNN_ResultBindingSource.DataSource = typeof(auto_skolaAPI.Models.asp_ReportKNN_Result);
            // 
            // Report_KNN_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1252, 733);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.osvjeziBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kandidatList);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report_KNN_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_KNN_Form";
            this.Load += new System.EventHandler(this.Report_KNN_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asp_ReportKNN_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox kandidatList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button osvjeziBtn;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.BindingSource asp_ReportKNN_ResultBindingSource;
    }
}