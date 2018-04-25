﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLogic
{
    public class DBUtility : IUtility
    {
        public int GetRestaurantId(string restaurantName)
        {
            using (var db = new RestaurantsEntities2())
            {
                return db.Restaurants.SingleOrDefault(r => r.RName == restaurantName).id;
            }
        }

        /// <summary>
        /// Get all restaurants to process in business logic
        /// </summary>
        /// <returns>List of all Restaurants</returns>
        public List<Restaurant> GetRestaurantModels()
        {
            using (var db = new RestaurantsEntities2())
            {
                return db.Restaurants.ToList();
            }
        }

        /// <summary>
        /// Get reviews from a restaurant
        /// </summary>
        /// <returns>List of reviews</returns>
        public List<Review> GetReviewModels(int restaurantId)
        {
            using (var db = new RestaurantsEntities2())
            {
                return db.Reviews.AsNoTracking().Where(e => e.id.Equals(restaurantId)).ToList();
            }
        }
    }
}