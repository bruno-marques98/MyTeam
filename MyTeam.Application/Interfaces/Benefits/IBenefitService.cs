using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces.Benefits
{
    public interface IBenefitService
    {
        Task<IEnumerable<BenefitDto>> GetAllAsync();
        Task<BenefitDto?> GetByIdAsync(Guid id);
        Task<BenefitDto> CreateAsync(BenefitDto benefit);
        Task<bool> UpdateAsync(BenefitDto benefit);
        Task<bool> DeleteAsync(Guid id);
    }
}
