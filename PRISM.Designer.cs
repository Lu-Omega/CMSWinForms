namespace CMSWinForms
{
    partial class PRISM
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRISM));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            lblMenu = new Label();
            menuButton = new PictureBox();
            button3 = new Button();
            btnEmployee = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 60, 70);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(btnEmployee);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button5);
            sidebar.Controls.Add(button6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(223, 777);
            sidebar.MinimumSize = new Size(50, 777);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(223, 777);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMenu);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 99);
            panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(45, 49);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(62, 28);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(9, 49);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(30, 29);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.Arturo_Wibawa_Akar_Home_alt_1_24;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 108);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(220, 49);
            button3.TabIndex = 2;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            btnEmployee.FlatAppearance.BorderColor = Color.Gray;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.Transparent;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(3, 163);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.RightToLeft = RightToLeft.No;
            btnEmployee.Size = new Size(220, 49);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Image = Properties.Resources.Colebemis_Feather_Box_24;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 218);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(220, 49);
            button4.TabIndex = 3;
            button4.Text = "Products";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 273);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(220, 50);
            button5.TabIndex = 4;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.Gray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Transparent;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 329);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(220, 52);
            button6.TabIndex = 5;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(315, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 48);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.Untitled_Diagram_drawio__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(324, 484);
            button2.Name = "button2";
            button2.Size = new Size(220, 53);
            button2.TabIndex = 1;
            button2.Text = "         Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // PRISM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 777);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(sidebar);
            Name = "PRISM";
            Text = "PRISM";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button btnEmployee;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox menuButton;
        private Label lblMenu;
        private System.Windows.Forms.Timer sideBarTimer;
    }
}