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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMSWinForms.UserControls
{
    public partial class DeleteEmployee : UserControl
    {
        private string connectionString = "Server=Thando-LT\\SQLEXPRESS;Database=PRISM;Trusted_Connection=True;";
        string query = "SELECT EmployeeId, FirstName, MiddleName, LastName, Email, EmployeeAddress, PhoneNumber, DateOfBirth from Employees";
        public DeleteEmployee()
        {
            InitializeComponent();
            InitializeBindings();
        }

        #region Private Methods
        void InitializeBindings()
        {
            PopulateEditors();
            btnDelete.Click += (s, e) =>
            {
                if(cbxEmployee.SelectedValue != null)
                {
                    int selectedEmployeeId = (int)cbxEmployee.SelectedValue;
                    RemoveEmployee(selectedEmployeeId);
                    ClearTextFields();
                    PopulateEditors();
                }
                
            };
        }

        void PopulateEditors()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            cbxEmployee.DataSource = dataTable;
            cbxEmployee.DisplayMember = "FirstName";
            cbxEmployee.ValueMember = "EmployeeId";
            cbxEmployee.SelectedIndexChanged += (s, e) =>
            {
                if (cbxEmployee.SelectedValue != null)
                {
                    int selectedEmployeeId = (int)cbxEmployee.SelectedValue;
                    PopulateEmployeeDetails(selectedEmployeeId);
                }
            };
        }

        void PopulateEmployeeDetails(int employeeId)
        {
            string employeeQuery = "SELECT FirstName, MiddleName, LastName, Email, EmployeeAddress, PhoneNumber, DateOfBirth FROM Employees WHERE EmployeeId = @EmployeeId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(employeeQuery, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtName.Text = reader["FirstName"].ToString();
                        txtMiddleName.Text = reader["MiddleName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtAddress.Text = reader["EmployeeAddress"].ToString();
                        txtNumber.Text = reader["PhoneNumber"].ToString();
                        txtDob.Text = Convert.ToDateTime(reader["DateOfBirth"]).ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        void RemoveEmployee(int employeeId)
        {
            string deleteQuery = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        void ClearTextFields()
        {
            txtName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtNumber.Text = "";
            txtDob.Text = "";
        }
        #endregion Private Methods
    }
}
