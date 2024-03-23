using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        BookCategoryRepository _repo = new BookCategoryRepository();

        public List<BookCategory> GetAllCategories()
        {
            return _repo.GetAllBookCategories();


        }
    }
}
