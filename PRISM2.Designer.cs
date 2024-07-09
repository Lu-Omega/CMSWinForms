namespace CMSWinForms
{
    partial class PRISM2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            mainEmployee = new ToolStripMenuItem();
            subAddEmployee = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(123, 594);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(41, 69, 81);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainEmployee, productsToolStripMenuItem, suppliersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(121, 594);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainEmployee
            // 
            mainEmployee.DropDownItems.AddRange(new ToolStripItem[] { subAddEmployee });
            mainEmployee.ForeColor = Color.White;
            mainEmployee.Image = Properties.Resources.user__2_;
            mainEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            mainEmployee.Name = "mainEmployee";
            mainEmployee.Padding = new Padding(5, 10, 5, 10);
            mainEmployee.Size = new Size(108, 44);
            mainEmployee.Text = "Employees";
            // 
            // subAddEmployee
            // 
            subAddEmployee.BackColor = Color.FromArgb(41, 69, 81);
            subAddEmployee.ForeColor = Color.White;
            subAddEmployee.Name = "subAddEmployee";
            subAddEmployee.Size = new Size(224, 26);
            subAddEmployee.Text = "Add Employees";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.ForeColor = Color.White;
            productsToolStripMenuItem.Image = Properties.Resources.Colebemis_Feather_Box_24;
            productsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Padding = new Padding(5, 10, 5, 10);
            productsToolStripMenuItem.Size = new Size(108, 44);
            productsToolStripMenuItem.Text = "Products";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.ForeColor = Color.White;
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Padding = new Padding(5, 10, 5, 10);
            suppliersToolStripMenuItem.Size = new Size(108, 44);
            suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(123, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 594);
            panel3.TabIndex = 1;
            // 
            // PRISM2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 594);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "PRISM2";
            Text = "PRISM2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private Panel panel3;
        private ToolStripMenuItem mainEmployee;
        private ToolStripMenuItem subAddEmployee;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
    }
}