using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantDataLogic;

namespace RestaurantBusinessLogic
{
    class ReviewsOutput
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public double Rating { get; set; }

        public static explicit operator ReviewsOutput(Review r)
        {
            ReviewsOutput rout = new ReviewsOutput();
            rout.Name = r.Username;
            rout.Summary = r.Summary;
            rout.Rating = (double)r.Rating;
            return rout;
        }
    }
}
