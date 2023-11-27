using Currency.Entities.EntityModels;
using Currency.Repository.Contracts;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Repository
{
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateUser(User user)
        {
            Create(user);
            _context.SaveChanges();
        }

        public User GetUserByEmail(string userEmail)
        {
            return _context.Users.Where(u => u.Email.Equals(userEmail)).FirstOrDefault();
        }


    }


}
