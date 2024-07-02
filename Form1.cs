using System.Data;
using System.Data.SqlClient;

namespace CMSWinForms
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=Thando-LT\\SQLEXPRESS;Database=ToDoListDB;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            InitializeBindings();
        }

        void InitializeBindings()
        {
            LoadContacts();
            btnAdd.Click += (s, e) =>
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string number = txtPhone.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Contacts (FirstName, LastName, Email, Phone) VALUES (@FirstName, @LastName, @Email, @Phone)";
                    SqlCommand cmd = new SqlCommand (query, con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", number);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                LoadContacts();
            };

            btnDelete.Click += (s, e) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "Delete FROM Contacts WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", selectedId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a contact to delete", "Warning");
                }
            };
        }

        void LoadContacts()
        {
            string query = "SELECT Id, FirstName, LastName, Email, Phone FROM Contacts";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
