using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLogic
{
    interface IDButils
    {
        int GetRestaurantId(string restaurantName);
        List<Restaurant> GetRestaurants();
        List<Restaurant> GetRestaurants(int top); 
        List<Review> GetReviews(int restaurantId);
    }
}
