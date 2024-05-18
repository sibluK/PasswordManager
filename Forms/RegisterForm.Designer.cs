namespace PasswordManager
{
    partial class RegisterForm
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
            btnRegister = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            showPasswordBox = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(219, 249);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 23);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(193, 156);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 138);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 193);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(154, 23);
            txtPassword.TabIndex = 3;
            // 
            // showPasswordBox
            // 
            showPasswordBox.AutoSize = true;
            showPasswordBox.Location = new Point(362, 213);
            showPasswordBox.Name = "showPasswordBox";
            showPasswordBox.Size = new Size(55, 19);
            showPasswordBox.TabIndex = 5;
            showPasswordBox.Text = "Show";
            showPasswordBox.UseVisualStyleBackColor = true;
            showPasswordBox.CheckedChanged += showPasswordBox_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(200, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(137, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(linkLabel1);
            Controls.Add(showPasswordBox);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private CheckBox showPasswordBox;
        private LinkLabel linkLabel1;
    }
}