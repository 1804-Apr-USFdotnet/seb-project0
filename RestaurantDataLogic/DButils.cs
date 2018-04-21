
using System;
using System.Collections.Generic;
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
        public List<Restaurant> GetRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (var db = new RestaurantsEntities2())
            {
                var query = from r in db.Restaurants
                             select r;

                foreach (var restaurant in query)
                {
                    restaurants.Add(restaurant);
                }
            }
            return restaurants;
        }

        /// <summary>
        /// Get top # of restaurants based on average rating
        /// </summary>
        /// <param name="top"># of restaurants</param>
        /// <returns>List of restaurants</returns>
        public List<Restaurant> GetRestaurants(int top)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (var db = new RestaurantsEntities2())
            {
                var query = (from r in db.Restaurants
                            orderby r.Rating
                            select r).Take(top);

                foreach (var restaurant in query)
                {
                    restaurants.Add(restaurant);
                }
            }
            return restaurants;
        }

        /// <summary>
        /// Get reviews from a restaurant
        /// </summary>
        /// <returns>List of reviews</returns>
        public List<Review> GetReviews(int restaurantId)
        {
            List<Review> reviews = new List<Review>();
            using (var db = new RestaurantsEntities2())
            {
                var query = from r in db.Reviews
                            where r.id == restaurantId
                            select r;

                foreach (var review in query)
                {
                    reviews.Add(review);
                }
            }
            return reviews;
        }
    }
}
