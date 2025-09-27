using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.LeaveRequests.DeleteLeaveRequest
{
    public class DeleteLeaveRequestHandler : IRequestHandler<DeleteLeaveRequestCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteLeaveRequestHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _context.LeaveRequests
                .FirstOrDefaultAsync(l => l.Id == request.Id, cancellationToken);

            if (leaveRequest == null)
                return false;

            _context.LeaveRequests.Remove(leaveRequest);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
