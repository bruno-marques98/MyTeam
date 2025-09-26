using MediatR;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.Application.Queries.Attendance.GetAttendancesById
{
    public class GetAttendanceByIdHandler : IRequestHandler<GetAttendanceByIdQuery, AttendanceDto>
    {
        private readonly IApplicationDbContext _context;

        public GetAttendanceByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AttendanceDto> Handle(GetAttendanceByIdQuery request, CancellationToken cancellationToken)
        {
            var attendance = await _context.Attendances
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(a => a.Id == request.Id, cancellationToken);

            if (attendance == null) return null;

            return new AttendanceDto
            {
                Id = attendance.Id,
                EmployeeId = attendance.EmployeeId,
                Date = attendance.Date
            };
        }
    }
}
