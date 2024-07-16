namespace CMSWinForms.UserControls
{
    partial class UserRegistration
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
            lblUserRegistration = new Label();
            panel2 = new Panel();
            btnSave = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUserRegistration);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 92);
            panel1.TabIndex = 0;
            // 
            // lblUserRegistration
            // 
            lblUserRegistration.Anchor = AnchorStyles.None;
            lblUserRegistration.AutoSize = true;
            lblUserRegistration.Font = new Font("Elephant", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRegistration.ForeColor = Color.DarkCyan;
            lblUserRegistration.Location = new Point(183, 32);
            lblUserRegistration.Name = "lblUserRegistration";
            lblUserRegistration.Size = new Size(296, 30);
            lblUserRegistration.TabIndex = 1;
            lblUserRegistration.Text = "Username && Password";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.naruto_vs_sasuke_thor_raib;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtPassword);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 335);
            panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(265, 177);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 43);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(236, 61);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username*";
            txtUsername.Size = new Size(188, 32);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(236, 115);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password*";
            txtPassword.Size = new Size(188, 32);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserRegistration";
            Size = new Size(643, 427);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblUserRegistration;
        private Button btnSave;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}
