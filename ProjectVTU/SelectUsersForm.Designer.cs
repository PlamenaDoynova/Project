namespace ProjectVTU
{
    partial class SelectUsersForm
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
            this.roleLabel = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.usersLabel = new System.Windows.Forms.Label();
            this.filteredUsersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.roleLabel.Location = new System.Drawing.Point(37, 32);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(69, 25);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Роля:";
            this.roleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rolesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rolesComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(40, 64);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(231, 33);
            this.rolesComboBox.TabIndex = 1;
            this.rolesComboBox.SelectedIndexChanged += new System.EventHandler(this.rolesComboBox_SelectedIndexChanged);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersLabel.ForeColor = System.Drawing.Color.Maroon;
            this.usersLabel.Location = new System.Drawing.Point(37, 117);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(157, 25);
            this.usersLabel.TabIndex = 2;
            this.usersLabel.Text = "Потребители:";
            // 
            // filteredUsersListView
            // 
            this.filteredUsersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filteredUsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.filteredUsersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filteredUsersListView.ForeColor = System.Drawing.Color.Maroon;
            this.filteredUsersListView.GridLines = true;
            this.filteredUsersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.filteredUsersListView.HideSelection = false;
            this.filteredUsersListView.Location = new System.Drawing.Point(40, 157);
            this.filteredUsersListView.MultiSelect = false;
            this.filteredUsersListView.Name = "filteredUsersListView";
            this.filteredUsersListView.ShowGroups = false;
            this.filteredUsersListView.Size = new System.Drawing.Size(716, 264);
            this.filteredUsersListView.TabIndex = 3;
            this.filteredUsersListView.UseCompatibleStateImageBehavior = false;
            this.filteredUsersListView.View = System.Windows.Forms.View.Details;
            this.filteredUsersListView.SelectedIndexChanged += new System.EventHandler(this.filteredUsersListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Име:";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия:";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Потребителско име:";
            this.columnHeader4.Width = 230;
            // 
            // SelectUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filteredUsersListView);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.roleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectUsersForm";
            this.Text = "Избор на потребител";
            this.Load += new System.EventHandler(this.SelectUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.ListView filteredUsersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}