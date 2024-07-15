namespace CMSWinForms.UserControls
{
    partial class DeleteEmployee
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
            txtDob = new TextBox();
            txtNumber = new TextBox();
            txtAddress = new TextBox();
            txtMiddleName = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            lblEmployee = new Label();
            cbxEmployee = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDob);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblEmployee);
            panel1.Controls.Add(cbxEmployee);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 612);
            panel1.TabIndex = 0;
            // 
            // txtDob
            // 
            txtDob.Enabled = false;
            txtDob.Location = new Point(30, 351);
            txtDob.Multiline = true;
            txtDob.Name = "txtDob";
            txtDob.PlaceholderText = "Date Of Birth";
            txtDob.Size = new Size(286, 47);
            txtDob.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Enabled = false;
            txtNumber.Location = new Point(30, 291);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Phone Number";
            txtNumber.Size = new Size(286, 40);
            txtNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Enabled = false;
            txtAddress.Location = new Point(30, 229);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Employee Address";
            txtAddress.Size = new Size(286, 40);
            txtAddress.TabIndex = 6;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Enabled = false;
            txtMiddleName.Location = new Point(210, 113);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtMiddleName.Size = new Size(177, 40);
            txtMiddleName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(30, 169);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(286, 40);
            txtEmail.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(403, 113);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(165, 40);
            txtLastName.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(30, 113);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "First Name";
            txtName.Size = new Size(163, 40);
            txtName.TabIndex = 2;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(30, 23);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(119, 20);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Select Employee";
            // 
            // cbxEmployee
            // 
            cbxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmployee.FormattingEnabled = true;
            cbxEmployee.Location = new Point(165, 20);
            cbxEmployee.Name = "cbxEmployee";
            cbxEmployee.Size = new Size(151, 28);
            cbxEmployee.TabIndex = 0;
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DeleteEmployee";
            Size = new Size(794, 612);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Label lblEmployee;
        private ComboBox cbxEmployee;
        private TextBox txtDob;
        private TextBox txtNumber;
        private TextBox txtAddress;
        private TextBox txtMiddleName;
        private TextBox txtEmail;
        private TextBox txtLastName;
    }
}
