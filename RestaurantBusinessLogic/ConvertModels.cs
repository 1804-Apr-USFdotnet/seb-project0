using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantDataLogic;

namespace RestaurantBusinessLogic
{
    /// <summary>
    /// Convert entity models to output objects
    /// </summary>
    static internal class ConvertModels
    {
        //convert list of restaurants to list of restaurantInfo
        static internal List<RestaurantInfo> GetRestaurantInfos(List<Restaurant> restaurants)
        {
            List<RestaurantInfo> output = new List<RestaurantInfo>();
            foreach (var restaurant in restaurants)
            {
                output.Add((RestaurantInfo)restaurant);
            }
            return output;
        }

        //convert list of reviews to list of reviewInfo
        static internal List<ReviewInfo> GetReviewInfos(List<Review> restaurants)
        {
            List<ReviewInfo> output = new List<ReviewInfo>();
            foreach (var restaurant in restaurants)
            {
                output.Add((ReviewInfo)restaurant);
            }
            return output;
        }
    }
}
