using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transactions> GetTransactions();
        Transactions GetById(int id);
        Transactions GetByUserId(int user_id);
        Transactions GetByBookName(string book_name);
        Transactions Add(Transactions transactions);
        void Update(Transactions transactions);
        void Delete(Transactions transactions);
    }
}
