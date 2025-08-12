using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces
{
    public interface IPerformanceReviewService
    {
        Task<IEnumerable<PerformanceReviewDto>> GetAllAsync();
        Task<PerformanceReviewDto?> GetByIdAsync(Guid id);
        Task<PerformanceReviewDto> CreateAsync(PerformanceReviewDto review);
        Task<bool> UpdateAsync(PerformanceReviewDto review);
        Task<bool> DeleteAsync(Guid id);
    }
}
