using Location.Services.Interfaces;
using Location.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location.Services
{
    public class DistanceCalculator: IDistanceCalculator
    {
        public double DistanceBetweenToPoints(CoordinateModel point1, CoordinateModel point2)
        {
            var lengthOfX = point1.X - point2.X;
            var lengthOfY = point1.Y - point2.Y;

            var distanceSquared = (lengthOfX * lengthOfX) + (lengthOfY * lengthOfY);

            return Math.Sqrt(distanceSquared);
        }

        public List<DistanceFromPointModel> AssignDistanceFromOrigin(
            CoordinateModel origin, 
            List<SuburbLocationModel> suburbs)
        {
            var list = new List<DistanceFromPointModel>();

            foreach (var suburb in suburbs)
            {
                var suburbCoordinates = new CoordinateModel(suburb.longitude, suburb.latitude);
                var distance = DistanceBetweenToPoints(origin, suburbCoordinates);

                list.Add(new DistanceFromPointModel
                {
                    Distance = distance,
                    Origin = origin,
                    SuburbLocation = suburb
                });
            }

            return list;
        }
    }
}
