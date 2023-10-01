using Location.Services.Models;

namespace Location.Services.Interfaces
{
    public interface ILocationsService
    {
        SuburbLocationModel GetNearestSuburb(CoordinateModel origin, List<SuburbLocationModel> suburbLocations);
    }
}
