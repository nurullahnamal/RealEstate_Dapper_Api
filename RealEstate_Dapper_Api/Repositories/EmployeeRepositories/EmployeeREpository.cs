using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByCategoryDto> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(UpdateEmployeeDto updateEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
