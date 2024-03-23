using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        private UserRepository _repo = new();

        public UserAccount CheckLogin(
            string email, string pass)
        {
            UserAccount acc = _repo.GetUserAccount(email);
            if (acc != null && acc.Password == pass)
            {
                return acc;
            }

            return null;


        }

    }
}
