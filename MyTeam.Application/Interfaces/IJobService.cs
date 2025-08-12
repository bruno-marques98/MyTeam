using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces
{
    public interface IJobService
    {
        Task<IEnumerable<JobDto>> GetAllAsync();
        Task<JobDto?> GetByIdAsync(Guid id);
        Task<JobDto> CreateAsync(JobDto job);
        Task<bool> UpdateAsync(JobDto job);
        Task<bool> DeleteAsync(Guid id);
    }
}
