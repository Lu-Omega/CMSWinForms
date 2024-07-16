using CMSWinForms.Helpers;
using CMSWinForms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinForms
{
    public partial class LoginForm : Form
    {
        UserRegistration _userRegistration;
        EmployeeRegistration _employeeRegistration = null;
        UserSignin _userSignin;
        private string _prismCconnectionString;
        private bool _useTrainingDb; // Set this based on your logic
        private string _dbName;
        public LoginForm()
        {
            InitializeComponent();
            InitializeBindings();
        }

        #region Private Methods
        void InitializeBindings()
        {
            btnRegister.Click += (s, e) => _employeeRegistration = LoadMenuItemNew(_employeeRegistration, typeof(EmployeeRegistration)) as EmployeeRegistration;
            btnLogin.Click += (s, e) =>  _userSignin = LoadMenuItemNew(_userSignin, typeof(UserSignin)) as UserSignin;
        }
        UserControl LoadMenuItemNew(UserControl menuItem, Type type, params object[] param)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                // Remove and dispose the current user control
                if (menuItem != null)
                {
                    panel1.Controls.Remove(menuItem);
                    menuItem.Dispose();
                    menuItem = null;
                }
            }

            // Create a new instance of the user control if not already initialized
            if (menuItem == null)
            {
                menuItem = Activator.CreateInstance(type, param) as UserControl;
                menuItem.Dock = DockStyle.Fill;
            }

            // Clear existing controls in panel and add the new user control
            panel1.Controls.Clear();
            panel1.Controls.Add(menuItem);

            return menuItem;
        }

        #endregion Private Methods
        
    }
}
