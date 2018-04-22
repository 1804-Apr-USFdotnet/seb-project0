using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestaurantBusinessLogic;

namespace RestaurantConsole
{
    static internal class Input
    {
        /// <summary>
        /// Main loop of application
        /// </summary>
        internal static void GetInput()
        {
            Console.WriteLine("Type '?' for help.");
            Console.WriteLine("Type 'exit' to close application.");

            while (true)
            {
                string input = Console.ReadLine();
                Console.Clear();

                if (input.Equals("?")) { Output.PrintHelp(); }          // list commands
                else if (input.Equals("exit")) { break; }   // exit application
                else
                {
                    // split arguments into string array to process in business logic
                    string[] inputParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string response = ValidateInput.Validate(inputParams);

                    if (response != null)
                    {
                        switch (inputParams[0])
                        {
                            case "restaurants":
                                List <RestaurantInfo> outputRes = new List<RestaurantInfo>(JsonConvert.DeserializeObject<List<RestaurantInfo>>(response));
                                Output.PrintRestaurants(outputRes);
                                break;
                            case "reviews":
                                List<RestaurantInfo> outputRev = new List<RestaurantInfo>(JsonConvert.DeserializeObject<List<RestaurantInfo>>(response));
                                Output.PrintRestaurants(outputRev);
                                break;
                        }
                    }
                    else
                    {
                        Output.PrintInvalid();
                    }
                }
            }
        }
    }
}
