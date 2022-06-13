namespace ProjectVTU
{
    partial class ChangeGenreForm
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
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.genreLabel.Location = new System.Drawing.Point(161, 29);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(74, 25);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "Жанр:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.genreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.genreTextBox.Location = new System.Drawing.Point(26, 71);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(364, 30);
            this.genreTextBox.TabIndex = 1;
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.ForeColor = System.Drawing.Color.Maroon;
            this.prevButton.Location = new System.Drawing.Point(26, 150);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(41, 37);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.Maroon;
            this.nextButton.Location = new System.Drawing.Point(350, 150);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(40, 37);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.Maroon;
            this.addButton.Location = new System.Drawing.Point(26, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 38);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добави";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.Maroon;
            this.updateButton.Location = new System.Drawing.Point(267, 207);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 38);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Промени";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ChangeGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(421, 272);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeGenreForm";
            this.Text = "Управление на данните за жанровете";
            this.Load += new System.EventHandler(this.ChangeGenreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
    }
}