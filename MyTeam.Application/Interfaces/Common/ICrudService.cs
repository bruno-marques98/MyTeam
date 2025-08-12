namespace MyTeam.Application.Interfaces.Common
{
    public interface ICrudService<TDto,TKey>
        where TDto : class
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto?> GetByIdAsync(TKey id);
        Task<TDto> CreateAsync(TDto dto);
        Task<bool> UpdateAsync(TKey id,TDto dto);
        Task<bool> DeleteAsync(TKey id);
    }
}
