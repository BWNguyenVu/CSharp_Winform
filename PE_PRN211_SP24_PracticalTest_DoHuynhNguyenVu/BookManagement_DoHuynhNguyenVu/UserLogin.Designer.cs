namespace BookManagement_DoHuynhNguyenVu
{
    partial class UserLogin
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
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnQuit = new Button();
            btnLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(btnQuit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Location = new Point(86, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 31);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 31);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 137);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 83);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(306, 223);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(172, 57);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(83, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 56);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "UserLogin";
            Text = "UserLogin";
            Load += UserLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnQuit;
        private Button btnLogin;
    }
}