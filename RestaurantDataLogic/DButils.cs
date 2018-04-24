
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLogic
{
    public class DButils : IDButils
    {
        public int GetRestaurantId(string restaurantName)
        {
            using (var db = new RestaurantsEntities2())
            {
                return db.Restaurants.SingleOrDefault(r => r.RName == restaurantName).id;
            }
        }

        /// <summary>
        /// Get all restaurants to process in business logic
        /// </summary>
        /// <returns>List of all Restaurants</returns>
        public List<Restaurant> GetRestaurantModels()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (var db = new RestaurantsEntities2())
            {
                restaurants = db.Restaurants.ToList();
            }
            return restaurants;
        }

        /// <summary>
        /// Get reviews from a restaurant
        /// </summary>
        /// <returns>List of reviews</returns>
        public List<Review> GetReviewModels(int restaurantId)
        {
            List<Review> reviews = new List<Review>();
            using (var db = new RestaurantsEntities2())
            {
                var query = from r in db.Reviews
                            where r.id.Equals(restaurantId)
                            select r;

                //reviews = query.ToList();
                reviews = db.Reviews.Where(e => e.id.Equals(restaurantId)).ToList();
            }
            foreach (Review review in reviews)
            {
                Debug.WriteLine(review.Summary);
            }
            return reviews;
        }
    }
}
