﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBusinessLogic
{
    public static class ValidateInput
    {
        public static void Validate(params string[] input)
        {
            if (ValidateCommand(input))
            {
                if (input[0] == "reviews")
                    ProcessInput.GetReviews(input[1]);
                else
                    ProcessInput.GetRestaurants(input);
            }
        }

        private static bool ValidateCommand(params string[] input)
        {
            switch (input[0])
            {
                case "reviews":
                    if (input[1].Equals(String.Empty)) { return false; }
                    else { return true; }

                case "restaurants":
                    return true;

                default:
                    return false;
            }
        }
    }
}