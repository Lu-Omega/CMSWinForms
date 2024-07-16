using CMSWinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinForms.UserControls
{
    public partial class UserRegistration : UserControl
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        private int employeeId;

        public UserRegistration(int empId)
        {
            InitializeComponent();
            employeeId = empId;
            InitializeBindings();
        }

        void InitializeBindings()
        {
            btnSave.Click += (s, e) =>
            {
                if (ValidateUserFields())
                {
                    CreateUser();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            };
        }

        private bool ValidateUserFields()
        {
            // Check if username and password are filled
            return !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void CreateUser()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserDetails (Username, PasswordHash, EmployeeId) " +
                               "VALUES (@Username, @PasswordHash, @EmployeeId)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text)); // Hash the password
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User registered successfully!");

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }

                LoginForm loginForm = new LoginForm();
                loginForm.Show(); // Close the registration form
            }
        }

        private string HashPassword(string password)
        {
            // Implement your hashing logic here (e.g., using SHA256 or BCrypt)
            // For example, using SHA256:
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
