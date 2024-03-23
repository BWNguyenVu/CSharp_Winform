﻿using Repositories;
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
        private BookRepository _repo = new();
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
            return _repo.GetBooks();

        }
        //this method will be called by the form when user clicks SAVE BUTTON

        public void UpdateABookFromUserInput(Book b)
        {
            _repo.UpdateBook(b);
        }//book repor, i send you a book, update it into db

        public void CreateABookFromUserInput(Book b)
        {
            _repo.CreateBook(b);// ask the repo to help to store/save book
            //into the DB
        }
        public void DeleteABookFromUserSelected(Book b)
        {
            _repo.DeleteBook(b);
        }
    }
}