namespace CMSWinForms
{
    partial class LoginForm
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
            btnLogin = new Button();
            btnRegister = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = Properties.Resources.naruto_vs_sasuke_thor_raib;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(643, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 427);
            panel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.FlatAppearance.BorderSize = 10;
            btnLogin.Location = new Point(256, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 48);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(256, 136);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 47);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(643, 427);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnLogin;
        private Button btnRegister;
    }
}