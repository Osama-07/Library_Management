using Guna.UI2.WinForms;
using Library_Management.Global;
using Library_Management.Properties;
using LibraryBusiness;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Util;

namespace Library_Management.Books.Controls
{
    public partial class ctrlAddEditBook : UserControl
    {
        public event Action OnSaveed;

        public enum enMode { AddNew = 1, Update = 2}
        public enMode Mode;

        // this info for adding or updating in this page.
        public int BookID { get; set; }
        public clsBooks BookInfo { get; set; } = new clsBooks();
        private int _EditionsNo { get; set; }
        private string _Image { get; set; }


        public ctrlAddEditBook()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            BookInfo = default;
            _EditionsNo = default;
            _Image = default;
            txtBookID.Clear();
            txtTitle.Clear();
            txtGenere.Clear();
            txtAuthor.Clear();
            txtAdditinalDetails.Clear();
            dtpPublication_Date.Value = DateTime.Now;
            nupNumberOfCopies.Value = 1;
            pbBookImage.Image = Resources.No_Book;
        }

        private void _FillBookInfo()
        {
            DataTable dtBookInfo = clsBooks.GetBookInfoWithImage(BookID);
            DataView dvBookInfo = dtBookInfo.DefaultView;

            foreach (DataRowView row in dvBookInfo)
            {
                BookID = (int)row["Book_ID"];
                BookInfo.Title = (string)row["Title"];
                BookInfo.Gener = (string)row["Gener"];
                BookInfo.Author = (string)row["Author"];
                BookInfo.ISBN = (int)row["ISBN"];
                BookInfo.Publication_Date = (DateTime)row["Publication_Date"];

                if (row["AdditinalDetails"] != DBNull.Value)
                    BookInfo.AdditinalDetails = (string)row["AdditinalDetails"];
                else
                    BookInfo.AdditinalDetails = null;

                _EditionsNo = (int)row["EditionsNo"];
                _Image = (string)row["Image"];
            }
        }

        public void LoadBookInfo(int bookID)
        {
            BookID = bookID;

            if (Mode == enMode.Update && BookInfo != null)
            {
                _FillBookInfo();

                txtBookID.Text = BookID.ToString();
                txtTitle.Text = BookInfo.Title;
                txtGenere.Text = BookInfo.Gener;
                txtAuthor.Text = BookInfo.Author;
                txtISBN.Text = BookInfo.ISBN.ToString();
                txtAdditinalDetails.Text = BookInfo.AdditinalDetails;
                dtpPublication_Date.Value = BookInfo.Publication_Date;
                nupNumberOfCopies.Value = _EditionsNo;
                pbBookImage.ImageLocation = _Image;
                lblRemove.Visible = true;
                //pbBookImage.Tag = 1; // 1 =  meanse there are image in it.
            }
        }

