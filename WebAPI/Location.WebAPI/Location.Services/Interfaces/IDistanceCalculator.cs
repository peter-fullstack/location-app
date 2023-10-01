using Location.Services.Models;

namespace Location.Services.Interfaces
{
    public interface IDistanceCalculator
    {
        List<DistanceFromPointModel> AssignDistanceFromOrigin(
            CoordinateModel origin,
            List<SuburbLocationModel> suburbs);
    }
}
