﻿namespace MedicinskaOrdinacija {
    partial class FormSchedules {
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
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.medOrdinacijaDataSet = new MedicinskaOrdinacija.MedOrdinacijaDataSet();
            this.terminiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terminiTableAdapter = new MedicinskaOrdinacija.MedOrdinacijaDataSetTableAdapters.TerminiTableAdapter();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cbPatients = new System.Windows.Forms.ComboBox();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblTip = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.pacijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrdinacijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AutoGenerateColumns = false;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacijentIDDataGridViewTextBoxColumn,
            this.terminIDDataGridViewTextBoxColumn,
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.doktorIDDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dgvSchedules.DataSource = this.terminiBindingSource;
            this.dgvSchedules.Location = new System.Drawing.Point(125, 303);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.Size = new System.Drawing.Size(546, 150);
            this.dgvSchedules.TabIndex = 0;
            // 
            // medOrdinacijaDataSet
            // 
            this.medOrdinacijaDataSet.DataSetName = "MedOrdinacijaDataSet";
            this.medOrdinacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terminiBindingSource
            // 
            this.terminiBindingSource.DataMember = "Termini";
            this.terminiBindingSource.DataSource = this.medOrdinacijaDataSet;
            // 
            // terminiTableAdapter
            // 
            this.terminiTableAdapter.ClearBeforeFill = true;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(44, 43);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(128, 16);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Odaberite pacijenta:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(44, 111);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(119, 16);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Odaberite doktora:";
            // 
            // cbPatients
            // 
            this.cbPatients.FormattingEnabled = true;
            this.cbPatients.Location = new System.Drawing.Point(240, 43);
            this.cbPatients.Name = "cbPatients";
            this.cbPatients.Size = new System.Drawing.Size(176, 21);
            this.cbPatients.TabIndex = 3;
            // 
            // cbDoctors
            // 
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(240, 110);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(176, 21);
            this.cbDoctors.TabIndex = 4;
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(44, 193);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Odaberite datum:";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(240, 193);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(176, 20);
            this.dtp.TabIndex = 6;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(471, 44);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(78, 16);
            this.lblTip.TabIndex = 7;
            this.lblTip.Text = "Napomena:";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(571, 44);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(194, 198);
            this.rtbNote.TabIndex = 8;
            this.rtbNote.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(206, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(287, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(474, 252);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show all";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pacijentIDDataGridViewTextBoxColumn
            // 
            this.pacijentIDDataGridViewTextBoxColumn.DataPropertyName = "PacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.HeaderText = "PacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.Name = "pacijentIDDataGridViewTextBoxColumn";
            // 
            // terminIDDataGridViewTextBoxColumn
            // 
            this.terminIDDataGridViewTextBoxColumn.DataPropertyName = "TerminID";
            this.terminIDDataGridViewTextBoxColumn.HeaderText = "TerminID";
            this.terminIDDataGridViewTextBoxColumn.Name = "terminIDDataGridViewTextBoxColumn";
            this.terminIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            // 
            // doktorIDDataGridViewTextBoxColumn
            // 
            this.doktorIDDataGridViewTextBoxColumn.DataPropertyName = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.HeaderText = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.Name = "doktorIDDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // FormSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbDoctors);
            this.Controls.Add(this.cbPatients);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dgvSchedules);
            this.Name = "FormSchedules";
            this.Text = "FormSchedules";
            this.Load += new System.EventHandler(this.FormSchedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrdinacijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedules;
        private MedOrdinacijaDataSet medOrdinacijaDataSet;
        private System.Windows.Forms.BindingSource terminiBindingSource;
        private MedOrdinacijaDataSetTableAdapters.TerminiTableAdapter terminiTableAdapter;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cbPatients;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
    }
}