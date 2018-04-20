
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLogic
{
    public class DButils : IDButils
    {
        public void AddRestaurant(Restaurant r)
        {
                using (var db = new RestaurantsEntities2())
                    db.Restaurants.Add(r);
        }

        public void AddReview(Review r)
        {
            using (var db = new RestaurantsEntities2())
                db.Reviews.Add(r);
        }

        public List<Restaurant> GetRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (var db = new RestaurantsEntities2())
            {
                var query = from r in db.Restaurants
                             orderby r.Rating
                             select r;

                foreach (var restaurant in query)
                {
                    restaurants.Add(restaurant);
                }
            }
            return restaurants;
        }

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

        public List<Review> GetReviews()
        {
            List<Review> reviews = new List<Review>();
            using (var db = new RestaurantsEntities2())
            {
                var query = from r in db.Reviews
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
