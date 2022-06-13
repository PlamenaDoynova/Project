namespace ProjectVTU
{
    partial class ChangePublisherForm
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
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherLabel.ForeColor = System.Drawing.Color.Maroon;
            this.publisherLabel.Location = new System.Drawing.Point(12, 27);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(155, 25);
            this.publisherLabel.TabIndex = 0;
            this.publisherLabel.Text = "Издателство:";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.publisherTextBox.Location = new System.Drawing.Point(15, 59);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(464, 30);
            this.publisherTextBox.TabIndex = 1;
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.ForeColor = System.Drawing.Color.Maroon;
            this.prevButton.Location = new System.Drawing.Point(17, 109);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(37, 32);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.Maroon;
            this.nextButton.Location = new System.Drawing.Point(443, 109);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(36, 32);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.Maroon;
            this.addButton.Location = new System.Drawing.Point(100, 160);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 41);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добави";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.Maroon;
            this.updateButton.Location = new System.Drawing.Point(262, 160);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(136, 41);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Промени";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ChangePublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(491, 213);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.publisherLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePublisherForm";
            this.Text = "Управление на данните за издателствата";
            this.Load += new System.EventHandler(this.ChangePublisherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
    }
}