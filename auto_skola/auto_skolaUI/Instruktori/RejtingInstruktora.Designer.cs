namespace auto_skolaUI.Instruktori
{
    partial class RejtingInstruktora
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
            this.instruktoriList = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.instruktoriList)).BeginInit();
            this.SuspendLayout();
            // 
            // instruktoriList
            // 
            this.instruktoriList.AllowUserToAddRows = false;
            this.instruktoriList.AllowUserToDeleteRows = false;
            this.instruktoriList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instruktoriList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Email,
            this.prosjek,
            this.KorisnikId});
            this.instruktoriList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instruktoriList.Location = new System.Drawing.Point(0, 96);
            this.instruktoriList.Name = "instruktoriList";
            this.instruktoriList.ReadOnly = true;
            this.instruktoriList.RowTemplate.Height = 24;
            this.instruktoriList.Size = new System.Drawing.Size(800, 354);
            this.instruktoriList.TabIndex = 0;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Instruktor";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // prosjek
            // 
            this.prosjek.DataPropertyName = "prosjek";
            this.prosjek.HeaderText = "Prosjek";
            this.prosjek.Name = "prosjek";
            this.prosjek.ReadOnly = true;
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // RejtingInstruktora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instruktoriList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RejtingInstruktora";
            this.ShowIcon = false;
            this.Text = "RejtingInstruktora";
            this.Load += new System.EventHandler(this.RejtingInstruktora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instruktoriList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView instruktoriList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
    }
}