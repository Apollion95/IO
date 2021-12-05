using Domain.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal interface IUserRepository : IDisposable
    {
        PagedList<User> GetUsers(int pageNumber);
        User GetUserById(int userId);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);

    }
}
