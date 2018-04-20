using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsole
{
    struct input
    {
        //set or get
        string commandType;
        //restaurant or review
        string modelType;
        //username or restaurant name
        string nameParam;
        //address or review
        string bodyParam;

        //exclusive for set review
        double rating;
    }
}
