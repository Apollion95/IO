using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int userId);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);

    }
}
