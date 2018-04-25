using System.Collections.Generic;

namespace RestaurantDataLogic
{
    public interface IUtility
    {
        int GetRestaurantId(string restaurantName);
        List<Restaurant> GetRestaurantModels();
        List<Review> GetReviewModels(int restaurantId);
    }
}
