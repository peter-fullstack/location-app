using Location.Services;
using Location.Services.Interfaces;
using Location.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace Location.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ILocationsService _locationsService;

        public LocationsController(ILocationsService locationsService) 
        {
            LocationsData.FilePath = Constants.DataFilePath;
            _locationsService = locationsService;
        }

        [HttpGet]
        public ActionResult<List<SuburbLocationModel>> GetLocation()
        {
            return Ok(LocationsData.SuburbLocations);
        }

        [HttpGet]
        [Route("nearest")]
        public ActionResult<List<SuburbLocationModel>> GetNearestSuburb(double longitude, double latitude)
        {
            var coordinate = new CoordinateModel(longitude, latitude);

            var nearestSuburb = _locationsService.GetNearestSuburb(coordinate, LocationsData.SuburbLocations);

            return Ok(nearestSuburb);
        }

    }
}
