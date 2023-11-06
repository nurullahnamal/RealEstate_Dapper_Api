using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticsRepository.ActiveCategoryCount());
        }

        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticsRepository.ActiveEmployeeCount());
        }

        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticsRepository.ApartmentCount());
        }

        [HttpGet("AverageProductByRent")]
        public IActionResult AverageProductByRent()
        {
            return Ok(_statisticsRepository.AverageProductByRent());
        }

        [HttpGet("AverageProductBySale")]
        public IActionResult AverageProductBySale()
        {
            return Ok(_statisticsRepository.AverageProductBySale());
        }

        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticsRepository.AverageRoomCount());
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticsRepository.CategoryCount());
        }
        [HttpGet("CategoryNameByMaxProductCount")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.CategoryNameByMaxProductCount());
        }

    }
}
