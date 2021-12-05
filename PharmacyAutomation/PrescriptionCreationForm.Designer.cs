namespace PharmacyAutomation
{
    partial class PrescriptionCreationForm
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
            this.dataMedicines = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textPatientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrescriptionID = new System.Windows.Forms.TextBox();
            this.dataPrescripted = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescripted)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMedicines
            // 
            this.dataMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMedicines.Location = new System.Drawing.Point(12, 36);
            this.dataMedicines.Name = "dataMedicines";
            this.dataMedicines.Size = new System.Drawing.Size(272, 402);
            this.dataMedicines.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine List:";
            // 
            // textPatientID
            // 
            this.textPatientID.Location = new System.Drawing.Point(544, 52);
            this.textPatientID.Name = "textPatientID";
            this.textPatientID.Size = new System.Drawing.Size(246, 20);
            this.textPatientID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count:";
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(544, 91);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(246, 20);
            this.textCount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prescription ID:";
            // 
            // textPrescriptionID
            // 
            this.textPrescriptionID.Location = new System.Drawing.Point(544, 130);
            this.textPrescriptionID.Name = "textPrescriptionID";
            this.textPrescriptionID.Size = new System.Drawing.Size(246, 20);
            this.textPrescriptionID.TabIndex = 6;
            // 
            // dataPrescripted
            // 
            this.dataPrescripted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrescripted.Location = new System.Drawing.Point(291, 36);
            this.dataPrescripted.Name = "dataPrescripted";
            this.dataPrescripted.Size = new System.Drawing.Size(240, 402);
            this.dataPrescripted.TabIndex = 8;
            // 
            // PrescriptionCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPrescripted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrescriptionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataMedicines);
            this.Name = "PrescriptionCreationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescripted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMedicines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrescriptionID;
        private System.Windows.Forms.DataGridView dataPrescripted;
    }
}