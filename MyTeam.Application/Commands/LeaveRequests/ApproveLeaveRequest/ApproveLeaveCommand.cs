using MediatR;
namespace MyTeam.Application.Commands.LeaveRequests.ApproveLeaveRequest
{
    public class ApproveLeaveRequestCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
