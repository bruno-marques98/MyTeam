using MediatR;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;
using MyTeam.Domain.Enums;

namespace MyTeam.Application.Commands.LeaveRequests.CreateLeaveRequest
{
    public class CreateLeaveRequestHandler : IRequestHandler<CreateLeaveRequestCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateLeaveRequestHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            if (!Enum.TryParse<LeaveType>(request.LeaveType, true, out var leaveType))
                throw new ArgumentException($"Invalid leave type: {request.LeaveType}");

            var leaveRequest = new LeaveRequest(
                request.EmployeeId,
                request.StartDate,
                request.EndDate,
                leaveType,
                request.Reason
            );

            _context.LeaveRequests.Add(leaveRequest);
            await _context.SaveChangesAsync(cancellationToken);

            return leaveRequest.Id;
        }
    }
}
