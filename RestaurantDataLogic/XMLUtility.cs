using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestaurantDataLogic
{
    class XMLUtility : IUtility
    {
        public int GetRestaurantId(string restaurantName)
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Dictionary<string, int>));
                reader = new StreamReader("C:\\xmldata\\ids.txt");
                Dictionary<string, int> Ids = new Dictionary<string, int>((Dictionary<string, int>)serializer.Deserialize(reader));
                return Ids[restaurantName];
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <summary>
        /// Get all restaurants to process in business logic
        /// </summary>
        /// <returns>List of all Restaurants</returns>
        public List<Restaurant> GetRestaurantModels()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(List<Restaurant>));
                reader = new StreamReader("C:\\xmldata\\restaurants.txt");
                return (List<Restaurant>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <summary>
        /// Get reviews from a restaurant
        /// </summary>
        /// <returns>List of reviews</returns>
        public List<Review> GetReviewModels(int restaurantId)
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(List<Review>));
                reader = new StreamReader("C:\\xmldata\\reviews.txt");
                return (List<Review>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        //public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        //{
        //    TextWriter writer = null;
        //    try
        //    {
        //        var serializer = new XmlSerializer(typeof(T));
        //        writer = new StreamWriter(filePath, append);
        //        serializer.Serialize(writer, objectToWrite);
        //    }
        //    finally
        //    {
        //        if (writer != null)
        //            writer.Close();
        //    }
        //}
    }
}
