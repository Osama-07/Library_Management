﻿using Guna.UI2.WinForms;
using LibraryBusiness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management.Books.Controls
{
    public partial class ctrlShowBooksCataloge : UserControl
    {
        private static DataTable _dtBookControls = new DataTable();
        public DataView dvBookControls = new DataView(_dtBookControls);

        public int CountControls
        {
            get
            {
                return _dtBookControls.Rows.Count;
            }
        }

        public ctrlShowBooksCataloge()
        {
            InitializeComponent();
        }

        public class BtnBookClick
        {
            public int BookID { get; set; }
            public clsBooks BookInfo
            {
                get
                {
                    return clsBooks.FindByBook_ID(BookID);
                }
            }

            public BtnBookClick(int bookID)
            {
                this.BookID = bookID;
            }
        }

        public event EventHandler<BtnBookClick> OnBtnBookClick;

        private void RaiseOnBtnBookClick(int BookID)
        {
            RaiseOnBtnBookClick(new BtnBookClick(BookID));
        }
        protected void RaiseOnBtnBookClick(BtnBookClick e)
        {
            OnBtnBookClick?.Invoke(this, e);
        }

        public void Referesh()
        {
            _dtBookControls = clsBookControls.GetAllBookControls();
            dvBookControls = _dtBookControls.DefaultView;

            panelBooks.Controls.Clear();
            foreach (DataRowView row in dvBookControls)
            {
                Guna2TileButton bookButton = new Guna2TileButton();

                ButtonStyle(ref bookButton, row);
                bookButton.Click += (s, sv) => RaiseOnBtnBookClick(Convert.ToInt32(bookButton.Tag)); // stored book id in btn tag.

                panelBooks.Controls.Add(bookButton);
                AdjustButtonPositions();
            }
        }

        private void ButtonStyle(ref Guna2TileButton bookButton, DataRowView row)
        {
            bookButton.Size = new Size(120, 172);
            bookButton.BackColor = Color.Transparent;
            bookButton.Cursor = Cursors.Hand;
            bookButton.Name = (string)row["Name"];
            bookButton.Animated = true;
            bookButton.BorderRadius = 25;
            bookButton.BorderThickness = 1;
            bookButton.BorderColor = Color.Silver;
            bookButton.FillColor = Color.WhiteSmoke;
            bookButton.ForeColor = Color.Black;
            bookButton.TextOffset.Offset(0, 20);
            bookButton.Text = (string)row["Title"];
            bookButton.Font = new Font(bookButton.Font, FontStyle.Bold);
            bookButton.Tag = (int)row["Book_ID"];

            // Image.
            bookButton.ImageSize = new Size(90, 90);
            bookButton.Image = Image.FromFile((string)row["Image"]);
        }

        private void AdjustButtonPositions()
        {
            int buttonWidth = 120;
            int buttonHeight = 172;
            int spacing = 25; // المسافة بين الأزرار

            int x = spacing;
            int y = spacing;

            foreach (Control control in panelBooks.Controls)
            {
                if (control is Guna2TileButton)
                {
                    // تحديد موقع الزر
                    control.Location = new System.Drawing.Point(x, y);

                    // تحديد موقع الزر التالي
                    x += buttonWidth + spacing;

                    // إذا تجاوز الزر العرض المتاح، انتقل إلى السطر التالي
                    if (x + buttonWidth + spacing > panelBooks.Width)
                    {
                        x = spacing;
                        y += buttonHeight + spacing;
                    }
                }
            }
        }

        public void LoadBookControls()
        {
            panelBooks.Controls.Clear();
            foreach (DataRowView row in dvBookControls)
            {
                Guna2TileButton bookButton = new Guna2TileButton();

                ButtonStyle(ref bookButton, row);
                bookButton.Click += (s, sv) => MessageBox.Show($"this Book ID {bookButton.Tag}.", $"{bookButton.Text}", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                panelBooks.Controls.Add(bookButton);
                AdjustButtonPositions();
            }
            //Referesh();
        }

        public void ClearControls()
        {
            panelBooks.Controls.Clear();
        }

    }
}
