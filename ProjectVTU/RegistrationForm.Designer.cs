namespace ProjectVTU
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.validFirstNameLabel = new System.Windows.Forms.Label();
            this.validLastNameLabel = new System.Windows.Forms.Label();
            this.validUsernameLabel = new System.Windows.Forms.Label();
            this.validPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.firstNameLabel.Location = new System.Drawing.Point(68, 83);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Име:";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.lastNameLabel.Location = new System.Drawing.Point(68, 151);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(117, 25);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.usernameLabel.Location = new System.Drawing.Point(68, 221);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(227, 25);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Потребителско име:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Maroon;
            this.passwordLabel.Location = new System.Drawing.Point(68, 295);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Парола:";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.Maroon;
            this.registerButton.Location = new System.Drawing.Point(645, 322);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(175, 49);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.firstNameTextBox.Location = new System.Drawing.Point(318, 77);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(279, 30);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.lastNameTextBox.Location = new System.Drawing.Point(318, 145);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(279, 30);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.usernameTextBox.Location = new System.Drawing.Point(318, 215);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(279, 30);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.passwordTextBox.Location = new System.Drawing.Point(318, 289);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(279, 30);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // validFirstNameLabel
            // 
            this.validFirstNameLabel.AutoSize = true;
            this.validFirstNameLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.validFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.validFirstNameLabel.Location = new System.Drawing.Point(318, 110);
            this.validFirstNameLabel.Name = "validFirstNameLabel";
            this.validFirstNameLabel.Size = new System.Drawing.Size(10, 16);
            this.validFirstNameLabel.TabIndex = 9;
            this.validFirstNameLabel.Text = " ";
            // 
            // validLastNameLabel
            // 
            this.validLastNameLabel.AutoSize = true;
            this.validLastNameLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.validLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.validLastNameLabel.Location = new System.Drawing.Point(318, 178);
            this.validLastNameLabel.Name = "validLastNameLabel";
            this.validLastNameLabel.Size = new System.Drawing.Size(0, 16);
            this.validLastNameLabel.TabIndex = 10;
            // 
            // validUsernameLabel
            // 
            this.validUsernameLabel.AutoSize = true;
            this.validUsernameLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.validUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validUsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.validUsernameLabel.Location = new System.Drawing.Point(318, 248);
            this.validUsernameLabel.Name = "validUsernameLabel";
            this.validUsernameLabel.Size = new System.Drawing.Size(0, 16);
            this.validUsernameLabel.TabIndex = 11;
            // 
            // validPasswordLabel
            // 
            this.validPasswordLabel.AutoSize = true;
            this.validPasswordLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.validPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.validPasswordLabel.Location = new System.Drawing.Point(318, 322);
            this.validPasswordLabel.Name = "validPasswordLabel";
            this.validPasswordLabel.Size = new System.Drawing.Size(0, 16);
            this.validPasswordLabel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Попълнете полетата, за да направите своята регистрация успешно!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(872, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validPasswordLabel);
            this.Controls.Add(this.validUsernameLabel);
            this.Controls.Add(this.validLastNameLabel);
            this.Controls.Add(this.validFirstNameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label validFirstNameLabel;
        private System.Windows.Forms.Label validLastNameLabel;
        private System.Windows.Forms.Label validUsernameLabel;
        private System.Windows.Forms.Label validPasswordLabel;
        private System.Windows.Forms.Label label1;
    }
}