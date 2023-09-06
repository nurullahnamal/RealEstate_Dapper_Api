using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.PopulerLocationRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulerLocationController : ControllerBase
    {
        private readonly IPopulerLocationRepository _locationRepository;

        public PopulerLocationController(IPopulerLocationRepository locationRepository)
        {
            _locationRepository=locationRepository;
        }
        [HttpGet]

        public async Task<IActionResult> PopulerLocationList()
        {
            var values = await _locationRepository.GetAllPopulerLocationAsync();
            return Ok(values);
        }
    }
}
