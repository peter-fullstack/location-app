using Location.Services.Models;

namespace Location.Services.Tests
{
    [TestClass]
    public class DistanceCalulatorTests
    {
        [TestMethod]
        public void Test1()
        {
            var distanceCalculator = new DistanceCalculator();

            var point1 = new CoordinateModel(0, 0);
            var point2 = new CoordinateModel(3, 4);

            var distance = distanceCalculator.DistanceBetweenToPoints(point1, point2);

            Assert.IsTrue(distance == 5);
        }

        [TestMethod]
        public void Test2()
        {
            var distanceCalculator = new DistanceCalculator();

            var point1 = new CoordinateModel(-1, -2);
            var point2 = new CoordinateModel(2, 2);

            var distance = distanceCalculator.DistanceBetweenToPoints(point1, point2);

            Assert.IsTrue(distance == 5);
        }

        [TestMethod]
        public void Test3()
        {
            var distanceCalculator = new DistanceCalculator();

            var point1 = new CoordinateModel(-1, -2);
            var point2 = new CoordinateModel(-4, -6);

            var distance = distanceCalculator.DistanceBetweenToPoints(point1, point2);

            Assert.IsTrue(distance == 5);
        }

        [TestMethod]
        public void Test4()
        {
            var distanceCalculator = new DistanceCalculator();

            var point1 = new CoordinateModel(0, 0);
            var point2 = new CoordinateModel(0.3, 0.4);

            var distance = distanceCalculator.DistanceBetweenToPoints(point1, point2);

            Assert.IsTrue(distance == 0.5);
        }
    }
}