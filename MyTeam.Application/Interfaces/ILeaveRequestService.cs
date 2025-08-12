using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces
{
    public interface ILeaveRequestService
    {
        Task<IEnumerable<LeaveRequestDto>> GetAllAsync();
        Task<LeaveRequestDto?> GetByIdAsync(Guid id);
        Task<LeaveRequestDto> CreateAsync(LeaveRequestDto leaveRequest);
        Task<bool> ApproveAsync(Guid id);
        Task<bool> RejectAsync(Guid id);
    }
}
