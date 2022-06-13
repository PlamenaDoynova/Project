namespace ProjectVTU
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.booksGroupBox = new System.Windows.Forms.GroupBox();
            this.changeBooksButton = new System.Windows.Forms.Button();
            this.selectBooksButton = new System.Windows.Forms.Button();
            this.publishersGroupBox = new System.Windows.Forms.GroupBox();
            this.changePublisherButton = new System.Windows.Forms.Button();
            this.GenreGroupBox = new System.Windows.Forms.GroupBox();
            this.changeGenreButton = new System.Windows.Forms.Button();
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.changeUsersButton = new System.Windows.Forms.Button();
            this.selectUsersButton = new System.Windows.Forms.Button();
            this.booksGroupBox.SuspendLayout();
            this.publishersGroupBox.SuspendLayout();
            this.GenreGroupBox.SuspendLayout();
            this.usersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksGroupBox
            // 
            this.booksGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksGroupBox.Controls.Add(this.changeBooksButton);
            this.booksGroupBox.Controls.Add(this.selectBooksButton);
            this.booksGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.booksGroupBox.Location = new System.Drawing.Point(65, 12);
            this.booksGroupBox.Name = "booksGroupBox";
            this.booksGroupBox.Size = new System.Drawing.Size(212, 120);
            this.booksGroupBox.TabIndex = 0;
            this.booksGroupBox.TabStop = false;
            this.booksGroupBox.Text = "Книги:";
            this.booksGroupBox.Enter += new System.EventHandler(this.booksGroupBox_Enter);
            // 
            // changeBooksButton
            // 
            this.changeBooksButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.changeBooksButton.Location = new System.Drawing.Point(44, 67);
            this.changeBooksButton.Name = "changeBooksButton";
            this.changeBooksButton.Size = new System.Drawing.Size(124, 37);
            this.changeBooksButton.TabIndex = 1;
            this.changeBooksButton.Text = "Промяна";
            this.changeBooksButton.UseVisualStyleBackColor = false;
            this.changeBooksButton.Click += new System.EventHandler(this.changeBooksButton_Click);
            // 
            // selectBooksButton
            // 
            this.selectBooksButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.selectBooksButton.Location = new System.Drawing.Point(44, 22);
            this.selectBooksButton.Name = "selectBooksButton";
            this.selectBooksButton.Size = new System.Drawing.Size(124, 39);
            this.selectBooksButton.TabIndex = 0;
            this.selectBooksButton.Text = "Преглед";
            this.selectBooksButton.UseVisualStyleBackColor = false;
            this.selectBooksButton.Click += new System.EventHandler(this.selectBooksButton_Click);
            // 
            // publishersGroupBox
            // 
            this.publishersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishersGroupBox.Controls.Add(this.changePublisherButton);
            this.publishersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishersGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.publishersGroupBox.Location = new System.Drawing.Point(65, 138);
            this.publishersGroupBox.Name = "publishersGroupBox";
            this.publishersGroupBox.Size = new System.Drawing.Size(212, 117);
            this.publishersGroupBox.TabIndex = 1;
            this.publishersGroupBox.TabStop = false;
            this.publishersGroupBox.Text = "Издателства:";
            this.publishersGroupBox.Enter += new System.EventHandler(this.publishersGroupBox_Enter);
            // 
            // changePublisherButton
            // 
            this.changePublisherButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.changePublisherButton.Location = new System.Drawing.Point(44, 44);
            this.changePublisherButton.Name = "changePublisherButton";
            this.changePublisherButton.Size = new System.Drawing.Size(124, 38);
            this.changePublisherButton.TabIndex = 2;
            this.changePublisherButton.Text = "Промяна";
            this.changePublisherButton.UseVisualStyleBackColor = false;
            this.changePublisherButton.Click += new System.EventHandler(this.changePublisherButton_Click);
            // 
            // GenreGroupBox
            // 
            this.GenreGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreGroupBox.Controls.Add(this.changeGenreButton);
            this.GenreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.GenreGroupBox.Location = new System.Drawing.Point(65, 261);
            this.GenreGroupBox.Name = "GenreGroupBox";
            this.GenreGroupBox.Size = new System.Drawing.Size(212, 111);
            this.GenreGroupBox.TabIndex = 1;
            this.GenreGroupBox.TabStop = false;
            this.GenreGroupBox.Text = "Жанр:";
            this.GenreGroupBox.Enter += new System.EventHandler(this.GenreGroupBox_Enter);
            // 
            // changeGenreButton
            // 
            this.changeGenreButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.changeGenreButton.Location = new System.Drawing.Point(44, 41);
            this.changeGenreButton.Name = "changeGenreButton";
            this.changeGenreButton.Size = new System.Drawing.Size(124, 36);
            this.changeGenreButton.TabIndex = 3;
            this.changeGenreButton.Text = "Промяна";
            this.changeGenreButton.UseVisualStyleBackColor = false;
            this.changeGenreButton.Click += new System.EventHandler(this.changeGenreButton_Click);
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGroupBox.Controls.Add(this.changeUsersButton);
            this.usersGroupBox.Controls.Add(this.selectUsersButton);
            this.usersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.usersGroupBox.Location = new System.Drawing.Point(65, 378);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(212, 130);
            this.usersGroupBox.TabIndex = 1;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "Потребители:";
            this.usersGroupBox.Enter += new System.EventHandler(this.usersGroupBox_Enter);
            // 
            // changeUsersButton
            // 
            this.changeUsersButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.changeUsersButton.Location = new System.Drawing.Point(44, 70);
            this.changeUsersButton.Name = "changeUsersButton";
            this.changeUsersButton.Size = new System.Drawing.Size(124, 38);
            this.changeUsersButton.TabIndex = 5;
            this.changeUsersButton.Text = "Промяна";
            this.changeUsersButton.UseVisualStyleBackColor = false;
            this.changeUsersButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // selectUsersButton
            // 
            this.selectUsersButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.selectUsersButton.Location = new System.Drawing.Point(44, 29);
            this.selectUsersButton.Name = "selectUsersButton";
            this.selectUsersButton.Size = new System.Drawing.Size(124, 35);
            this.selectUsersButton.TabIndex = 4;
            this.selectUsersButton.Text = "Преглед";
            this.selectUsersButton.UseVisualStyleBackColor = false;
            this.selectUsersButton.Click += new System.EventHandler(this.selectUsersButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(332, 530);
            this.Controls.Add(this.usersGroupBox);
            this.Controls.Add(this.GenreGroupBox);
            this.Controls.Add(this.publishersGroupBox);
            this.Controls.Add(this.booksGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.booksGroupBox.ResumeLayout(false);
            this.publishersGroupBox.ResumeLayout(false);
            this.GenreGroupBox.ResumeLayout(false);
            this.usersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox booksGroupBox;
        private System.Windows.Forms.Button changeBooksButton;
        private System.Windows.Forms.Button selectBooksButton;
        private System.Windows.Forms.GroupBox publishersGroupBox;
        private System.Windows.Forms.Button changePublisherButton;
        private System.Windows.Forms.GroupBox GenreGroupBox;
        private System.Windows.Forms.Button changeGenreButton;
        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.Button changeUsersButton;
        private System.Windows.Forms.Button selectUsersButton;
    }
}