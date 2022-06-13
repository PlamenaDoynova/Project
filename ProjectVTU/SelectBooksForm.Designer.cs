namespace ProjectVTU
{
    partial class SelectBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBooksForm));
            this.publisherLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.publishersComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.filteredBooksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.combineFiltersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherLabel.ForeColor = System.Drawing.Color.Maroon;
            this.publisherLabel.Location = new System.Drawing.Point(28, 22);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(155, 25);
            this.publisherLabel.TabIndex = 0;
            this.publisherLabel.Text = "Издателство:";
            this.publisherLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.genreLabel.Location = new System.Drawing.Point(503, 22);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(74, 25);
            this.genreLabel.TabIndex = 1;
            this.genreLabel.Text = "Жанр:";
            // 
            // publishersComboBox
            // 
            this.publishersComboBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.publishersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishersComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.publishersComboBox.FormattingEnabled = true;
            this.publishersComboBox.Location = new System.Drawing.Point(31, 52);
            this.publishersComboBox.Name = "publishersComboBox";
            this.publishersComboBox.Size = new System.Drawing.Size(236, 33);
            this.publishersComboBox.TabIndex = 2;
            this.publishersComboBox.SelectedIndexChanged += new System.EventHandler(this.publishersComboBox_SelectedIndexChanged);
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(506, 52);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(248, 33);
            this.genreComboBox.TabIndex = 3;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // filteredBooksListView
            // 
            this.filteredBooksListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filteredBooksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.filteredBooksListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filteredBooksListView.ForeColor = System.Drawing.Color.Maroon;
            this.filteredBooksListView.GridLines = true;
            this.filteredBooksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.filteredBooksListView.HideSelection = false;
            this.filteredBooksListView.Location = new System.Drawing.Point(31, 114);
            this.filteredBooksListView.MultiSelect = false;
            this.filteredBooksListView.Name = "filteredBooksListView";
            this.filteredBooksListView.ShowGroups = false;
            this.filteredBooksListView.Size = new System.Drawing.Size(723, 324);
            this.filteredBooksListView.TabIndex = 5;
            this.filteredBooksListView.UseCompatibleStateImageBehavior = false;
            this.filteredBooksListView.View = System.Windows.Forms.View.Details;
            this.filteredBooksListView.SelectedIndexChanged += new System.EventHandler(this.filteredBooksListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Издателство:";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заглавие:";
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Жанр:";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена:";
            this.columnHeader4.Width = 100;
            // 
            // combineFiltersButton
            // 
            this.combineFiltersButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.combineFiltersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("combineFiltersButton.BackgroundImage")));
            this.combineFiltersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.combineFiltersButton.Location = new System.Drawing.Point(363, 39);
            this.combineFiltersButton.Name = "combineFiltersButton";
            this.combineFiltersButton.Size = new System.Drawing.Size(39, 37);
            this.combineFiltersButton.TabIndex = 4;
            this.combineFiltersButton.UseVisualStyleBackColor = false;
            this.combineFiltersButton.Click += new System.EventHandler(this.combineFiltersButton_Click);
            // 
            // SelectBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filteredBooksListView);
            this.Controls.Add(this.combineFiltersButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.publishersComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.publisherLabel);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectBooksForm";
            this.Text = "Избор на книга";
            this.Load += new System.EventHandler(this.SelectBooksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox publishersComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button combineFiltersButton;
        private System.Windows.Forms.ListView filteredBooksListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}