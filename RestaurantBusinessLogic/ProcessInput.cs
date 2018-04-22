using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantDataLogic;

namespace RestaurantBusinessLogic
{
    static internal class ProcessInput
    {
        static internal void GetRestaurants(params string[] restaurantParams)
        {
            List<Restaurant> rest = new List<Restaurant>();
            DButils db = new DButils();

            rest = db.GetRestaurantModels();
            
        }

        static internal void GetReviews(string restaurant)
        {

        }
    }
}
