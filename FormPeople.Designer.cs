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
            this.btnFetchData = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.IDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMEcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURNAMEcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPEcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONEcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(12, 121);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(109, 37);
            this.btnFetchData.TabIndex = 0;
            this.btnFetchData.Text = "Fetch Data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcolumn,
            this.NAMEcolumn,
            this.SURNAMEcolumn,
            this.TYPEcolumn,
            this.PHONEcolumn,
            this.AdditionalColumn});
            this.dgvPeople.Location = new System.Drawing.Point(12, 180);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(647, 258);
            this.dgvPeople.TabIndex = 1;
            // 
            // IDcolumn
            // 
            this.IDcolumn.HeaderText = "ID";
            this.IDcolumn.Name = "IDcolumn";
            // 
            // NAMEcolumn
            // 
            this.NAMEcolumn.HeaderText = "Ime";
            this.NAMEcolumn.Name = "NAMEcolumn";
            // 
            // SURNAMEcolumn
            // 
            this.SURNAMEcolumn.HeaderText = "Prezime";
            this.SURNAMEcolumn.Name = "SURNAMEcolumn";
            // 
            // TYPEcolumn
            // 
            this.TYPEcolumn.HeaderText = "Tip";
            this.TYPEcolumn.Name = "TYPEcolumn";
            // 
            // PHONEcolumn
            // 
            this.PHONEcolumn.HeaderText = "Telefon";
            this.PHONEcolumn.Name = "PHONEcolumn";
            // 
            // AdditionalColumn
            // 
            this.AdditionalColumn.HeaderText = "Dodatno";
            this.AdditionalColumn.Name = "AdditionalColumn";
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btnFetchData);
            this.Name = "FormPeople";
            this.Text = "FormPeople";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMEcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURNAMEcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPEcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONEcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalColumn;
    }
}