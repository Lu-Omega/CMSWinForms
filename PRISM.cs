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
    public partial class PRISM : Form
    {
        bool sidebarExpand;
        EmployeeHomePage _employeeHomePage;
        AddEmployee _addEmployee;
        public PRISM()
        {
            InitializeComponent();
            InitializeBindings();
            InitializeMenus();
        }

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

        #region Private Methods

        void InitializeBindings()
        {
            expandMenuBar();
            InitializeUserControls();
        }

        void InitializeUserControls()
        {
            /*btnEmployee.Click += (s, e) =>
            {
                LoadMenuItemNew(_employeeHomePage, typeof(EmployeeHomePage));
            };*/
            

            /*_employeeHomePage.AddEmployeeClicked += (s, e) =>
            {
                LoadMenuItemNew(_addEmployee, typeof(AddEmployee));
            };*/
        }

        void InitializeMenus()
        {
            sidebar = new FlowLayoutPanel();
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Dock = DockStyle.Left;
            sidebar.BackColor = Color.FromArgb(41, 44, 51);
            sidebar.Width = 200;

            this.Controls.Add(sidebar);

            //AddMainMenuItem("Employee", (sender, e) => LoadMenuItemNew(_addEmployee, typeof(AddEmployee)));
            
            // Submenu item for Add Employee
            AddMainMenuItemWithSubMenu("Employees", new[] 
            {
                new SubMenuItem("Add Employees", (sender, e) => LoadMenuItemNew(_addEmployee, typeof(AddEmployee)))
            });

        }
        private void AddMainMenuItem(string text, EventHandler clickHandler)
        {
            Button menuItem = CreateMenuItem(text, clickHandler);
            sidebar.Controls.Add(menuItem);
        }

        private void AddMainMenuItemWithSubMenu(string text, SubMenuItem[] subMenuItems)
        {
            Panel mainPanel = new Panel { AutoSize = true };

            Button mainMenuItem = CreateMenuItem(text, null); // No direct action for main menu item
            mainPanel.Controls.Add(mainMenuItem);

            FlowLayoutPanel subMenuPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Visible = false // Initially hide the sub menu
            };

            mainMenuItem.Click += (sender, e) =>
            {
                foreach (var subMenuItem in subMenuItems)
                {
                    Button subMenuItemButton = CreateMenuItem(subMenuItem.Text, subMenuItem.ClickHandler);
                    subMenuPanel.Controls.Add(subMenuItemButton);

                }
                subMenuPanel.Visible = !subMenuPanel.Visible; // Toggle sub menu visibility
                Console.WriteLine($"Submenu visibility for '{text}' toggled to {subMenuPanel.Visible}");
            };

            mainPanel.Controls.Add(subMenuPanel);
            sidebar.Controls.Add(mainPanel);
        }

        private Button CreateMenuItem(string text, EventHandler clickHandler)
        {
            Button menuItem = new Button();
            menuItem.Text = text;
            menuItem.ForeColor = Color.White; // Example text color
            menuItem.BackColor = Color.Transparent; // Example background color
            menuItem.FlatStyle = FlatStyle.Flat; // Example flat style
            menuItem.FlatAppearance.BorderSize = 0; // Example no border
            menuItem.Padding = new Padding(0); // Example padding
            menuItem.Margin = new Padding(0, 0, 0, 0); // Example margin
            menuItem.TextAlign = ContentAlignment.MiddleLeft; // Example alignment
            menuItem.Width = sidebar.Width; // Example width
            menuItem.AutoSize = true; // Adjust width based on text

            if (clickHandler != null)
            {
                menuItem.Click += clickHandler;
            }

            return menuItem;
        }


        void expandMenuBar()
        {
            menuButton.Click += (s, e) =>
            {
                sideBarTimer.Start();
            };
        }

        #endregion Private Methods

        #region LoadUserControl

        /*void LoadUserControl(UserControl userControl)
        {
            panel3.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panel3.Controls.Add(userControl);
        }*/
        
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
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }
        #endregion Events

    }
}
