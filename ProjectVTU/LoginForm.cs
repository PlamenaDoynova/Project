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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3)
            {
                validUsernameLabel1.Text = "Потребителското име трябва да съдържа поне три символа.";
                loginButton.Enabled = false;
            }
            else
            {
                validUsernameLabel1.Text = string.Empty;

                if (passwordTextBox.Text.Length > 1)
                {
                    loginButton.Enabled = true;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser;

            using (LibraryContext carDealerContext = new LibraryContext())
            {
                foundUser = carDealerContext.Users.FirstOrDefault(user => user.UserName == username);
            }

            if (foundUser != null)
            {
                if (foundUser.Pass == password)
                {
                    Registrator.LoggedUser = foundUser;

                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show("Грешна парола.", "Некоректен вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Няма такъв потребител.", "Некоректен вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 2)
            {
                validPasswordLabel1.Text = "Паролата трябва да има поне два символа.";
                loginButton.Enabled = false;
            }
            else
            {
                validPasswordLabel1.Text = string.Empty;

                if (usernameTextBox.Text.Length > 2)
                {
                    loginButton.Enabled = true;
                }
            }
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
