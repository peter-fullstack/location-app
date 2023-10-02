namespace Location.Services.Tests
{
    [TestClass]
    public class LocationsDataTests
    {
        [TestMethod]
        public void JsonDataDeserilaztion()
        {
            LocationsData.FilePath = @"..\..\..\Data\SuburbsData.json";
            var data = LocationsData.SuburbLocations;

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count == 30);
        }
    }
}