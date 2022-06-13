namespace ProjectVTU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.validUsernameLabel = new System.Windows.Forms.Label();
            this.validPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.validUsernameLabel1 = new System.Windows.Forms.Label();
            this.validPasswordLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.usernameLabel.Location = new System.Drawing.Point(50, 137);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(227, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Потребителско име:";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Maroon;
            this.passwordLabel.Location = new System.Drawing.Point(50, 194);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Парола:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.usernameTextBox.Location = new System.Drawing.Point(303, 132);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(224, 30);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.passwordTextBox.Location = new System.Drawing.Point(303, 189);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(224, 30);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.Maroon;
            this.loginButton.Location = new System.Drawing.Point(405, 267);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 46);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLinkLabel.Location = new System.Drawing.Point(621, 278);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(153, 46);
            this.registerLinkLabel.TabIndex = 5;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Регистрация";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // validUsernameLabel
            // 
            this.validUsernameLabel.AutoSize = true;
            this.validUsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.validUsernameLabel.Location = new System.Drawing.Point(347, 297);
            this.validUsernameLabel.Name = "validUsernameLabel";
            this.validUsernameLabel.Size = new System.Drawing.Size(0, 16);
            this.validUsernameLabel.TabIndex = 6;
            this.validUsernameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // validPasswordLabel
            // 
            this.validPasswordLabel.AutoSize = true;
            this.validPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.validPasswordLabel.Location = new System.Drawing.Point(297, 183);
            this.validPasswordLabel.Name = "validPasswordLabel";
            this.validPasswordLabel.Size = new System.Drawing.Size(0, 16);
            this.validPasswordLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 80);
            this.label1.TabIndex = 8;
            this.label1.Text = "ОНЛАЙН БИБЛИОТЕКА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // validUsernameLabel1
            // 
            this.validUsernameLabel1.AutoSize = true;
            this.validUsernameLabel1.ForeColor = System.Drawing.Color.Red;
            this.validUsernameLabel1.Location = new System.Drawing.Point(300, 170);
            this.validUsernameLabel1.Name = "validUsernameLabel1";
            this.validUsernameLabel1.Size = new System.Drawing.Size(0, 16);
            this.validUsernameLabel1.TabIndex = 9;
            // 
            // validPasswordLabel1
            // 
            this.validPasswordLabel1.AutoSize = true;
            this.validPasswordLabel1.ForeColor = System.Drawing.Color.Red;
            this.validPasswordLabel1.Location = new System.Drawing.Point(303, 226);
            this.validPasswordLabel1.Name = "validPasswordLabel1";
            this.validPasswordLabel1.Size = new System.Drawing.Size(0, 16);
            this.validPasswordLabel1.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(795, 336);
            this.Controls.Add(this.validPasswordLabel1);
            this.Controls.Add(this.validUsernameLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validPasswordLabel);
            this.Controls.Add(this.validUsernameLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.Label validUsernameLabel;
        private System.Windows.Forms.Label validPasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label validUsernameLabel1;
        private System.Windows.Forms.Label validPasswordLabel1;
    }
}

