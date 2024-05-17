using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.PopulerLocationDtos;
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

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            _locationRepository.CreatePopularLocation(createPopularLocationDto);
            return Ok("Lokasyon Kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _locationRepository.DeletePopularLocation(id);
            return Ok("Lokasyon Kısmı Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            _locationRepository.UpdatePopularLocation(updatePopularLocationDto);
            return Ok("Lokasyon Kısmı Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var value = await _locationRepository.GetPopularLocation(id);
            return Ok(value);
        }
    }
}
