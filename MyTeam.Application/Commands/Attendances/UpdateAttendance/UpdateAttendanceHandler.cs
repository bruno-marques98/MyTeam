using MediatR;
using MyTeam.Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.Application.Commands.Attendance.UpdateAttendance
{
    public class UpdateAttendanceHandler : IRequestHandler<UpdateAttendanceCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAttendanceHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateAttendanceCommand request, CancellationToken cancellationToken)
        {
            var attendance = await _context.Attendances.FirstOrDefaultAsync(a => a.Id == request.Id, cancellationToken);

            if (attendance == null)
                return false;

            attendance.Status = request.Status;

            _context.Attendances.Update(attendance);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
