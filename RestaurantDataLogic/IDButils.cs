using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLogic
{
    interface IDButils
    {
        void AddRestaurant(Restaurant r);
        void AddReview(Review r);

        List<Restaurant> GetRestaurants();
        List<Restaurant> GetRestaurants(int top);               
        List<Review> GetReviews();
    }
}
