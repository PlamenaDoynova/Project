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
    public partial class ChangUsersForm : Form
    {

        private User currentUser;
        public ChangUsersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChangUsersForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                roles = libraryContext.Roles.OrderBy(role => role.Id).ToList();
                currentUser = libraryContext.Users.First();
            }

            rolesComboBox.ValueMember = "Id";
            rolesComboBox.DisplayMember = "Name";
            rolesComboBox.DataSource = roles;

            PopulateControls();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                User oldUser = libraryContext.Users.Find(currentUser.Id);

                User newUser = new User()
                {
                    Id = currentUser.Id,
                    FirstName = firstNameDataLabel.Text,
                    LastName = lastNameDataLabel.Text,
                    UserName = usernameDataLabel.Text,
                    Pass = currentUser.Pass,
                    Role = (int)rolesComboBox.SelectedValue
                };

                libraryContext.Entry(oldUser).CurrentValues.SetValues(newUser);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                User user = libraryContext.Users.Find(currentUser.Id);
                libraryContext.Users.Remove(user);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {

            nextButton.Enabled = true;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                List<User> prevUsers = libraryContext.Users
                    .Where(user => user.Id < currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (prevUsers.Count > 0)
                {
                    currentUser = prevUsers.Last();
                    PopulateControls();
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                List<User> nextUsers = libraryContext.Users
                    .Where(user => user.Id > currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (nextUsers.Count > 0)
                {
                    currentUser = nextUsers.First();
                    PopulateControls();
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }
        private void PopulateControls()
        {
            firstNameDataLabel.Text = currentUser.FirstName;
            lastNameDataLabel.Text = currentUser.LastName;
            usernameDataLabel.Text = currentUser.UserName;
            rolesComboBox.SelectedValue = currentUser.Role;
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
