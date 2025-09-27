using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.LeaveRequests.ApproveLeaveRequest
{
    public class ApproveLeaveRequestHandler : IRequestHandler<ApproveLeaveRequestCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public ApproveLeaveRequestHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(ApproveLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _context.LeaveRequests
                .FirstOrDefaultAsync(l => l.Id == request.Id, cancellationToken);

            if (leaveRequest == null)
                return false;

            leaveRequest.Approve();
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
