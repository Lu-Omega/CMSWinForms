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

namespace CMSWinForms.UserControls
{
    public partial class AddEmployee : UserControl
    {
        private string connectionString = "Server=Thando-LT\\SQLEXPRESS;Database=PRISM;Trusted_Connection=True;";
        public AddEmployee()
        {
            InitializeComponent();
            initializeBindings();
        }

        void initializeBindings()
        {
            PlaceHolders();
            AddContacts();

        }

        void PlaceHolders()
        {
            txtName.PlaceholderText = "Name";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtSurname.PlaceholderText = "Surname";
            txtEmail.PlaceholderText = "Email";
            txtAddress.PlaceholderText = "Äddress";
            txtPhoneNumber.PlaceholderText = "Phone Number";

            txtPhoneNumber.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        void AddContacts()
        {
            btnSave.Click += (s, e) =>
            {
                string firstName = txtName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtSurname.Text;
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                int phoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                DateTime dateOfBirth = dtpDateOfBirth.Value;

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(middleName))
                {
                    MessageBox.Show("Middle name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

                if (phoneNumber == 0) // Assuming phoneNumber can't be 0
                {
                    MessageBox.Show("Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Focus();
                    return;
                }

                if (dateOfBirth == DateTime.MinValue) // Check if dateOfBirth is not default value
                {
                    MessageBox.Show("Date of birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDateOfBirth.Focus();
                    return;
                }

                // All validations passed, proceed with database save
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Employees(FirstName, MiddleName, LastName, Email, EmployeeAddress, PhoneNumber, DateOfBirth) VALUES (@FirstName, @MiddleName, @LastName, @Email, @EmployeeAddress, @PhoneNumber, @DateOfBirth)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", middleName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@EmployeeAddress", address);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            };
        }
    }
}
