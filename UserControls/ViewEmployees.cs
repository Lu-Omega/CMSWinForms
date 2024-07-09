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
    public partial class ViewEmployees : UserControl
    {
        private string connectionString = "Server=Thando-LT\\SQLEXPRESS;Database=PRISM;Trusted_Connection=True;";
        public ViewEmployees()
        {
            InitializeComponent();
            InitializeBindings();
        }

        #region Private Methods

        void InitializeBindings()
        {
            ViewContacts();
        }

        void ViewContacts()
        {
            string query = "SELECT FirstName, MiddleName, LastName, Email, EmployeeAddress, PhoneNumber, DateOfBirth from Employees";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                // Change the header text of the columns
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["EmployeeAddress"].HeaderText = "Address";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "Phone Number";
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            }
            
        }

        void UpdateEmployee(int employeeId, string firstName, string middleName, string lastName, string email, string address, int phoneNumber, DateTime dateOfBirth)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employees SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Email = @Email, EmployeeAddress = @EmployeeAddress, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth WHERE EmployeeId = @EmployeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
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
        }
        #endregion Private Methods
    }
}
