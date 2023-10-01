using Location.Services.Models;
using System.Text.Json;

namespace Location.Services
{
    public class LocationsData
    {
        public static string FilePath = string.Empty;

        private static List<SuburbLocationModel> _locations;
        public static List<SuburbLocationModel> GetSuburbs()
        {
            var jsonData = GetJsonData();
            var suburbs = JsonSerializer.Deserialize<List<SuburbLocationModel>>(jsonData);

            if (suburbs != null)
            {
                return suburbs;
            }

            throw new Exception("No Suburbs Location data in file.");
        }

        public static string GetJsonData()
        {
            if (File.Exists(FilePath))
            {
                using (var reader = new StreamReader(FilePath))
                {
                    return reader.ReadToEnd();
                }
            }

            throw new Exception("Suburbs Location JSON file not found.");
        }

        public static List<SuburbLocationModel> SuburbLocations
        {
            get
            {
                if (_locations == null)
                {
                    _locations = GetSuburbs();
                }

                return _locations;
            }
        }
    }
}
