using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    
                    // get Json string response from business logic
                    string response = ValidateInput.Validate(inputParams);

                    if (response != null)
                    {
                        switch (inputParams[0])
                        {
                            // deserialize and print list of restaurants
                            case "restaurants":
                                var outputRes = JsonConvert.DeserializeObject<List<Dictionary<string,string>>>(response);
                                Output.PrintRestaurants(outputRes);
                                break;
                            // deserialize and print list of reviews
                            case "reviews":
                                var outputRev = new List<ReviewInfo>(JsonConvert.DeserializeObject<List<ReviewInfo>>(response));
                                Output.PrintReviews(outputRev);
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
