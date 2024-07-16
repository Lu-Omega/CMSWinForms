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
    public partial class UserSignin : UserControl
    {
        private string connectionString = DatabaseConfig.ConnectionString;

        public UserSignin()
        {
            InitializeComponent();
            InitializeBindings();
        }

        #region Private Methods
        void InitializeBindings()
        {
            btnLogin.Click += (s, e) => Login();
        }

        private void Login()
        {
            if (ValidateLoginFields())
            {
                if (AuthenticateUser(txtUsername.Text, txtPassword.Text))
                {
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }
                    PRISM2 mainForm = new PRISM2();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private bool ValidateLoginFields()
        {
            // Check if username and password are filled
            return !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PasswordHash FROM UserDetails WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string storedPasswordHash = result.ToString();
                    string enteredPasswordHash = HashPassword(password);
                    return storedPasswordHash == enteredPasswordHash;
                }
                else
                {
                    return false;
                }
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
        #endregion Private Methods
    }
}
