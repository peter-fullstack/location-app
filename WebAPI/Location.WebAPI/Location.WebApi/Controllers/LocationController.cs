using Location.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Location.WebApi.Controllers
{
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationsService _locationsService;

        public LocationController(ILocationsService locationsService) 
        {
            _locationsService = locationsService;
        }

        // POST: api/CompanyDetails
        [HttpPost]
        public async Task<ActionResult> PostLocation()
        {

            return Ok();
        }

    }
}
