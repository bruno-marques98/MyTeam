using MediatR;

namespace MyTeam.Application.Commands.LeaveRequests.DeleteLeaveRequest
{
    public class DeleteLeaveRequestCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
