using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;
        //we will new() for each CRUD method!!!

        public List<Book> GetBooks()
        {
            _context = new();
            return _context.Books.ToList();
        }//call DbContext to select * from Book

        public void UpdateBook(Book book)
        {
            _context = new();   //new again - rule
            _context.Books.Update(book);
            _context.SaveChanges();//no SQL statement is required, working on the object
        }

        public void CreateBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);//insert into table Books
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context = new();
            _context.Books.Remove(book);//delete from table Books where bookId = book.id
            _context.SaveChanges();
        }
    }
}
