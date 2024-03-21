using Repositories.Entities;

namespace Services
{

  //3-layer Architecture:
  // [1]            [2]                [3]                          SQLSERVER        
  //UI-Forms  ---- Services  ------- Repositories -----------------    DB
  //MainUI    ---- BookService       BookRepository (Book Entity)    Book Table
  //  request/response         <----->      
  //  đưa data xuống DB                chơi trực tiếp DB: lên, xuống
  //  lấy data từ DB show                                 CRUD table thực sự
  //            RAM                                 DB ĐĨA CỨNG HDD/SSD 
    public class BookService
    {
        //Class này trung chuyển dữ liệu giữa Forms UI và CSDL
        //Nó chứa data trong RAM, xử lí mọi thứ thuật toán nếu cần rồi đẩy lên UI
        //hoặc cất xuống DB
        //chứa list các Book đọc từ DB và show lên UI
        //chứa info cuốn sách lấy từ màn hình UI dự định cập nhật xuống DB

        //THƯỜNG SẼ CHỨA CÁC HÀM CRUD NHƯNG CHỈ TRONG RAM - LINQ CÓ THỂ NHẢY VÀO

        //giả bộ đã đọc data từ DB lên rồi, giờ show ra màn hình UI
        //tạm thời hard-coded danh sách các cuốn sách trong RAM
        //bữa tới học cách lấy từ DB thực sự
        //lấy xong thì cx phải có n cuốn sách trả về trong RAM

        public List<Book> GetAllBooks()
        {
            //TODO: Gọi class BookRepository để lấy toàn bộ sách từ DB
            //Call class BookRepository to retrieve all books from DB
            List<Book> arr = new List<Book>();

            //using object initialization
            arr.Add(new Book()
            {
                BookId = 1,
                BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long",
                Description = "cc freeway...",
                Author = "Robin Sharma",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 2,
                BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright",
                Description = "Hiro lives in a Los Angeles where franchises line the freeway...",
                Author = "Kazuko Watanabe",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 3,
                BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth",
                Description = "Hiro lives in a Los Angeles where franchises line the freeway...",
                Author = "Rosie Nguyễn",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 4,
                BookName = "Snow Crash",
                Description = "Hiro lives in a Los Angeles where franchises line the freeway...",
                Author = "Neal Stephenson",
                BookCategoryId = 2
            });

            return arr;
        }
    }
}
