﻿using System;
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
            List<Restaurant> restaurants = new List<Restaurant>();
            List<RestaurantInfo> restInfo = new List<RestaurantInfo>();
            DButils db = new DButils();

            // Get list of restaurants from database
            restaurants = db.GetRestaurantModels();
            // Convert list of restaurant models to list of restaurant output objects
            restInfo = ConvertModels.GetRestaurantInfos(restaurants);
        }

        static internal void GetReviews(string restaurantName)
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
        }
    }
}