        private bool _CheckTextBoxIsNullOrEmpty(Guna2TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BorderColor = Color.Red;
                return false;
            }
            else
            {
                textBox.BorderColor = Color.Silver;
                return true;
            }
        }

        private bool _CheckImage()
        {
            if (pbBookImage.ImageLocation == null || pbBookImage.Image == Resources.No_Book)
            {
                MessageBox.Show("you must be add the book image.", "Requaired", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                return true;
            }
        }

        bool _HandleBookImage()
        {
            if (Mode == enMode.AddNew)
            {
                if (pbBookImage.ImageLocation != null)
                {
                    string sourcefile = pbBookImage.ImageLocation;

                    if (clsGlobal.Util.CopyImageToProjectImagesFolder(ref sourcefile))
                    {
                        pbBookImage.ImageLocation = sourcefile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                else
                    return false;
            }

            if (Mode == enMode.Update)
            {
                // if the book image is changed, the old image will be deleted and new image will be added.
                if (_Image != pbBookImage.ImageLocation)
                {
                    
                    // if old image exists in folder images, will be deleted and save new image book.
                    if (_Image != "")
                    {
                        //first we delete the old image from the folder in case there is any.
                        try
                        {
                            clsGlobal.ImagesPathForDelete.Add(_Image);
                        }
                        catch (IOException iox)
                        {
                            // we could not delete image the fail.
                            // log it later.
                            MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }


                    // if the book image field is not wmpty, a new book image will be added.
                    if (pbBookImage.ImageLocation != null)
                    {
                        string sourcefile = pbBookImage.ImageLocation;

                        if (clsGlobal.Util.CopyImageToProjectImagesFolder(ref sourcefile))
                        {
                            pbBookImage.ImageLocation = sourcefile;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }


            return true;
        }

        private bool _IsDataEnteredCorrect()
        {
            if (_CheckTextBoxIsNullOrEmpty(txtTitle)
                && _CheckTextBoxIsNullOrEmpty(txtAuthor)
                && _CheckTextBoxIsNullOrEmpty(txtISBN)
                && _CheckTextBoxIsNullOrEmpty(txtGenere)
                && _CheckImage())
            {
                return true;
            }
            else
                return false;
        }

        private bool _AddNewBook()
        {
            clsBooks Book = new clsBooks();

            Book.Title = txtTitle.Text;
            Book.Author = txtAuthor.Text;
            Book.ISBN = Convert.ToInt32(txtISBN.Text);
            Book.Publication_Date = dtpPublication_Date.Value;
            Book.Gener = txtGenere.Text;
            Book.AdditinalDetails = txtAdditinalDetails.Text;

            _EditionsNo = Convert.ToInt32(nupNumberOfCopies.Value);
            string ControlName = "btnBook";
            _Image = pbBookImage.ImageLocation;

            return Book.AddNewBookWithCopiesAndControl(_EditionsNo, ControlName, _Image);
        }

        private bool _UpdateBook()
        {
            BookInfo.Book_ID = Convert.ToInt32(txtBookID.Text);
            BookInfo.Title = txtTitle.Text;
            BookInfo.Author = txtAuthor.Text;
            BookInfo.ISBN = Convert.ToInt32(txtISBN.Text);
            BookInfo.Publication_Date = dtpPublication_Date.Value;
            BookInfo.Gener = txtGenere.Text;
            BookInfo.AdditinalDetails = txtAdditinalDetails.Text;

            _EditionsNo = Convert.ToInt32(nupNumberOfCopies.Value);
            string ControlName = "btnBookID" + BookID;

            if (pbBookImage.ImageLocation != null && _Image != pbBookImage.ImageLocation)
                _Image = pbBookImage.ImageLocation;

            return BookInfo.UpdateBookWithCopiesAndControl(_EditionsNo, ControlName, _Image);
        }

        private bool _Save()
        {
            if (!_HandleBookImage())
                return false;

            if (Mode == enMode.AddNew)
            {
                if (_AddNewBook())
                {
                    MessageBox.Show("Added Book Successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (_UpdateBook())
                {
                    MessageBox.Show("Updated Book Successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
        }



        private void lblBookImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.InitialDirectory = @"G:\";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbBookImage.ImageLocation = openFileDialog1.FileName;
                //_Image = openFileDialog1.FileName;
                lblRemove.Visible = true;
                //pbBookImage.Tag = 1;  // 1 =  meanse there are image in it.
            }

        }

        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbBookImage.ImageLocation = null;
            pbBookImage.Image = Resources.No_Book;
            lblRemove.Visible = false;
            //pbBookImage.Tag = 0;  //  =  meanse there are not image in it.
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int id))
            {
                txtBookID.BorderColor = Color.Red;
                return;
            }
            else
                txtBookID.BorderColor = Color.Silver;

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtISBN.Text, out int id))
            {
                txtISBN.BorderColor = Color.Red;
                return;
            }
            else
                txtISBN.BorderColor = Color.Silver;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsDataEnteredCorrect())
            {
                MessageBox.Show($"Enter the required information correctly.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_Save())
            {
                OnSaveed?.Invoke();
            }
        }

        private void txtBoxes_Validating(object sender, CancelEventArgs e)
        {
            _CheckTextBoxIsNullOrEmpty((Guna2TextBox)sender);
        }

    }
}