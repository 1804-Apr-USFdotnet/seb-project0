using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBusinessLogic
{
    /// <summary>
    /// Validates command syntax. Possible commands:
    ///     1. "reviews [string]"
    ///     2. "restaurants [optional string]"
    /// </summary>
    public static class ValidateInput
    {
        public static string Validate(params string[] input)
        {
            if (ValidateCommand(input))
            {
                if (input[0] == "reviews") { return JsonConvert.SerializeObject(ProcessInput.GetReviews(input[1])); }
                else { return JsonConvert.SerializeObject(ProcessInput.GetRestaurants(input)); }
            }
            return null;
        }

        public static bool ValidateCommand(params string[] input)
        {
            if (input.Length == 0)
                return false;

            switch (input[0])
            {
                case "reviews":
                    if (input.Length == 1) { return false; }
                    else { return true; }

                case "restaurants":
                    return true;

                default:
                    return false;
            }
        }
    }
}
