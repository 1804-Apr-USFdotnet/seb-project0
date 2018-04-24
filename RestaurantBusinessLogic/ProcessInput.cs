using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantDataLogic;

namespace RestaurantBusinessLogic
{
    static internal class ProcessInput
    {
        static internal List<RestaurantInfo> GetRestaurants(params string[] restaurantParams)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            List<RestaurantInfo> restaurantsInfo = new List<RestaurantInfo>();
            DButils db = new DButils();

            // Get list of restaurants from database
            restaurants = db.GetRestaurantModels();

            // Convert list of restaurant models to list of restaurant output objects
            restaurantsInfo = ConvertModels.GetRestaurantInfos(restaurants);

            // Sort list based on optional parameters
            if (restaurantParams.Length > 1) { SortRestaurants.Sort(ref restaurantsInfo, restaurantParams); }

            return restaurantsInfo;
        }

        static internal List<ReviewInfo> GetReviews(string restaurantName)
        {
            List<Review> reviews = new List<Review>();
            List<ReviewInfo> reviewsInfo = new List<ReviewInfo>();
            DButils db = new DButils();

            //Get restaurant id based on name
            int restaurantId = db.GetRestaurantId(restaurantName);

            // Get list of reviews from database based on restaurant id
            reviews = db.GetReviewModels(restaurantId);

            // Convert list of review models to list of review output objects
            reviewsInfo = ConvertModels.GetReviewInfos(reviews);

            return reviewsInfo;
        }
    }
}
