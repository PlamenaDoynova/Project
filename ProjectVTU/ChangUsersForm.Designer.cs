namespace ProjectVTU
{
    partial class ChangUsersForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.usernameDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.firstNameLabel.Location = new System.Drawing.Point(33, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Име:";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.lastNameLabel.Location = new System.Drawing.Point(33, 90);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(117, 25);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия:";
            this.lastNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.usernameLabel.Location = new System.Drawing.Point(33, 131);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(227, 25);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Потребителско име:";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Maroon;
            this.passwordLabel.Location = new System.Drawing.Point(33, 174);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Роля:";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rolesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rolesComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(38, 211);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(204, 33);
            this.rolesComboBox.TabIndex = 4;
            this.rolesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.Maroon;
            this.updateButton.Location = new System.Drawing.Point(535, 54);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(149, 38);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Промяна";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.Maroon;
            this.deleteButton.Location = new System.Drawing.Point(535, 118);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 38);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.ForeColor = System.Drawing.Color.Maroon;
            this.prevButton.Location = new System.Drawing.Point(535, 201);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(43, 43);
            this.prevButton.TabIndex = 7;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.Maroon;
            this.nextButton.Location = new System.Drawing.Point(644, 201);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(40, 43);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.AutoSize = true;
            this.firstNameDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameDataLabel.ForeColor = System.Drawing.Color.Maroon;
            this.firstNameDataLabel.Location = new System.Drawing.Point(97, 54);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(0, 25);
            this.firstNameDataLabel.TabIndex = 9;
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.AutoSize = true;
            this.lastNameDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameDataLabel.ForeColor = System.Drawing.Color.Maroon;
            this.lastNameDataLabel.Location = new System.Drawing.Point(148, 90);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(0, 25);
            this.lastNameDataLabel.TabIndex = 10;
            // 
            // usernameDataLabel
            // 
            this.usernameDataLabel.AutoSize = true;
            this.usernameDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameDataLabel.ForeColor = System.Drawing.Color.Maroon;
            this.usernameDataLabel.Location = new System.Drawing.Point(275, 131);
            this.usernameDataLabel.Name = "usernameDataLabel";
            this.usernameDataLabel.Size = new System.Drawing.Size(0, 25);
            this.usernameDataLabel.TabIndex = 11;
            // 
            // ChangUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(722, 274);
            this.Controls.Add(this.usernameDataLabel);
            this.Controls.Add(this.lastNameDataLabel);
            this.Controls.Add(this.firstNameDataLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangUsersForm";
            this.Text = "Управление на данните за потребителите";
            this.Load += new System.EventHandler(this.ChangUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.Label usernameDataLabel;
    }
}