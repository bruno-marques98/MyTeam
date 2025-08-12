using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Interfaces.Employees
{
    public interface IEmployeeService : ICrudService<EmployeeDto, Guid>
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto?> GetByIdAsync(Guid id);
        Task<EmployeeDto> CreateAsync(EmployeeDto employee);
        Task<bool> UpdateAsync(EmployeeDto employee);
        Task<bool> DeleteAsync(Guid id);
    }
}
