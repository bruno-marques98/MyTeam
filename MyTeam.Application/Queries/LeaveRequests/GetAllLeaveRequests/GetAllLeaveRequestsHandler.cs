using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.LeaveRequests.GetAllLeaveRequests
{
    public class GetAllLeaveRequestsHandler : IRequestHandler<GetAllLeaveRequestsQuery, List<LeaveRequestDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllLeaveRequestsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LeaveRequestDto>> Handle(GetAllLeaveRequestsQuery request, CancellationToken cancellationToken)
        {
            return await _context.LeaveRequests
                .Select(l => new LeaveRequestDto
                {
                    Id = l.Id,
                    EmployeeId = l.EmployeeId,
                    StartDate = l.StartDate,
                    EndDate = l.EndDate,
                    Reason = l.Reason,
                    Status = l.Status.ToString()
                })
                .ToListAsync(cancellationToken);
        }
    }
}
