using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Attendance.GetAttendancesById
{
    public record GetAttendanceByIdQuery(Guid Id) : IRequest<AttendanceDto>;
}
