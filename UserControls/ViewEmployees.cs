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
        private Dictionary<int, DataGridViewRow> modifiedRows = new Dictionary<int, DataGridViewRow>();
        public ViewEmployees()
        {
            InitializeComponent();
            InitializeBindings();
        }

        #region Private Methods

        void InitializeBindings()
        {

            ViewContacts();
            dataGridView1.ReadOnly = true;
            chkEdit.CheckedChanged += (s, e) =>
            {
                bool editModeEnabled = chkEdit.Checked;

                dataGridView1.ReadOnly = !editModeEnabled;
                dataGridView1.AllowUserToAddRows = false;

                btnSave.Enabled = editModeEnabled;
            };

            dataGridView1.CellEndEdit += (s, e) =>
            {
                if (chkEdit.Checked)
                {
                    // Store the modified row for saving later
                    int employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                    modifiedRows[employeeId] = dataGridView1.Rows[e.RowIndex];

                    // Enable the Save button
                    btnSave.Enabled = true;


                }
            };

            btnSave.Click += (s, e) =>
            {
                SaveChanges();
            };
            

        }
        void SaveChanges()
        {
            foreach (var row in modifiedRows.Values)
            {
                // Get updated values from the stored modified row
                string firstName = row.Cells["FirstName"].Value.ToString();
                string middleName = row.Cells["MiddleName"].Value.ToString();
                string lastName = row.Cells["LastName"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string address = row.Cells["EmployeeAddress"].Value.ToString();
                int phoneNumber = Convert.ToInt32(row.Cells["PhoneNumber"].Value);
                DateTime dateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                int employeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value); // Ensure EmployeeId is included

                // Update the record in the database
                UpdateEmployee(employeeId, firstName, middleName, lastName, email, address, phoneNumber, dateOfBirth);
            }

            // Clear the modified rows and disable the Save button after saving
            modifiedRows.Clear();
        }
        void ViewContacts()
        {
            string query = "SELECT EmployeeId, FirstName, MiddleName, LastName, Email, EmployeeAddress, PhoneNumber, DateOfBirth from Employees";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                // Change the header text of the columns
                dataGridView1.Columns["EmployeeId"].HeaderText = "Employee Id";
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
