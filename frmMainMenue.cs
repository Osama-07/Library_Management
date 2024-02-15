using System;
using System.Collections.Generic;

using System.Windows.Forms;
using LibraryBusiness;

namespace Library_Management
{
    public partial class frmMainMenue : Form
    {
        public frmMainMenue()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int BookID;

            if (int.TryParse(txtID.Text, out int ID))
                BookID = ID;
            else
                return;

            //clsBookCopies copies = new clsBookCopies();

            //copies.Book_ID = BookID;
            //copies.AvailabilityStatus = true;
            clsBooks Book = new clsBooks();

            Book.Title = txtTitle.Text;
            Book.Author = txtAuthor.Text;
            Book.ISBN = Convert.ToInt32(txtISBN.Text);
            Book.Publication_Date = dtpPublication_Date.Value;
            Book.Gener = txtGener.Text;
            Book.AdditinalDetails = txtAdditinalDetailse.Text;

            if (Book.Save())
            {
                MessageBox.Show($"Added Successfully with ID = {Book.Book_ID}.", "Succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fuck ur self.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int BookID;

            if (int.TryParse(txtID.Text, out int ID))
                BookID = ID;
            else
                return;

            clsBooks Book = clsBooks.FindByBook_ID(BookID);

            Book.Title = txtTitle.Text;
            Book.Author = txtAuthor.Text;
            Book.ISBN = Convert.ToInt32(txtISBN.Text);
            Book.Publication_Date = dtpPublication_Date.Value;
            Book.Gener = txtGener.Text;
            Book.AdditinalDetails = txtAdditinalDetailse.Text;

            if (Book.Save())
            {
                MessageBox.Show($"Updated Successfully with ID = {Book.Book_ID}.", "Succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fuck ur self.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int BookID;

            if (int.TryParse(txtID.Text, out int ID))
                BookID = ID;
            else
                return;
            
            clsBooks Book = clsBooks.FindByBook_ID(BookID);

            if (Book != null)
            {
                MessageBox.Show($"BookID: {Book.Book_ID}\n\nTitle: {Book.Title}\n\nAuthor: {Book.Author}\n\nISBN: {Book.ISBN}\n\nPublication_Date: {Book.Publication_Date}\n\nGener: {Book.Gener}\n\nAdditinalDetails: {Book.AdditinalDetails}", "Finded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fuck ur self.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIsExists_Click(object sender, EventArgs e)
        {
            int BookID;

            if (int.TryParse(txtID.Text, out int ID))
                BookID = ID;
            else
                return;

            if (clsBooks.IsExist(BookID))
            {
                MessageBox.Show($"Book with ID {BookID} is Exists", "Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fuck ur self.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int BookID;

            if (int.TryParse(txtID.Text, out int ID))
                BookID = ID;
            else
                return;

            if (clsBooks.Delete(BookID))
            {
                MessageBox.Show($"Deleted Book with ID {BookID} Successfully", "Succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Fuck ur self.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
