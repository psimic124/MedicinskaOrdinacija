namespace MedicinskaOrdinacija {
    partial class FormCartons {
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
            this.components = new System.ComponentModel.Container();
            this.dgvCartons = new System.Windows.Forms.DataGridView();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cbPatients = new System.Windows.Forms.ComboBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.rtbDiagnosis = new System.Windows.Forms.RichTextBox();
            this.lblTherapy = new System.Windows.Forms.Label();
            this.rtbTherapy = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.Terapija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagnozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKartonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartoniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOrdinacijaDataSet = new MedicinskaOrdinacija.MedOrdinacijaDataSet();
            this.kartoniTableAdapter = new MedicinskaOrdinacija.MedOrdinacijaDataSetTableAdapters.KartoniTableAdapter();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartoniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrdinacijaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartons
            // 
            this.dgvCartons.AutoGenerateColumns = false;
            this.dgvCartons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kartonIDDataGridViewTextBoxColumn,
            this.pacijentIDDataGridViewTextBoxColumn,
            this.dijagnozaDataGridViewTextBoxColumn,
            this.Terapija,
            this.datumKartonaDataGridViewTextBoxColumn});
            this.dgvCartons.DataSource = this.kartoniBindingSource;
            this.dgvCartons.Location = new System.Drawing.Point(111, 298);
            this.dgvCartons.Name = "dgvCartons";
            this.dgvCartons.Size = new System.Drawing.Size(546, 150);
            this.dgvCartons.TabIndex = 0;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(37, 30);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(128, 16);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Odaberite pacijenta:";
            // 
            // cbPatients
            // 
            this.cbPatients.FormattingEnabled = true;
            this.cbPatients.Location = new System.Drawing.Point(206, 25);
            this.cbPatients.Name = "cbPatients";
            this.cbPatients.Size = new System.Drawing.Size(173, 21);
            this.cbPatients.TabIndex = 2;
            this.cbPatients.SelectedIndexChanged += new System.EventHandler(this.cbPatients_SelectedIndexChanged);
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(37, 113);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(71, 16);
            this.lblDiagnosis.TabIndex = 3;
            this.lblDiagnosis.Text = "Dijagnoza:";
            // 
            // rtbDiagnosis
            // 
            this.rtbDiagnosis.Location = new System.Drawing.Point(206, 102);
            this.rtbDiagnosis.Name = "rtbDiagnosis";
            this.rtbDiagnosis.Size = new System.Drawing.Size(173, 133);
            this.rtbDiagnosis.TabIndex = 4;
            this.rtbDiagnosis.Text = "";
            // 
            // lblTherapy
            // 
            this.lblTherapy.AutoSize = true;
            this.lblTherapy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTherapy.Location = new System.Drawing.Point(452, 113);
            this.lblTherapy.Name = "lblTherapy";
            this.lblTherapy.Size = new System.Drawing.Size(61, 16);
            this.lblTherapy.TabIndex = 5;
            this.lblTherapy.Text = "Terapija:";
            // 
            // rtbTherapy
            // 
            this.rtbTherapy.Location = new System.Drawing.Point(575, 102);
            this.rtbTherapy.Name = "rtbTherapy";
            this.rtbTherapy.Size = new System.Drawing.Size(173, 133);
            this.rtbTherapy.TabIndex = 6;
            this.rtbTherapy.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(452, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Datum kartona:";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(575, 30);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(173, 20);
            this.dtp.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(192, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(582, 260);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // Terapija
            // 
            this.Terapija.DataPropertyName = "Terapija";
            this.Terapija.HeaderText = "Terapija";
            this.Terapija.Name = "Terapija";
            // 
            // kartonIDDataGridViewTextBoxColumn
            // 
            this.kartonIDDataGridViewTextBoxColumn.DataPropertyName = "KartonID";
            this.kartonIDDataGridViewTextBoxColumn.HeaderText = "KartonID";
            this.kartonIDDataGridViewTextBoxColumn.Name = "kartonIDDataGridViewTextBoxColumn";
            this.kartonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacijentIDDataGridViewTextBoxColumn
            // 
            this.pacijentIDDataGridViewTextBoxColumn.DataPropertyName = "PacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.HeaderText = "PacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.Name = "pacijentIDDataGridViewTextBoxColumn";
            // 
            // dijagnozaDataGridViewTextBoxColumn
            // 
            this.dijagnozaDataGridViewTextBoxColumn.DataPropertyName = "Dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.HeaderText = "Dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.Name = "dijagnozaDataGridViewTextBoxColumn";
            // 
            // datumKartonaDataGridViewTextBoxColumn
            // 
            this.datumKartonaDataGridViewTextBoxColumn.DataPropertyName = "DatumKartona";
            this.datumKartonaDataGridViewTextBoxColumn.HeaderText = "DatumKartona";
            this.datumKartonaDataGridViewTextBoxColumn.Name = "datumKartonaDataGridViewTextBoxColumn";
            // 
            // kartoniBindingSource
            // 
            this.kartoniBindingSource.DataMember = "Kartoni";
            this.kartoniBindingSource.DataSource = this.medOrdinacijaDataSet;
            // 
            // medOrdinacijaDataSet
            // 
            this.medOrdinacijaDataSet.DataSetName = "MedOrdinacijaDataSet";
            this.medOrdinacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartoniTableAdapter
            // 
            this.kartoniTableAdapter.ClearBeforeFill = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(501, 260);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FormCartons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rtbTherapy);
            this.Controls.Add(this.lblTherapy);
            this.Controls.Add(this.rtbDiagnosis);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.cbPatients);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dgvCartons);
            this.Name = "FormCartons";
            this.Text = "FormCartons";
            this.Load += new System.EventHandler(this.FormCartons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartoniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrdinacijaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartons;
        private MedOrdinacijaDataSet medOrdinacijaDataSet;
        private System.Windows.Forms.BindingSource kartoniBindingSource;
        private MedOrdinacijaDataSetTableAdapters.KartoniTableAdapter kartoniTableAdapter;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cbPatients;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.RichTextBox rtbDiagnosis;
        private System.Windows.Forms.Label lblTherapy;
        private System.Windows.Forms.RichTextBox rtbTherapy;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagnozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terapija;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKartonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnShow;
    }
}