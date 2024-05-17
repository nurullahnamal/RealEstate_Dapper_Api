using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.PopulerLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopulerLocationRepositories
{
    public interface IPopulerLocationRepository
    {
        Task<List<ResultPopulerLocationDto>> GetAllPopulerLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);

    }
}
