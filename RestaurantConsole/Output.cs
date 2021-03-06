﻿using System;
using System.Collections.Generic;

namespace RestaurantConsole
{
    internal static class Output
    {
        internal static void PrintHelp()
        {
            Console.Clear();
            Console.WriteLine("Enter a command.\n");
            Console.WriteLine("Get reviews: \n   reviews [restaurant name]\n");
            Console.WriteLine("Get restaurants: \n   restaurants [optional parameters]\n");
            Console.WriteLine("   top [#]  -- get top # restaurants. E.g: restaurants t3");
            Console.WriteLine("   contains [partial name] -- get restaurants containing partial name. E.g: restaurants mcd");
            Console.WriteLine("   sortby [order by] [asc|desc] -- get ordered list of restaurants. E.g: restaurants order rating desc");
            Console.WriteLine("   [default]  -- get all restaurants. E.g: restaurants\n");
        }

        internal static void PrintInvalid()
        {
            Console.WriteLine("No entries found or invalid input. Type '?' for help.");
        }

        internal static void PrintRestaurants(List<Dictionary<string, string>> r)
        {
            Console.Clear();
            foreach (Dictionary<string,string> info in r)
            {
                Console.WriteLine("Name: {0}\nAddress: {1}\nRating: {2}\n", info["Name"], info["Address"], info["Rating"]);
            }
        }

        internal static void PrintReviews(List<Dictionary<string, string>> r)
        {
            Console.Clear();
            foreach (Dictionary<string, string> info in r)
            {
                Console.WriteLine("Author: {0}\nReview: {1}\nRating: {2}\n", info["Name"], info["Summary"], info["Rating"]);
            }
        }
    }
}
