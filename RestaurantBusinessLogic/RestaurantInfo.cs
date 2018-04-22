using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantDataLogic;

namespace RestaurantBusinessLogic
{
    public struct RestaurantInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        // Convert from Restaurant entity model to RestaurantInfo
        public static explicit operator RestaurantInfo(Restaurant r)
        {
            RestaurantInfo rout = new RestaurantInfo();
            rout.Name = r.RName;
            rout.Address = r.RAddress;
            rout.Rating = (double)r.Rating;
            return rout;
        }
    }
}
