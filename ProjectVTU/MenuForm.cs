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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangUsersForm changeUserForm = new ChangUsersForm();
            changeUserForm.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            User loggedUser = Registrator.LoggedUser;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                User foundUser = libraryContext.Users.Find(loggedUser.Id);

                if (foundUser.Role1.Name == "Guest")
                {
                    publishersGroupBox.Visible = false;
                    GenreGroupBox.Visible = false;
                    usersGroupBox.Visible = false;
                }
            }
        }

        private void booksGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void selectBooksButton_Click(object sender, EventArgs e)
        {
            SelectBooksForm selectBookForm = new SelectBooksForm();
            selectBookForm.Show();

        }

        private void changeBooksButton_Click(object sender, EventArgs e)
        {
            ChangeBooksForm changeBookForm = new ChangeBooksForm();
            changeBookForm.Show();

        }

        private void publishersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void changePublisherButton_Click(object sender, EventArgs e)
        {

            ChangePublisherForm changePublisherForm = new ChangePublisherForm();
            changePublisherForm.Show();
        }

        private void GenreGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void changeGenreButton_Click(object sender, EventArgs e)
        {

            ChangeGenreForm changeGenreForm = new ChangeGenreForm();
            changeGenreForm.Show();
        }

        private void usersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void selectUsersButton_Click(object sender, EventArgs e)
        {
            SelectUsersForm selectUsersForm = new SelectUsersForm();
            selectUsersForm.Show();
        }
    }
}
