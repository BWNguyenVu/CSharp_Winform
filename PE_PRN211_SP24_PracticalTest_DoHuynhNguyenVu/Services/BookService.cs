using Repositories.Entities;
using Repositories;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new();
        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        public void UpdateBook(Book book)
        {
            _repo.UpdateBook(book);
        }

        public void DeleteBookFromUserSelected(Book book)
        {
            _repo.Delete(book);
        }

        public void CreateBookFromUserInput(Book book)
        {
            _repo.CreateBook(book);
        }
    }
}
