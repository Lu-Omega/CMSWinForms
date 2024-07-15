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
        }
        #endregion Private Methods
    }
}
