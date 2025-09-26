using MediatR;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.Application.Queries.Attendance.GetAllAttendances
{
    public class GetAllAttendancesHandler : IRequestHandler<GetAllAttendancesQuery, IEnumerable<AttendanceDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllAttendancesHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AttendanceDto>> Handle(GetAllAttendancesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Attendances
                .Include(a => a.Employee) // load Employee info if needed
                .Select(a => new AttendanceDto
                {
                    Id = a.Id,
                    EmployeeId = a.EmployeeId,
                    Date = a.Date
                })
                .ToListAsync(cancellationToken);
        }
    }
}
