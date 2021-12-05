namespace PharmacyAutomation
{
    partial class PhysicianForm
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
            this.dataPrescription = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMedicines = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonListPrescription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrescriptionID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMedicineID = new System.Windows.Forms.TextBox();
            this.buttonListMedicine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textMedicineName0 = new System.Windows.Forms.TextBox();
            this.textMedicineName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPatientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCreatePrescription = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPrescription
            // 
            this.dataPrescription.AllowUserToAddRows = false;
            this.dataPrescription.AllowUserToDeleteRows = false;
            this.dataPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrescription.Location = new System.Drawing.Point(12, 76);
            this.dataPrescription.Name = "dataPrescription";
            this.dataPrescription.ReadOnly = true;
            this.dataPrescription.RowTemplate.ReadOnly = true;
            this.dataPrescription.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPrescription.Size = new System.Drawing.Size(435, 362);
            this.dataPrescription.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prescriptions :";
            // 
            // dataMedicines
            // 
            this.dataMedicines.AllowUserToAddRows = false;
            this.dataMedicines.AllowUserToDeleteRows = false;
            this.dataMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMedicines.Location = new System.Drawing.Point(622, 76);
            this.dataMedicines.Name = "dataMedicines";
            this.dataMedicines.ReadOnly = true;
            this.dataMedicines.Size = new System.Drawing.Size(282, 362);
            this.dataMedicines.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(617, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medicines :";
            // 
            // buttonListPrescription
            // 
            this.buttonListPrescription.Location = new System.Drawing.Point(453, 415);
            this.buttonListPrescription.Name = "buttonListPrescription";
            this.buttonListPrescription.Size = new System.Drawing.Size(163, 23);
            this.buttonListPrescription.TabIndex = 5;
            this.buttonListPrescription.Text = "List";
            this.buttonListPrescription.UseVisualStyleBackColor = true;
            this.buttonListPrescription.Click += new System.EventHandler(this.buttonListPrescription_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Presciption ID :";
            // 
            // textPrescriptionID
            // 
            this.textPrescriptionID.Location = new System.Drawing.Point(457, 92);
            this.textPrescriptionID.Name = "textPrescriptionID";
            this.textPrescriptionID.Size = new System.Drawing.Size(159, 20);
            this.textPrescriptionID.TabIndex = 7;
            this.textPrescriptionID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPrescriptionID_MouseClick);
            this.textPrescriptionID.TextChanged += new System.EventHandler(this.textPrescriptionID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medicine ID:";
            // 
            // textMedicineID
            // 
            this.textMedicineID.Location = new System.Drawing.Point(913, 92);
            this.textMedicineID.Name = "textMedicineID";
            this.textMedicineID.Size = new System.Drawing.Size(143, 20);
            this.textMedicineID.TabIndex = 9;
            this.textMedicineID.TextChanged += new System.EventHandler(this.textMedicineID_TextChanged);
            // 
            // buttonListMedicine
            // 
            this.buttonListMedicine.Location = new System.Drawing.Point(913, 415);
            this.buttonListMedicine.Name = "buttonListMedicine";
            this.buttonListMedicine.Size = new System.Drawing.Size(147, 23);
            this.buttonListMedicine.TabIndex = 10;
            this.buttonListMedicine.Text = "List";
            this.buttonListMedicine.UseVisualStyleBackColor = true;
            this.buttonListMedicine.Click += new System.EventHandler(this.buttonListMedicine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medicine Name:";
            // 
            // textMedicineName0
            // 
            this.textMedicineName0.Location = new System.Drawing.Point(457, 132);
            this.textMedicineName0.Name = "textMedicineName0";
            this.textMedicineName0.Size = new System.Drawing.Size(159, 20);
            this.textMedicineName0.TabIndex = 12;
            this.textMedicineName0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textMedicineName0_MouseClick);
            this.textMedicineName0.TextChanged += new System.EventHandler(this.textMedicineName0_TextChanged);
            // 
            // textMedicineName1
            // 
            this.textMedicineName1.Location = new System.Drawing.Point(913, 132);
            this.textMedicineName1.Name = "textMedicineName1";
            this.textMedicineName1.Size = new System.Drawing.Size(143, 20);
            this.textMedicineName1.TabIndex = 14;
            this.textMedicineName1.TextChanged += new System.EventHandler(this.textMedicineName1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medicine Name:";
            // 
            // textPatientName
            // 
            this.textPatientName.Location = new System.Drawing.Point(457, 172);
            this.textPatientName.Name = "textPatientName";
            this.textPatientName.Size = new System.Drawing.Size(159, 20);
            this.textPatientName.TabIndex = 16;
            this.textPatientName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPatientName_MouseClick);
            this.textPatientName.TextChanged += new System.EventHandler(this.textPatientName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Patient Name:";
            // 
            // buttonCreatePrescription
            // 
            this.buttonCreatePrescription.Location = new System.Drawing.Point(12, 453);
            this.buttonCreatePrescription.Name = "buttonCreatePrescription";
            this.buttonCreatePrescription.Size = new System.Drawing.Size(145, 90);
            this.buttonCreatePrescription.TabIndex = 17;
            this.buttonCreatePrescription.Text = "Create Prescription";
            this.buttonCreatePrescription.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 435);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescriptions and Medicines";
            // 
            // PhysicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 555);
            this.Controls.Add(this.buttonCreatePrescription);
            this.Controls.Add(this.textPatientName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMedicineName1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMedicineName0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonListMedicine);
            this.Controls.Add(this.textMedicineID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrescriptionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonListPrescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataMedicines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPrescription);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhysicianForm";
            this.Text = "Physician Module";
            this.Load += new System.EventHandler(this.PhysicianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPrescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataMedicines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonListPrescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrescriptionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMedicineID;
        private System.Windows.Forms.Button buttonListMedicine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMedicineName0;
        private System.Windows.Forms.TextBox textMedicineName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPatientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCreatePrescription;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}