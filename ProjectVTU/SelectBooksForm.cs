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
    public partial class SelectBooksForm : Form
    {
        private string filter = "publisher";
        public SelectBooksForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectBooksForm_Load(object sender, EventArgs e)
        {
            List<Publisher> publishers;
            List<Genre> genre;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                publishers = libraryContext.Publishers.OrderBy(publisher => publisher.Id).ToList();
                genre = libraryContext.Genres.OrderBy(genres => genres.Id).ToList();
            }

            publishersComboBox.ValueMember = "Id";
            publishersComboBox.DisplayMember = "Name";
            publishersComboBox.DataSource = publishers;

            genreComboBox.ValueMember = "Id";
            genreComboBox.DisplayMember = "Name";
            genreComboBox.DataSource = genre;

            //combineFiltersButton.BackgroundImage = filter == "publisher" || filter == "genre"
            //    ? Resources.unlocked
            //    : Resources.locked;
        }

        private void publishersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter != "publisher & genre")
            {
                filter = "publisher";
            }

            ApplyFilters();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter != "publisher & genre")
            {
                filter = "publisher";
            }

            ApplyFilters();
        }

        //private void combineFiltersButton_Click(object sender, EventArgs e)
        //{
        //    if (filter == "publisher" || filter == "genre")
        //    {
        //        filter = "publisher & genre";
        //    }
        //    else
        //    {
        //        filter = "publisher";
        //    }

        //    //combineFiltersButton.BackgroundImage = filter == "publisher" || filter == "genre"
        //    //    ? Resources.unlocked
        //    //    : Resources.locked;

        //    ApplyFilters();
        //}
        private void ApplyFilters()
        {
            int PublisherId;
            int GenreId;
            List<Book> filteredBooks = null;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                if (filter == "publisher & genre")
                {
                    PublisherId = (int)publishersComboBox.SelectedValue;
                    GenreId = (int)genreComboBox.SelectedValue;

                    filteredBooks = libraryContext.Books
                        .Where(book => book.Publisher == PublisherId && book.Genre == GenreId)
                        .ToList();
                }
                else
                {
                    if (filter == "publisher")
                    {
                        PublisherId = (int)publishersComboBox.SelectedValue;

                        filteredBooks = libraryContext.Books
                        .Where(book => book.Publisher == PublisherId)
                        .ToList();
                    }
                    else if (filter == "genre")
                    {
                        GenreId = (int)genreComboBox.SelectedValue;

                        filteredBooks = libraryContext.Books
                        .Where(book => book.Genre == GenreId)
                        .ToList();
                    }
                }

               PopulateListView(filteredBooks);
            }
        }
        private void PopulateListView(List<Book> books)
        {
            //ImageList imageListSmall = new ImageList();
            //imageListSmall.ImageSize = new Size(200, 100);

            filteredBooksListView.Items.Clear();

            for (int index = 0; index < books.Count; index++)
            {
                Book book = books[index];

                string[] rowData = new string[]
                {
                    book.Publisher1.Name,
                    book.Name,
                    book.Genre1.Name,
                    book.Price.ToString() + " лв."
                };

                ListViewItem item = new ListViewItem(rowData);
                //item.ImageIndex = index;
                filteredBooksListView.Items.Add(item);

                //Image image = Bitmap.FromFile($"CourseToVictory{book.Name}.jpg");
                //imageListSmall.Images.Add(image);
            }

            //filteredBooksListView.SmallImageList = imageListSmall;
        }

        private void filteredBooksListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combineFiltersButton_Click(object sender, EventArgs e)
        {
            if (filter == "publisher" || filter == "genre")
            {
                filter = "publisher & genre";
            }
            else
            {
                filter = "publisher";
            }

            //combineFiltersButton.BackgroundImage = filter == "publisher" || filter == "genre"
            //    ? Resources.unlocked
            //    : Resources.locked;

            ApplyFilters();

        }
    }
}
