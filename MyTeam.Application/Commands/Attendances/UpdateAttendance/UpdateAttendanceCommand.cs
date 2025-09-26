using MediatR;

namespace MyTeam.Application.Commands.Attendance.UpdateAttendance
{
    public record UpdateAttendanceCommand(Guid Id, string Status) : IRequest<bool>;
}
