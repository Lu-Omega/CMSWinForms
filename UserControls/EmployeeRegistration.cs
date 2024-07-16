using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMSWinForms.UserControls
{
    public partial class EmployeeRegistration : UserControl
    {
        // Your connection string
        private string connectionString = "Server=Thando-LT\\SQLEXPRESS;Database=PRISM;Trusted_Connection=True;";

        public EmployeeRegistration()
        {
            InitializeComponent();
            InitializeBindings();
        }

        void InitializeBindings()
        {
            btnRegister.Click += (s, e) =>
            {
                // Validate input fields
                if (ValidateFields())
                {
                    AddEmployee();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            };
            //cmd.ExecuteNonQuery();
        }

        private bool ValidateFields()
        {
            // Check if all required fields are filled
            return !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                   !string.IsNullOrWhiteSpace(txtMiddleName.Text) &&
                   !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                   !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                   !string.IsNullOrWhiteSpace(txtNumber.Text) &&
                   dtpDOB.Value != default(DateTime);
        }

        private void AddEmployee()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employees (FirstName, MiddleName, LastName, Email, EmployeeAddress, PhoneNumber, DateOfBirth) " +
                               "VALUES (@FirstName, @MiddleName, @LastName, @Email, @EmployeeAddress, @PhoneNumber, @DateOfBirth);" +
                               "SELECT SCOPE_IDENTITY();"; // Get the new EmployeeId

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@EmployeeAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtNumber.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(dtpDOB.Value));

                conn.Open();
                int newEmployeeId = Convert.ToInt32(cmd.ExecuteScalar());

                // After adding employee, prompt for username/password
                UserRegistration newUserReg = new UserRegistration(newEmployeeId);

                // Create a new form to host the UserRegistration
                Form registrationForm = new Form
                {
                    Text = "User Registration",
                    Size = new Size(400, 300), // Set size as needed
                    StartPosition = FormStartPosition.CenterParent
                };
                registrationForm.Controls.Add(newUserReg);
                newUserReg.Dock = DockStyle.Fill; // Fill the form with the user control

                registrationForm.ShowDialog(); // Show the form as a dialog
            }
        }

    }
}
