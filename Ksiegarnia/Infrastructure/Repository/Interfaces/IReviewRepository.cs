using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public interface IReviewRepository 
    {
        IEnumerable<Review> GetReview();
        Review GetByName(string name);
        Review GetById(int id);
        Review GetByRating(int rating);
        Review Add(Review review);
        void Update(Review review);
        void Delete(Review review);
    }
}
