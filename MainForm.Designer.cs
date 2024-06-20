namespace MedicinskaOrdinacija {
    partial class MainForm {
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.btnCartons = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(195, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Medicinska Ordinacija";
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(60, 174);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(190, 63);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Upravljaj Pacijentima";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedules.Location = new System.Drawing.Point(471, 323);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(190, 63);
            this.btnSchedules.TabIndex = 2;
            this.btnSchedules.Text = "Upravljaj Terminima";
            this.btnSchedules.UseVisualStyleBackColor = false;
            // 
            // btnCartons
            // 
            this.btnCartons.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCartons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartons.Location = new System.Drawing.Point(60, 323);
            this.btnCartons.Name = "btnCartons";
            this.btnCartons.Size = new System.Drawing.Size(190, 63);
            this.btnCartons.TabIndex = 3;
            this.btnCartons.Text = "Upravljaj Med. Kartonima";
            this.btnCartons.UseVisualStyleBackColor = false;
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Location = new System.Drawing.Point(471, 174);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(190, 63);
            this.btnDoctors.TabIndex = 4;
            this.btnDoctors.Text = "Upravljaj Doktorima";
            this.btnDoctors.UseVisualStyleBackColor = false;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnDoctors);
            this.Controls.Add(this.btnCartons);
            this.Controls.Add(this.btnSchedules);
            this.Controls.Add(this.btnPatients);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.Button btnCartons;
        private System.Windows.Forms.Button btnDoctors;
    }
}

