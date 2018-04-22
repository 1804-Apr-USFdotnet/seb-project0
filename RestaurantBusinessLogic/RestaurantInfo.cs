using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantDataLogic;

namespace RestaurantBusinessLogic
{
    class RestaurantsOutput
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        public static explicit operator RestaurantsOutput(Restaurant r)
        {
            RestaurantsOutput rout = new RestaurantsOutput();
            rout.Name = r.RName;
            rout.Address = r.RAddress;
            rout.Rating = (double)r.Rating;
            return rout;
        }
    }
}
