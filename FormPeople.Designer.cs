namespace MedicinskaOrdinacija {
    partial class FormPeople {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.IDPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeoplePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleAdditional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPeople,
            this.PeopleName,
            this.PeopleSurname,
            this.PeopleType,
            this.PeoplePhone,
            this.PeopleAdditional});
            this.dgvPeople.Location = new System.Drawing.Point(62, 26);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(657, 388);
            this.dgvPeople.TabIndex = 0;
            // 
            // IDPeople
            // 
            this.IDPeople.HeaderText = "ID";
            this.IDPeople.Name = "IDPeople";
            this.IDPeople.ReadOnly = true;
            // 
            // PeopleName
            // 
            this.PeopleName.HeaderText = "Ime";
            this.PeopleName.Name = "PeopleName";
            // 
            // PeopleSurname
            // 
            this.PeopleSurname.HeaderText = "Prezime";
            this.PeopleSurname.Name = "PeopleSurname";
            // 
            // PeopleType
            // 
            this.PeopleType.HeaderText = "Tip";
            this.PeopleType.Name = "PeopleType";
            // 
            // PeoplePhone
            // 
            this.PeoplePhone.HeaderText = "Telefon";
            this.PeoplePhone.Name = "PeoplePhone";
            // 
            // PeopleAdditional
            // 
            this.PeopleAdditional.HeaderText = "Dodatno";
            this.PeopleAdditional.Name = "PeopleAdditional";
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPeople);
            this.Name = "FormPeople";
            this.Text = "FormPeople";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeoplePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleAdditional;
    }
}