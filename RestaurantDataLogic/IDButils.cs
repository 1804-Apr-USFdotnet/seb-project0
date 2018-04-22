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
        List<Restaurant> GetRestaurantModels();
        List<Review> GetReviewModels(int restaurantId);
    }
}
