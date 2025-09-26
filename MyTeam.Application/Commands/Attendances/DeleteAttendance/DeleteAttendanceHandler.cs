using MediatR;
using MyTeam.Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.Application.Commands.Attendance.DeleteAttendance
{
    public class DeleteAttendanceHandler : IRequestHandler<DeleteAttendanceCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAttendanceHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteAttendanceCommand request, CancellationToken cancellationToken)
        {
            var attendance = await _context.Attendances.FirstOrDefaultAsync(a => a.Id == request.Id, cancellationToken);

            if (attendance == null)
                return false;

            _context.Attendances.Remove(attendance);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
