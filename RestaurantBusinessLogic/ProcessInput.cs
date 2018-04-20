using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBusinessLogic
{
    static class ProcessInput
    {
        static void Process(input i)
        {
            if (Validate(i))
            {
                //output = i.modelType == "review" ? GetReviews() : GetRestaurants());
            }
        }

        private static bool Validate(input i)
        {
            if (i.commandType != "set" && i.commandType != "get")
                return false;
            if (i.modelType != "restaurant" && i.modelType != "review")
                return false;
            if (i.nameParam == string.Empty)
                return false;
            if (i.bodyParam == string.Empty)
                return false;
            if (i.commandType == "set" && i.modelType == "review" && (i.rating > 5 || i.rating < 0))
                return false;

            return true;
        }

        private static void AddRestaurant(input i)
        {

        }

        private static void GetRestaurants(input i)
        {

        }

        private static void GetTopRestaurants(input i)
        {

        }

        private static void AddReview(input i)
        {

        }

        private static void GetReviews(input i)
        {

        }
    }
}
