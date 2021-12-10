using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly BookStoreContext _context;

        public ReviewRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> GetReview()
        {
            return _context.Reviews;
        }
       

        public Review GetById(int id)
        {
            return _context.Reviews.SingleOrDefault(x => x.review_id==id);
        }

        public Review GetByName(string name)
        {
            return _context.Reviews.SingleOrDefault(x => x.review==name);
        }

        public Review GetByRating(int rating)
        {
            return _context.Reviews.SingleOrDefault(x => x.rating==rating);
        }


        public Review Add(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
            return review; 
        }

       
        public void Update(Review review)
        {
           _context.Reviews.Update(review);
           _context.SaveChanges();
            
        }
        public void Delete(Review review)
        {
            _context.Remove(review);
            _context.SaveChanges();
        }
    }
}
