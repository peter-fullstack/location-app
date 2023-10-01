using Location.Services.Interfaces;
using Location.Services.Models;

namespace Location.Services
{
    public class LocationsService: ILocationsService
    {
        private IDistanceCalculator _distanceCalculator;

        public LocationsService(IDistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator;
        }

        public SuburbLocationModel GetNearestSuburb(CoordinateModel origin, List<SuburbLocationModel> suburbLocations)
        {
            var model = new SuburbLocationModel();

            var locationDistances = _distanceCalculator.AssignDistanceFromOrigin(origin, suburbLocations);

            var closestLocation = locationDistances.OrderBy(l => l.Distance).First();

            return closestLocation.SuburbLocation;
        }
    }
}
