using Dapper;
using RealEstate_Dapper_Api.Dtos.PopulerLocationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PopulerLocationRepositories
{
    public class PopulerLocationRepository : IPopulerLocationRepository
    {
        private readonly Context _context;
        public PopulerLocationRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPopulerLocationDto>> GetAllPopulerLocationAsync()
        {
            string query = "Select * From PopulerLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopulerLocationDto>(query);
                return values.ToList();
            }
        }

    }
}
