using MediatR;

namespace MyTeam.Application.Commands.Attendance.DeleteAttendance
{
    public record DeleteAttendanceCommand(Guid Id) : IRequest<bool>;
}
