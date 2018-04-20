using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBusinessLogic
{
    struct input
    {
        //set or get
        internal string commandType;
        //restaurant or review
        internal string modelType;
        //username or restaurant name
        internal string nameParam;
        //address or review
        internal string bodyParam;

        //exclusive for set review
        internal double rating;
    }
}
