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
    public partial class ChangeGenreForm : Form
    {
        private Genre currentGenre;
        public ChangeGenreForm()
        {
            InitializeComponent();
        }

        private void ChangeGenreForm_Load(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                currentGenre = libraryContext.Genres
                    .OrderBy(genre => genre.Id)
                    .First();
            }

            genreTextBox.Text = currentGenre.Name;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                List<Genre> prevGenre = libraryContext.Genres
                    .Where(genre => genre.Id < currentGenre.Id)
                    .OrderBy(genre => genre.Id)
                    .ToList();

                if (prevGenre.Count > 0)
                {
                    currentGenre = prevGenre.Last();
                    genreTextBox.Text = currentGenre.Name;
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
                List<Genre> nextGenre = libraryContext.Genres
                    .Where(genre => genre.Id > currentGenre.Id)
                    .OrderBy(genre => genre.Id)
                    .ToList();

                if (nextGenre.Count > 0)
                {
                    currentGenre = nextGenre.First();
                    genreTextBox.Text = currentGenre.Name;
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                Genre genre = new Genre()
                {
                    Name = genreTextBox.Text
                };

                libraryContext.Genres.Add(genre);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                Genre oldGenre = libraryContext.Genres.Find(currentGenre.Id);

                Genre newGenre = new Genre()
                {
                    Id = currentGenre.Id,
                    Name = genreTextBox.Text
                };

                libraryContext.Entry(oldGenre).CurrentValues.SetValues(newGenre);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }
    }
}
