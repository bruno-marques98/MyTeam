using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.LeaveRequests.RejectLeaveRequest
{
    public class RejectLeaveRequestHandler : IRequestHandler<RejectLeaveRequestCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public RejectLeaveRequestHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(RejectLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _context.LeaveRequests
                .FirstOrDefaultAsync(l => l.Id == request.Id, cancellationToken);

            if (leaveRequest == null)
                return false;

            leaveRequest.Reject();
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
