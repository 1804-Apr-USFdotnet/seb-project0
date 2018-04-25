using Newtonsoft.Json;

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
            /*if (*/ValidateCommand(input);
            //{
                if (input[0] == "reviews") { return JsonConvert.SerializeObject(ProcessInput.GetReviews(input[1])); }
                else { return JsonConvert.SerializeObject(ProcessInput.GetRestaurants(input)); }
            //}
            //return null;
        }

        public static void ValidateCommand(params string[] input)
        {
            if (input.Length == 0)
                throw new InvalidInputException();
                //return false;

            switch (input[0])
            {
                case "reviews":
                    if (input.Length == 1) throw new InvalidInputException(); // { return false; }
                    //else { return true; }
                    break;
                case "restaurants":
                    //return true;
                    break;
                default:
                    throw new InvalidInputException();
                    //return false;
                    break;

            }
        }
    }
}
