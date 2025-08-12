using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllAsync();
        Task<DepartmentDto?> GetByIdAsync(Guid id);
        Task<DepartmentDto> CreateAsync(DepartmentDto department);
        Task<bool> UpdateAsync(DepartmentDto department);
        Task<bool> DeleteAsync(Guid id);
    }
}
