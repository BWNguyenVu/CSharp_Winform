using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository
    {
        private BookManagementDbContext _context;

        public List<UserAccount> GetUserAccounts()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }
        public UserAccount GetUserAccount(string email)
        {
            _context = new();
            return (_context.UserAccounts.FirstOrDefault(x => x.Email == email));
        }
    }
}
