namespace CMSWinForms.UserControls
{
    partial class UserSignin
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
            panel2 = new Panel();
            lblUserRegistration = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
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
            panel1.Size = new Size(643, 75);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.naruto_vs_sasuke_thor_raib;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 352);
            panel2.TabIndex = 1;
            // 
            // lblUserRegistration
            // 
            lblUserRegistration.Anchor = AnchorStyles.None;
            lblUserRegistration.AutoSize = true;
            lblUserRegistration.Font = new Font("Elephant", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRegistration.ForeColor = Color.DarkCyan;
            lblUserRegistration.Location = new Point(222, 24);
            lblUserRegistration.Name = "lblUserRegistration";
            lblUserRegistration.Size = new Size(190, 30);
            lblUserRegistration.TabIndex = 2;
            lblUserRegistration.Text = "PRISM Login";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(224, 48);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username*";
            txtUsername.Size = new Size(188, 32);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(224, 116);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password*";
            txtPassword.Size = new Size(188, 32);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(261, 184);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // UserSignin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserSignin";
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
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
