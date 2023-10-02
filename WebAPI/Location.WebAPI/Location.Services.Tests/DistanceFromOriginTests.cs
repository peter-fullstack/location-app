using Location.Services;
using Location.Services.Models;

namespace LocationServices.Tests
{
    [TestClass]
    public class DistanceFromOriginTests
    {
        [TestMethod]
        public void Test1()
        {
            var distanceCalculator = new DistanceCalculator()    ;

            var point1 = new CoordinateModel(-36.7701083, 174.7148012);

            var distances = distanceCalculator.AssignDistanceFromOrigin(point1, TestHelper.CreateListOfSuburbus());

            Assert.IsTrue(distances.Count == 6);
            distances = distances.OrderBy(d => d.Distance).ToList();

            Assert.IsTrue(distances[0].Distance == 0);
            Assert.IsTrue(distances[0].SuburbLocation.suburbName == "Suburb 1");
        }

        [TestMethod]
        public void Test2()
        {
            var distanceCalculator = new DistanceCalculator();

            var point1 = new CoordinateModel(-36.8332161, 174.5660385);

            var distances = distanceCalculator.AssignDistanceFromOrigin(point1, TestHelper.CreateListOfSuburbus());

            Assert.IsTrue(distances.Count == 6);
            distances = distances.OrderBy(d => d.Distance).ToList();

            Assert.IsTrue(distances[0].Distance == 4.4721360072613988E-07);
            Assert.IsTrue(distances[0].SuburbLocation.suburbName == "Suburb 2");
        }
    }
}
