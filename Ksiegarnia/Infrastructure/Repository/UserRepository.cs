using Domain.Entities;
using Infrastructure.Data;
using Microsoft.CodeAnalysis;
using PagedList;
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
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public Optional<User> GetUserById(int userId)
        {
            Optional<User> user =  context.Users.Find(userId);
            return user;
        }

        public PagedList<User> GetUsers(int pageNumber)
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
