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
            //ForEach print all

            arr.ForEach(x =>
            {
                if(x.BookCategoryId == 5)
                {
                    Console.WriteLine(x.BookId + " | " + x.BookName
                + " | " + x.PublicationDate
                );
                }

            }

            );
            

        }
    }
}
