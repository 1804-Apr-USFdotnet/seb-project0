using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                if (input.Equals("?")) { help(); }
                else if (input.Equals("exit")) { break; }
                else
                {
                    //split arguments into string array
                    //to process in business logic
                    string[] inputParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    ValidateInput.Validate(inputParams);
                }
            }
        }

        private static void help()
        {
            Console.Clear();
            Console.WriteLine("Enter a command.\n");
            Console.WriteLine("Get reviews: \n   reviews [restaurant name]\n");
            Console.WriteLine("Get restaurants: \n   restaurants [optional parameters]\n");
            Console.WriteLine("   [t#]  -- get top # restaurants. E.g: restaurants t3");
            Console.WriteLine("   [partial name] -- get restaurants containing partial name. E.g: restaurants mcd");
            Console.WriteLine("   [order] [order by] [asc|desc] -- get ordered list of restaurants. E.g: restaurants order rating desc");
            Console.WriteLine("   [default]  -- get all restaurants. E.g: restaurants\n");
        }
    }
}
