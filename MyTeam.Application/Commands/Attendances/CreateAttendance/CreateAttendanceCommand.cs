using MediatR;

namespace MyTeam.Application.Commands.Attendances.CreateAttendance
{
    public record CreateAttendanceCommand(int EmployeeId, DateTime Date, string Status) : IRequest<Guid>;
}
