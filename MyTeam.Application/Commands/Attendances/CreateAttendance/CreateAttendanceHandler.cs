using MediatR;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace MyTeam.Application.Commands.Attendances.CreateAttendance
{
    public class CreateAttendanceHandler : IRequestHandler<CreateAttendanceCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateAttendanceHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateAttendanceCommand request, CancellationToken cancellationToken)
        {
            var attendance = new MyTeam.Domain.Entities.Attendance(
                Guid.NewGuid(),
                request.Date,
                request.Status
            );

            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync(cancellationToken);

            return attendance.Id;
        }
    }
}
