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
        public PRISM()
        {
            InitializeComponent();
            InitializeBindings();
        }

        #region Private Methods

        void InitializeBindings()
        {
            expandMenuBar();
        }

        void expandMenuBar()
        {
            menuButton.Click += (s, e) =>
            {
                sideBarTimer.Start();
            };
        }

        #endregion Private Methods

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
