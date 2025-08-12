using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Interfaces.Attendance
{
    public interface IAttendanceService : ICrudService<AttendanceDto, Guid>
    {
        Task<IEnumerable<AttendanceDto>> GetAllAsync();
        Task<AttendanceDto?> GetByIdAsync(Guid id);
        Task<AttendanceDto> CreateAsync(AttendanceDto attendance);
        Task<bool> UpdateAsync(AttendanceDto attendance);
        Task<bool> DeleteAsync(Guid id);
    }
}
