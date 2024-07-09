namespace CMSWinForms.UserControls
{
    partial class AddEmployee
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
            btnSave = new Button();
            lblAddress = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblLastName = new Label();
            lblMiddleName = new Label();
            lblName = new Label();
            lblDOB = new Label();
            dtpDateOfBirth = new DateTimePicker();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtMiddleName = new TextBox();
            txtName = new TextBox();
            txtPhoneNumber = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblMiddleName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblDOB);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 659);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cyan;
            btnSave.FlatAppearance.BorderColor = Color.Cyan;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btnSave.Location = new Point(36, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(219, 60);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(36, 221);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(36, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(259, 86);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 14;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(36, 86);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(259, 21);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(100, 20);
            lblMiddleName.TabIndex = 12;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(36, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 20);
            lblName.TabIndex = 11;
            lblName.Text = "First Name";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(36, 321);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(96, 20);
            lblDOB.TabIndex = 9;
            lblDOB.Text = "Date Of Birth";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(173, 316);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(243, 27);
            dtpDateOfBirth.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(36, 244);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(403, 35);
            txtAddress.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(36, 176);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(403, 34);
            txtEmail.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(36, 109);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(180, 39);
            txtSurname.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(259, 45);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(180, 36);
            txtMiddleName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(36, 45);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 36);
            txtName.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(259, 109);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(180, 34);
            txtPhoneNumber.TabIndex = 18;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(888, 659);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtMiddleName;
        private TextBox txtName;
        private Label lblDOB;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label lblMiddleName;
        private Label lblName;
        private Button btnSave;
        private TextBox txtPhoneNumber;
    }
}
