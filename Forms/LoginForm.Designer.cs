namespace PasswordManager
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
            showPasswordBox = new CheckBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // showPasswordBox
            // 
            showPasswordBox.AutoSize = true;
            showPasswordBox.Location = new Point(360, 229);
            showPasswordBox.Name = "showPasswordBox";
            showPasswordBox.Size = new Size(55, 19);
            showPasswordBox.TabIndex = 11;
            showPasswordBox.Text = "Show";
            showPasswordBox.UseVisualStyleBackColor = true;
            showPasswordBox.CheckedChanged += showPasswordBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 209);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(191, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(154, 23);
            txtPassword.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 154);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(191, 172);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 23);
            txtUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(214, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(showPasswordBox);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox showPasswordBox;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}