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
        public async void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            string query = "insert into PopulerLocation (CityName,ImageUrl) values (@cityName,@imageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", createPopularLocationDto.CityName);
            parameters.Add("@imageUrl", createPopularLocationDto.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async void DeletePopularLocation(int id)
        {
            string query = "Delete From PopulerLocation Where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@locationID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task<List<ResultPopulerLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From PopulerLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopulerLocationDto>(query);
                return values.ToList();
            }
        }
        public async Task<GetByIDPopularLocationDto> GetPopularLocation(int id)
        {
            string query = "Select * From PopulerLocation Where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@locationID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDto>(query, parameters);
                return values;
            }
        }
        public async void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            string query = "Update PopulerLocation Set CityName=@cityName,ImageUrl=@imageUrl where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", updatePopularLocationDto.CityName);
            parameters.Add("@imageUrl", updatePopularLocationDto.ImageUrl);
            parameters.Add("@locationID", updatePopularLocationDto.LocationID);

            using (var connectiont = _context.CreateConnection())
            {
                await connectiont.ExecuteAsync(query, parameters);
            }
        }
    }
}
