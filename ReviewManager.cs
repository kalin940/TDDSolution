using System.Collections.Generic;
using System.Linq;
namespace TDDSolution
{
    public class ReviewManager
    {
        public IList<Review> Reviews { get; set; }

        public ReviewManager()
        {
            Reviews = new List<Review>();
        }

        public double GetRating()
        {
            return (double)Reviews.Sum(p => p.Rating) / Reviews.Count;
        }

        public void GiveReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}