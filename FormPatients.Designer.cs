namespace MedicinskaOrdinacija {
    partial class FormPatients {
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.pacijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povijestBolestiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOrdinacijaDataSet = new MedicinskaOrdinacija.MedOrdinacijaDataSet();
            this.pacijentiTableAdapter = new MedicinskaOrdinacija.MedOrdinacijaDataSetTableAdapters.PacijentiTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrdinacijaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(174, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(26, 214);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefon:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(26, 167);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(54, 16);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adresa:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(26, 120);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(98, 16);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Datum rođenja:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(26, 76);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(59, 16);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Prezime:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(174, 76);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(204, 20);
            this.tbSurname.TabIndex = 6;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(174, 120);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(204, 20);
            this.dtp.TabIndex = 7;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(174, 167);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(204, 20);
            this.tbAdress.TabIndex = 8;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(174, 213);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(204, 20);
            this.tbPhone.TabIndex = 9;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(587, 28);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(101, 16);
            this.lblHistory.TabIndex = 10;
            this.lblHistory.Text = "Povijest bolesti:";
            // 
            // rtbHistory
            // 
            this.rtbHistory.Location = new System.Drawing.Point(518, 75);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.Size = new System.Drawing.Size(240, 158);
            this.rtbHistory.TabIndex = 11;
            this.rtbHistory.Text = "";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacijentIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumRodjenjaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.povijestBolestiDataGridViewTextBoxColumn});
            this.dgvPatients.DataSource = this.pacijentiBindingSource;
            this.dgvPatients.Location = new System.Drawing.Point(29, 288);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(759, 160);
            this.dgvPatients.TabIndex = 12;
            // 
            // pacijentIDDataGridViewTextBoxColumn
            // 
            this.pacijentIDDataGridViewTextBoxColumn.DataPropertyName = "PacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.HeaderText = "PacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.Name = "pacijentIDDataGridViewTextBoxColumn";
            this.pacijentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // datumRodjenjaDataGridViewTextBoxColumn
            // 
            this.datumRodjenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.HeaderText = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.Name = "datumRodjenjaDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // povijestBolestiDataGridViewTextBoxColumn
            // 
            this.povijestBolestiDataGridViewTextBoxColumn.DataPropertyName = "PovijestBolesti";
            this.povijestBolestiDataGridViewTextBoxColumn.HeaderText = "PovijestBolesti";
            this.povijestBolestiDataGridViewTextBoxColumn.Name = "povijestBolestiDataGridViewTextBoxColumn";
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataMember = "Pacijenti";
            this.pacijentiBindingSource.DataSource = this.medOrdinacijaDataSet;
            // 
            // medOrdinacijaDataSet
            // 
            this.medOrdinacijaDataSet.DataSetName = "MedOrdinacijaDataSet";
            this.medOrdinacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacijentiTableAdapter
            // 
            this.pacijentiTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.rtbHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "FormPatients";
            this.Text = "FormPatients";
            this.Load += new System.EventHandler(this.FormPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOrdinacijaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.DataGridView dgvPatients;
        private MedOrdinacijaDataSet medOrdinacijaDataSet;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private MedOrdinacijaDataSetTableAdapters.PacijentiTableAdapter pacijentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povijestBolestiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}