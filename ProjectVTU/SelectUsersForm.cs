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
    public partial class SelectUsersForm : Form
    {
        public SelectUsersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectUsersForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                roles = libraryContext.Roles.OrderBy(role => role.Id).ToList();
            }

            rolesComboBox.ValueMember = "Id";
            rolesComboBox.DisplayMember = "Name";
            rolesComboBox.DataSource = roles;
        }

        private void rolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roledId = (int)rolesComboBox.SelectedValue;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                List<User> filteredUsers = libraryContext.Users.Where(user => user.Role == roledId).ToList();

                PopulateListView(filteredUsers);
            }
        }
        private void PopulateListView(List<User> users)
        {
            filteredUsersListView.Items.Clear();

            foreach (User user in users)
            {
                string[] rowData = new string[] { user.FirstName, user.LastName, user.UserName };
                ListViewItem item = new ListViewItem(rowData);
                filteredUsersListView.Items.Add(item);
            }
        }

        private void filteredUsersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
