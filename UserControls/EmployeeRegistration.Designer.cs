namespace CMSWinForms.UserControls
{
    partial class EmployeeRegistration
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
            panel1 = new Panel();
            lblEmployeeRegistration = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            lblDOB = new Label();
            btnRegister = new Button();
            dtpDOB = new DateTimePicker();
            txtNumber = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(lblEmployeeRegistration);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 32);
            panel1.TabIndex = 0;
            // 
            // lblEmployeeRegistration
            // 
            lblEmployeeRegistration.Anchor = AnchorStyles.None;
            lblEmployeeRegistration.AutoSize = true;
            lblEmployeeRegistration.Font = new Font("Elephant", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeRegistration.ForeColor = Color.DarkCyan;
            lblEmployeeRegistration.Location = new Point(161, 2);
            lblEmployeeRegistration.Name = "lblEmployeeRegistration";
            lblEmployeeRegistration.Size = new Size(296, 30);
            lblEmployeeRegistration.TabIndex = 0;
            lblEmployeeRegistration.Text = "Employee Registration";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.naruto_vs_sasuke_thor_raib;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(lblDOB);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(dtpDOB);
            panel2.Controls.Add(txtNumber);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtMiddleName);
            panel2.Controls.Add(txtFirstName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 395);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(213, 298);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(221, 42);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.Transparent;
            lblDOB.Location = new Point(230, 130);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(96, 20);
            lblDOB.TabIndex = 9;
            lblDOB.Text = "Date Of Birth";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(213, 237);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(221, 42);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(230, 153);
            dtpDOB.MinimumSize = new Size(0, 32);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(227, 32);
            dtpDOB.TabIndex = 6;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(3, 153);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Number*";
            txtNumber.Size = new Size(212, 32);
            txtNumber.TabIndex = 5;
            txtNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(230, 79);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address*";
            txtAddress.Size = new Size(391, 32);
            txtAddress.TabIndex = 4;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 79);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email*";
            txtEmail.Size = new Size(212, 32);
            txtEmail.TabIndex = 3;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(419, 28);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name*";
            txtLastName.Size = new Size(221, 32);
            txtLastName.TabIndex = 2;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(230, 28);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "Middle Name*";
            txtMiddleName.Size = new Size(176, 32);
            txtMiddleName.TabIndex = 1;
            txtMiddleName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(3, 28);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name*";
            txtFirstName.Size = new Size(212, 32);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeRegistration";
            Size = new Size(643, 427);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblEmployeeRegistration;
        private TextBox txtFirstName;
        private DateTimePicker dtpDOB;
        private TextBox txtNumber;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private Button btnRegister;
        private Label lblDOB;
        private Button btnCancel;
    }
}
