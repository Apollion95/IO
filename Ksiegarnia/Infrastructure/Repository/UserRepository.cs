using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal class UserRepository : IUserRepository
    {

        private BookStoreContext context;

        public UserRepository(BookStoreContext context)
        {
            this.context = context;
        }
        public void DeleteUser(int userId)
        {
          
            User user = context.Users.Find(userId);
            if(user!=null)
             context.Users.Remove(user);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
