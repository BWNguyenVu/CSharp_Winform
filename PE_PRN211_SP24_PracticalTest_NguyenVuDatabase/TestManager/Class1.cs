using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManagementDbContext context = new BookManagementDbContext();
            List<Book> arr = context.Books.ToList();
            arr.ForEach(x =>  Console.WriteLine(x.BookId + " | " + x.BookName
                + " | " + x.PublicationDate
                ));
        }
    }
}
