using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly BookStoreContext _context;

        public TransactionsRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Transactions> GetTransactions()
        {
            return _context.Transactions;  
        }
        public Transactions GetByBookName(string book_name)
        {
            return _context.Transactions.SingleOrDefault(x=>x.book.name == book_name);
        }

        public Transactions GetById(int id)
        {
            return _context.Transactions.SingleOrDefault(x => x.trans_id == id);
        }

        public Transactions GetByUserId(int user_id)
        {
            return _context.Transactions.SingleOrDefault(x => x.user.user_id== user_id);
        }

       
        public Transactions Add(Transactions transactions)
        {
            _context.Transactions.Add(transactions);
            _context.SaveChanges();
            return transactions;

        }
        public void Update(Transactions transactions)
        {
            _context.Transactions.Update(transactions);
            _context.SaveChanges();
        }
       

        public void Delete(Transactions transactions)
        {
            _context.Transactions.Remove(transactions);
            _context.SaveChanges();
        }
    }
}
