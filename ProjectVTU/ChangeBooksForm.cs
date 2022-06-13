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
    public partial class ChangeBooksForm : Form
    {
        private Book currentBook;
        public ChangeBooksForm()
        {
            InitializeComponent();
        }

        private void ChangeBooksForm_Load(object sender, EventArgs e)
        {

            List<Publisher> publishers;
            List<Genre> genre;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                publishers = libraryContext.Publishers.OrderBy(publisher => publisher.Id).ToList();
                genre = libraryContext.Genres.OrderBy(Genre => Genre.Id).ToList();

                currentBook = libraryContext.Books.First();
            }

            publishersComboBox.ValueMember = "Id";
            publishersComboBox.DisplayMember = "Name";
            publishersComboBox.DataSource = publishers;

            genreComboBox.ValueMember = "Id";
            genreComboBox.DisplayMember = "Name";
            genreComboBox.DataSource = genre;

            PopulateControls();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Name = nameComboBox.Text,
                Publisher = (int)publishersComboBox.SelectedValue,
                Genre = (int)genreComboBox.SelectedValue,
                Price = (int)priceNumericUpDown.Value
            };

            using (LibraryContext libraryContext = new LibraryContext())
            {
                libraryContext.Books.Add(book);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                Book oldBook = libraryContext.Books.Find(currentBook.Id);

                Book newBook = new Book()
                {
                    Id = currentBook.Id,
                    Name = nameComboBox.Text,
                    Publisher = (int)publishersComboBox.SelectedValue,
                    Genre = (int)genreComboBox.SelectedValue,
                    Price = (int)priceNumericUpDown.Value
                };

                libraryContext.Entry(oldBook).CurrentValues.SetValues(newBook);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                Book book = libraryContext.Books.Find(currentBook.Id);
                libraryContext.Books.Remove(book);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                List<Book> prevBooks = libraryContext.Books
                    .Where(book => book.Id < currentBook.Id)
                    .OrderBy(book => book.Id)
                    .ToList();

                if (prevBooks.Count > 0)
                {
                    currentBook = prevBooks.Last();
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
                List<Book> nextBook = libraryContext.Books
                    .Where(book => book.Id > currentBook.Id)
                    .OrderBy(book => book.Id)
                    .ToList();

                if (nextBook.Count > 0)
                {
                    currentBook = nextBook.First();
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
            nameComboBox.Text = currentBook.Name;
            priceNumericUpDown.Value = currentBook.Price;
            publishersComboBox.SelectedValue = currentBook.Publisher;
            genreComboBox.SelectedValue = currentBook.Genre;
        }
    }
}
