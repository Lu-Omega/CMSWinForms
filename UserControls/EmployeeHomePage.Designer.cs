namespace CMSWinForms.UserControls
{
    partial class EmployeeHomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddEmployee = new Button();
            button2 = new Button();
            button3 = new Button();
            lblEmployeeDetail = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(3, 45);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(153, 122);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 45);
            button2.Name = "button2";
            button2.Size = new Size(167, 122);
            button2.TabIndex = 1;
            button2.Text = "View Employees";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(319, 45);
            button3.Name = "button3";
            button3.Size = new Size(164, 122);
            button3.TabIndex = 2;
            button3.Text = "Maintain Employee";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeDetail
            // 
            lblEmployeeDetail.AutoSize = true;
            lblEmployeeDetail.Font = new Font("Segoe UI", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEmployeeDetail.Location = new Point(6, 4);
            lblEmployeeDetail.Name = "lblEmployeeDetail";
            lblEmployeeDetail.Size = new Size(150, 38);
            lblEmployeeDetail.TabIndex = 3;
            lblEmployeeDetail.Text = "Employees";
            // 
            // button4
            // 
            button4.Location = new Point(3, 173);
            button4.Name = "button4";
            button4.Size = new Size(153, 122);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(153, 173);
            button5.Name = "button5";
            button5.Size = new Size(167, 122);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(319, 173);
            button6.Name = "button6";
            button6.Size = new Size(164, 122);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(btnAddEmployee);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(lblEmployeeDetail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 650);
            panel1.TabIndex = 7;
            // 
            // EmployeeHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            Controls.Add(panel1);
            Name = "EmployeeHomePage";
            Size = new Size(937, 650);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEmployee;
        private Button button2;
        private Button button3;
        private Label lblEmployeeDetail;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
    }
}
