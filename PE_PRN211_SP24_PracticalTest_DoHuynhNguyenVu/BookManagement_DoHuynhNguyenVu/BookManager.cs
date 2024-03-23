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
    public partial class BookManager : Form
    {
        private Book _selected = null;
        private BookService _service = new BookService();
        public BookManager()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = _service.GetAllBooks();
        }

        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                _selected = (Book)dgvTable.SelectedRows[0].DataBoundItem;

            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetails bookDetails = new BookDetails();
            bookDetails.ShowDialog();
            RefreshDataGridView();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = _service.GetAllBooks();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTable.SelectedRows[0];
                Book selectedBook = (Book)selectedRow.DataBoundItem;

                DialogResult answer = MessageBox.Show("Really want to delete row " + (selectedRow.Index + 1) + "?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    return;
                }

                _service.DeleteBookFromUserSelected(selectedBook);
                RefreshDataGridView();
            }
        }


        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var books = _service.GetAllBooks();
            dgvTable.DataSource = null;
            dgvTable.DataSource = books.Where(
                book => book.BookName.ToLower().Contains(txtBookName.Text.ToLower())
                ||
                book.Description.ToLower().Contains(txtDescription.Text.ToLower())
                ).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                BookDetails detail = new BookDetails();
                detail.SelectedBook = _selected; 
                detail.ShowDialog();
                //refresh the grid
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a certain book to edit", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
