using MediatR;

namespace MyTeam.Application.Commands.LeaveRequests.CreateLeaveRequest
{
    public class CreateLeaveRequestCommand : IRequest<Guid>
    {
        public Guid EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string LeaveType { get; set; } // from client (string), will map to enum
    }
}
