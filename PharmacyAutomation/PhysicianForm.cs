using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PharmacyAutomation
{

    public partial class PhysicianForm : Form
    {
        SqlCommand command;
        SqlConnection connection = new SqlConnection("server=DESKTOP-27CFJT0; Initial Catalog=PharmacyAutomation;Integrated Security=SSPI");
        SqlDataAdapter adapter;
        public enum SearchPrescriptionBy 
        {
            Null,PrescriptionID, MedicineName, PatientName
        }
        SearchPrescriptionBy preSearchState = SearchPrescriptionBy.Null;
        private enum ListMedicinesBy 
        {
           Name, ID
        }
        private ListMedicinesBy listMedicinesBy = ListMedicinesBy.ID;

        public PhysicianForm()
        {
            InitializeComponent();
        }

        private void PhysicianForm_Load(object sender, EventArgs e)
        {
            LoadPrescriptionsAndMedicines();
        }

        private void LoadPrescriptionsAndMedicines() 
        {
            connection.Open();
            command = new SqlCommand("SELECT * FROM MedicineTable0", connection);
            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataMedicines.DataSource = dataTable;
            string tableNames = "PrescriptionTable0,PatientTable,MedicineTable0";
            string terms =
                "PrescriptionTable0.patientID = PatientTable.patiendID " +
                "AND " +
                "PrescriptionTable0.medicineID = MedicineTable0.medicineID";
            string columns =
                "prescriptionID AS PrescriptionID," +
                "CONCAT(firstName,' ', lastName) AS FullName," +
                "medicineName AS MedicineName," +
                "count";
            command = new SqlCommand($"SELECT {columns} FROM {tableNames} WHERE {terms}", connection);
            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataPrescription.DataSource = dataTable;
            connection.Close();
        }

        private void ListPrescriptions()
        {

            if (preSearchState != SearchPrescriptionBy.Null)
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                string tableNames = "PrescriptionTable0,PatientTable,MedicineTable0";
                string terms =
                    "PrescriptionTable0.patientID = PatientTable.patiendID " +
                    "AND " +
                    "PrescriptionTable0.medicineID = MedicineTable0.medicineID";
                string columns =
                    "prescriptionID AS PrescriptionID," +
                    "CONCAT(firstName,' ', lastName) AS FullName," +
                    "medicineName AS MedicineName," +
                    "count";
                string searchTerm = null;
                switch (preSearchState)
                {
                    case SearchPrescriptionBy.MedicineName:
                        if (textMedicineName0.Text.Length > 0)
                            searchTerm = $" AND medicineName LIKE '%{textMedicineName0.Text}%'";
                        break;
                    case SearchPrescriptionBy.PrescriptionID:
                        if (textPrescriptionID.Text.Length > 0)
                            searchTerm = $" AND prescriptionID = {textPrescriptionID.Text}";
                        break;
                    case SearchPrescriptionBy.PatientName:
                        if (textPatientName.Text.Length > 0)
                            searchTerm = $" AND (firstName LIKE '%{textPatientName.Text}%' OR lastName LIKE '%{textPatientName.Text}%')";
                        break;
                }
                command = new SqlCommand($"SELECT {columns} FROM {tableNames} WHERE {terms} {searchTerm}", connection);
                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataPrescription.DataSource = dataTable;
                connection.Close();

            }
        }

        private void ListMedicines() 
        {
            connection.Open();
            string searchTerm = null;
            switch (listMedicinesBy) 
            {
                case ListMedicinesBy.Name:
                    if (textMedicineName1.Text.Length > 0)
                        searchTerm = $" WHERE medicineName LIKE '%{textMedicineName1.Text}%'";
                    break;
                case ListMedicinesBy.ID:
                    if (textMedicineID.Text.Length > 0)
                        searchTerm = $" WHERE medicineID = {textMedicineID.Text}" ;
                    break;
            }
            command = new SqlCommand($"SELECT * FROM MedicineTable0 {searchTerm}", connection);
            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataMedicines.DataSource = dataTable;
            connection.Close();
        }

        private void buttonListPrescription_Click(object sender, EventArgs e)
        {
            ListPrescriptions();
        }

        private void textPrescriptionID_MouseClick(object sender, MouseEventArgs e)
        {
            preSearchState = SearchPrescriptionBy.PrescriptionID;
            textMedicineName0.Text = null;
            textPatientName.Text = null;
        }

        private void textMedicineName0_MouseClick(object sender, MouseEventArgs e)
        {
            preSearchState = SearchPrescriptionBy.MedicineName;
            textPatientName.Text = null;
            textPrescriptionID.Text = null;
        }

        private void textPrescriptionID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textPrescriptionID.Text, out int result))
                ListPrescriptions();
        }

        private void textMedicineID_TextChanged(object sender, EventArgs e)
        {
            listMedicinesBy = ListMedicinesBy.ID;
        }

        private void textMedicineName1_TextChanged(object sender, EventArgs e)
        {
            listMedicinesBy = ListMedicinesBy.Name;
        }

        private void buttonListMedicine_Click(object sender, EventArgs e)
        {
            ListMedicines();
        }

        private void textPatientName_MouseClick(object sender, MouseEventArgs e)
        {
            preSearchState = SearchPrescriptionBy.PatientName;
            textMedicineName0.Text = null;
            textPrescriptionID.Text = null;
        }

        private void textMedicineName0_TextChanged(object sender, EventArgs e)
        {
            ListPrescriptions();
        }

        private void textPatientName_TextChanged(object sender, EventArgs e)
        {
            ListPrescriptions();
        }
    }
}
