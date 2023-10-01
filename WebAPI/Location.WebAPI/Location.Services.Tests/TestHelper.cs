using Location.Services.Models;

namespace LocationServices.Tests
{
    public class TestHelper
    {
        public static List<SuburbLocationModel> CreateListOfSuburbus()
        {
            var list = new List<SuburbLocationModel>();

            list.Add(
                new SuburbLocationModel
                {
                    longitude = -36.7701083,
                    latitude = 174.7148012,
                    suburbName = "Suburb 1"
                });

            list.Add(
                new SuburbLocationModel
                {
                    longitude = -36.8332165,
                    latitude = 174.5660387,
                    suburbName = "Suburb 2"
                });


            list.Add(
                new SuburbLocationModel
                {
                    longitude = -36.8746629,
                    latitude = 174.6649163,
                    suburbName = "Suburb 3"
                });


            list.Add(
                new SuburbLocationModel
                {
                    longitude = -36.9928233,
                    latitude = 174.7250972,
                    suburbName = "Suburb 4"
                });

            list.Add(
               new SuburbLocationModel
               {
                   longitude = -36.9956723,
                   latitude = 174.7260381,
                   suburbName = "Suburb 5"
               });

            list.Add(
                new SuburbLocationModel
                {
                    longitude = -37.0201001,
                    latitude = 174.7484948,
                    suburbName = "Suburb 6"
                });

            return list;
        }
    }
}
