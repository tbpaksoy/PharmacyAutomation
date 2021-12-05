using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyAutomation
{
    

    public partial class LogInForm : Form
    {
        SqlCommand command;
        SqlConnection connection = new SqlConnection("server=DESKTOP-27CFJT0; Initial Catalog=PharmacyAutomation;Integrated Security=SSPI");
        SqlDataReader reader;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogIn() 
        {
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM UserTable0 WHERE id='{textID.Text}'AND password='{textPassword.Text}'";
            reader = command.ExecuteReader();
            if (textID.Text!=null && textPassword.Text!=null && int.TryParse(textID.Text, out int asd) && reader.Read())
            {
                Hide();
                switch (reader["occupation"])
                {
                    case "Physician":
                        PhysicianForm physicianForm = new PhysicianForm();
                        physicianForm.Show();
                        break;
                    case "Pharmacist":
                        PharmacistForm pharmacistForm = new PharmacistForm();
                        pharmacistForm.Show();
                        break;
                }
            }
            connection.Close();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }
    }
}
