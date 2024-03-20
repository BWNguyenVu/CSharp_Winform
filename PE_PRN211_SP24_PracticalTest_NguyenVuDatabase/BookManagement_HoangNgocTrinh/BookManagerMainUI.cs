using Repositories.Entities;
using Services;

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookManagerMainUI : Form
    {
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            //gọi Services để cung cấp data vào grid/table
            BookService service = new BookService();

            dgvBookList.DataSource = null; //xoá trắng grid
            dgvBookList.DataSource = service.GetAllBooks();
            //                               hàm I trả về all books
        }

        private void grbSearchCriteria_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là class BookDetailFrom, khác truyền thống là nó có phần render bề mặt!!!
            //Nó 1 class nên nó sẽ có _field, prop, methods như bt
            //khai báo biến, new như bt
            //thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em 
            //f.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới!!!

        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột, cho nên ta sẽ lấy dòng đầu tiên đc chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó ra, đẩy sang màn hình detail
                Book selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;  //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks()

                //đẩy sang Form Detail
                //khai biến, new, gán prop, show dialog
                //thằng form detail: mở lên, check selected khác null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = selected;
                f.ShowDialog();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // lấy ra 2 chuỗi  nằm trong txtBookName & txtDescription
            BookService service = new BookService();
            var books = service.GetAllBooks();
            dgvBookList.DataSource = null;

            dgvBookList.DataSource = books.Where(
            x =>
            x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) ||
            x.Description.ToLower().Contains(txtDescription.Text.ToLower())

            )
              .ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
