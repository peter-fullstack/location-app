namespace Location.Services.Tests
{
    [TestClass]
    public class LocationsServiceTests
    {
        [TestMethod]
        public void LongitutudeIsGreaterThanLargest()
        {
            var data = LocationsData.SuburbLocations;

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count == 30);
        }

        [TestMethod]
        public void LongitutudeIsLessThanSmallest()
        {
            var data = LocationsData.SuburbLocations;

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count == 30);
        }

        [TestMethod]
        public void LongitutudeIsInMiddleOfList()
        {
            var data = LocationsData.SuburbLocations;

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count == 30);
        }
    }
}