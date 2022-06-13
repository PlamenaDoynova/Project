using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVTU
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length < 3)
            {
                validFirstNameLabel.Text = "Името трябва да съдържа поне три символа.";
                registerButton.Enabled = false;
            }
            else
            {
                validFirstNameLabel.Text = string.Empty;

                if (lastNameTextBox.Text.Length > 2 && usernameTextBox.Text.Length > 2 && passwordTextBox.Text.Length > 1)
                {
                    registerButton.Enabled = true;
                }
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.Length < 3)
            {
                validLastNameLabel.Text = "Фамилията трябва да съдържа поне три символа.";
                registerButton.Enabled = false;
            }
            else
            {
                validLastNameLabel.Text = string.Empty;

                if (firstNameTextBox.Text.Length > 2 && usernameTextBox.Text.Length > 2 && passwordTextBox.Text.Length > 1)
                {
                    registerButton.Enabled = true;
                }
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3)
            {
                validUsernameLabel.Text = "Потребителското име трябва да съдържа поне три символа.";
                registerButton.Enabled = false;
            }
            else
            {
                validUsernameLabel.Text = string.Empty;

                if (firstNameTextBox.Text.Length > 2 && lastNameTextBox.Text.Length > 2 && passwordTextBox.Text.Length > 1)
                {
                    registerButton.Enabled = true;
                }
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 2)
            {
                validPasswordLabel.Text = "Паролата трябва да има поне два символа.";
                registerButton.Enabled = false;
            }
            else
            {
                validPasswordLabel.Text = string.Empty;

                if (firstNameTextBox.Text.Length > 2 && lastNameTextBox.Text.Length > 2 && usernameTextBox.Text.Length > 2)
                {
                    registerButton.Enabled = true;
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = username,
                Pass = password,
                Role = 1
            };

            using (LibraryContext libraryContext = new LibraryContext())
            {
                libraryContext.Users.Add(user);
                libraryContext.SaveChanges();
                Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
