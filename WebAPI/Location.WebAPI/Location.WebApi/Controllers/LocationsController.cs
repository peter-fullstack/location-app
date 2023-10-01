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
            _locationsService = locationsService;
        }

        // POST: api/CompanyDetails
        [HttpGet]
        public ActionResult<List<SuburbLocationModel>> GetLocation()
        {
            LocationsData.FilePath = @".\Data\SuburbsData.json";
            return Ok(LocationsData.SuburbLocations);
        }

    }
}
