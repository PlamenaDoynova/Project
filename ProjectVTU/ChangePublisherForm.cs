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
    public partial class ChangePublisherForm : Form
    {
        private Publisher currentPublisher;
        public ChangePublisherForm()
        {
            InitializeComponent();
        }

        private void ChangePublisherForm_Load(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                currentPublisher = libraryContext.Publishers
                    .OrderBy(publisher => publisher.Id)
                    .First();
            }

            publisherTextBox.Text = currentPublisher.Name;

        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (LibraryContext libraryContext = new LibraryContext())
            {
                List<Publisher> prevPublisher = libraryContext.Publishers
                    .Where(publisher => publisher.Id < currentPublisher.Id)
                    .OrderBy(publisher => publisher.Id)
                    .ToList();

                if (prevPublisher.Count > 0)
                {
                    currentPublisher = prevPublisher.Last();
                    publisherTextBox.Text = currentPublisher.Name;
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
                List<Publisher> nextPublisher = libraryContext.Publishers
                    .Where(publisher => publisher.Id > currentPublisher.Id)
                    .OrderBy(publisher => publisher.Id)
                    .ToList();

                if (nextPublisher.Count > 0)
                {
                    currentPublisher = nextPublisher.First();
                    publisherTextBox.Text = currentPublisher.Name;
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
                Publisher publisher = new Publisher()
                {
                    Name = publisherTextBox.Text
                };

                libraryContext.Publishers.Add(publisher);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                Publisher oldPublisher = libraryContext.Publishers.Find(currentPublisher.Id);

                Publisher newPublisher = new Publisher()
                {
                    Id = currentPublisher.Id,
                    Name = publisherTextBox.Text
                };

                libraryContext.Entry(oldPublisher).CurrentValues.SetValues(newPublisher);
                libraryContext.SaveChanges();
            }

            nextButton.PerformClick();
        }
    }
}
