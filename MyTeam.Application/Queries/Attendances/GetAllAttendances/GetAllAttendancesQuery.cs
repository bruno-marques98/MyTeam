using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Attendance.GetAllAttendances
{
    public record GetAllAttendancesQuery : IRequest<IEnumerable<AttendanceDto>>;
}
