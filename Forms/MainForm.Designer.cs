namespace PasswordManager.Forms
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtUsername = new Label();
            btnAdd = new Button();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearchInput = new TextBox();
            nameLabel = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtURL = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DecryptPasswordBox = new CheckBox();
            btnCopyToClipboard = new Button();
            txtComment = new RichTextBox();
            btnClear = new Button();
            btnGenerate = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(430, 373);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(0, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(74, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 34);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Passwords:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(74, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(155, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearchInput
            // 
            txtSearchInput.Location = new Point(582, 23);
            txtSearchInput.Name = "txtSearchInput";
            txtSearchInput.Size = new Size(124, 23);
            txtSearchInput.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(79, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(79, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 23);
            txtPassword.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 105);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(79, 180);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(151, 23);
            txtURL.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 162);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 15;
            label5.Text = "URL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 219);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 17;
            label6.Text = "Comment:";
            // 
            // DecryptPasswordBox
            // 
            DecryptPasswordBox.AutoSize = true;
            DecryptPasswordBox.Location = new Point(236, 126);
            DecryptPasswordBox.Name = "DecryptPasswordBox";
            DecryptPasswordBox.Size = new Size(67, 19);
            DecryptPasswordBox.TabIndex = 19;
            DecryptPasswordBox.Text = "Decrypt";
            DecryptPasswordBox.UseVisualStyleBackColor = true;
            DecryptPasswordBox.Visible = false;
            DecryptPasswordBox.CheckedChanged += DecryptPasswordBox_CheckedChanged;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.Location = new Point(27, 123);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(46, 23);
            btnCopyToClipboard.TabIndex = 20;
            btnCopyToClipboard.Text = "Copy password";
            btnCopyToClipboard.UseVisualStyleBackColor = true;
            btnCopyToClipboard.Visible = false;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // txtComment
            // 
            txtComment.BorderStyle = BorderStyle.FixedSingle;
            txtComment.Location = new Point(79, 237);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(151, 69);
            txtComment.TabIndex = 21;
            txtComment.Text = "";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(155, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(74, 402);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(156, 23);
            btnGenerate.TabIndex = 23;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(712, 23);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 24;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnGenerate);
            Controls.Add(btnClear);
            Controls.Add(txtComment);
            Controls.Add(btnCopyToClipboard);
            Controls.Add(DecryptPasswordBox);
            Controls.Add(label6);
            Controls.Add(txtURL);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(nameLabel);
            Controls.Add(txtSearchInput);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label txtUsername;
        private Button btnAdd;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearchInput;
        private Label nameLabel;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtURL;
        private Label label5;
        private Label label6;
        private CheckBox DecryptPasswordBox;
        private Button btnCopyToClipboard;
        private RichTextBox txtComment;
        private Button btnClear;
        private Button btnGenerate;
        private Button button1;
    }
}