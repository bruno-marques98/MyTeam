using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
namespace MyTeam.Application.Queries.LeaveRequests.GetLeaveRequestById
{
    public class GetLeaveRequestByIdHandler : IRequestHandler<GetLeaveRequestByIdQuery, LeaveRequestDto?>
    {
        private readonly IApplicationDbContext _context;

        public GetLeaveRequestByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<LeaveRequestDto?> Handle(GetLeaveRequestByIdQuery request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _context.LeaveRequests
                .FirstOrDefaultAsync(l => l.Id == request.Id, cancellationToken);

            if (leaveRequest == null)
                return null;

            return new LeaveRequestDto
            {
                Id = leaveRequest.Id,
                EmployeeId = leaveRequest.EmployeeId,
                StartDate = leaveRequest.StartDate,
                EndDate = leaveRequest.EndDate,
                Reason = leaveRequest.Reason,
                Status = leaveRequest.Status.ToString()
            };
        }
    }
}
