﻿using CMSWinForms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CMSWinForms
{
    public partial class PRISM2 : Form
    {
        #region Constants
        private string _connectionString;

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        bool _useTrainingDb = Convert.ToBoolean(0); //1 = training db
        string _dbName = string.Empty;
        #endregion Constants
        bool sidebarExpand;
        EmployeeHomePage _employeeHomePage;
        AddEmployee _addEmployee;
        ViewEmployees _viewEmployee;
        DeleteEmployee _deleteEmployee;

        #region Instance Fields
        /*//Menu Item Groups
        ToolStripMenuItem _employeesMenuItem = new ToolStripMenuItem("Employees");

        //Menu Sub Items
        ToolStripMenuItem _subAddEmployees = new ToolStripMenuItem("Add Employees");
        ToolStripMenuItem _viewEmployeeMenuItem = new ToolStripMenuItem("View Employee");*/



        #endregion Instance Fields

        #region Constructor
        public PRISM2()
        {
            InitializeComponent();
            InitializeBindings();
        }
        #endregion Constructor

        #region Internal Classes
        public class SubMenuItem
        {
            public string Text { get; set; }
            public EventHandler ClickHandler { get; set; }

            public SubMenuItem(string text, EventHandler clickHandler)
            {
                Text = text;
                ClickHandler = clickHandler;
            }
        }
        #endregion Internal Classes

        #region Private Methods

        void InitializeBindings()
        {
            //CreateMenuItems();
            InitializeMenus();
            SetConnectionStingEtAl();
        }
        bool SetConnectionStingEtAl()
        {
            //choose between live and test db
            if (!_useTrainingDb && _dbName == "Production") //false
            {
                _connectionString = System.Configuration.ConfigurationManager
                    .ConnectionStrings["PRISM"].ConnectionString;
            }
            else if (_useTrainingDb && _dbName == "Test") //true
            {
                _connectionString = System.Configuration.ConfigurationManager
                    .ConnectionStrings["PRISM_Test"].ConnectionString;
            }

            return true;

        }
        void InitializeMenus()
        {
            subAddEmployee.Click += (s, e) => LoadMenuItemNew(_addEmployee, typeof(AddEmployee));
            subViewEmployees.Click += (s, e) => LoadMenuItemNew(_viewEmployee, typeof(ViewEmployees));
            subDeleteEmployees.Click += (s, e) => LoadMenuItemNew(_deleteEmployee, typeof(DeleteEmployee));
        }


        #endregion Private Methods

        #region LoadUserControl


        UserControl LoadMenuItemNew(UserControl menuItem, Type type, params object[] param)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                // Remove and dispose the current user control
                if (menuItem != null)
                {
                    panel3.Controls.Remove(menuItem);
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
            panel3.Controls.Clear();
            panel3.Controls.Add(menuItem);

            return menuItem;
        }
        #endregion LoadUserControl

        #region Events
        #endregion Events
    }
}
