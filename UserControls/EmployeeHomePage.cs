using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinForms.UserControls
{
    public partial class EmployeeHomePage : UserControl
    {
        public event EventHandler AddEmployeeClicked;

        public EmployeeHomePage()
        {
            InitializeComponent();
            InitializeBindings();
        }

        void InitializeBindings()
        {
            btnAddEmployee.Click += (s, e) =>
            {
                AddEmployeeClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
