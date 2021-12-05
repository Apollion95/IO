using Domain.Entities;
using Infrastructure.Data;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
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
        public  const int PAGE_SIZE = 10;
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
            return (PagedList<User>)context.Users.ToPagedList(pageNumber,PAGE_SIZE);
        }

        public void InsertUser(User user)
        {
            context.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
        }
    }
}
