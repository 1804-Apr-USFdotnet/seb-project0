using Newtonsoft.Json;
using RestaurantBusinessLogic.CustomExceptions;

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
            ValidateCommand(input);
            if (input[0] == "reviews")
            {
                return JsonConvert.SerializeObject(ProcessInput.GetReviews(input[1]));
            }

            else
            {
                return JsonConvert.SerializeObject(ProcessInput.GetRestaurants(input));
            }
        }

        public static void ValidateCommand(params string[] input)
        {
            if (input.Length == 0) throw new InvalidInputException(); // no command given

            switch (input[0])
            {
                case "reviews":
                    if (input.Length == 1) throw new InvalidParameterException(); // no parameters exist
                    break;
                case "restaurants":
                    break;
                default:
                    throw new InvalidCommandException(); // invalid command
            }
        }
    }
}
