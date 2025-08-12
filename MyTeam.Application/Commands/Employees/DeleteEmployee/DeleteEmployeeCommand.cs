using MediatR;

namespace MyTeam.Application.Commands.Employees.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
