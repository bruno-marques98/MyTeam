using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces.Training
{
    public interface ITrainingService
    {
        Task<IEnumerable<TrainingDto>> GetAllAsync();
        Task<TrainingDto?> GetByIdAsync(Guid id);
        Task<TrainingDto> CreateAsync(TrainingDto training);
        Task<bool> UpdateAsync(TrainingDto training);
        Task<bool> DeleteAsync(Guid id);
    }
}
