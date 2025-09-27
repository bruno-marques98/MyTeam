using MediatR;

namespace MyTeam.Application.Commands.LeaveRequests.RejectLeaveRequest
{
    public class RejectLeaveRequestCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
