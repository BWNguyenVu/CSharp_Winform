using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_DoHuynhNguyenVu
{
    public partial class BookDetails : Form
    {
        public Book SelectedBook { get; set; } = null;
        public BookDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void BookDetails_Load(object sender, EventArgs e)
        {
            BookCategoryService category = new BookCategoryService();
            cbBookCategoryId.DataSource = category.GetAllCategories();
            cbBookCategoryId.DisplayMember = "BookGenreType";
            cbBookCategoryId.ValueMember = "BookCategoryId";
            if (SelectedBook != null)
            {
                //fill in the data
                txtBookId.Enabled = false;
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                cbBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;
                dtpPublicationDate.Text = SelectedBook.PublicationDate.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author.ToString();
            }
            else;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                Author = txtAuthor.Text,
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                BookCategoryId = int.Parse(cbBookCategoryId.SelectedValue.ToString())
            };

            BookService service = new();
            if (SelectedBook != null)
            {
                //edit mode
                service.UpdateBook(book);
            }
            else
            {
                service.CreateBookFromUserInput(book);
            }

            //close
            Close();
        }



        private void cbBookCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
