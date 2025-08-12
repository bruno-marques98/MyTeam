using MediatR;
using MyTeam.Domain.ValueObjects;

namespace MyTeam.Application.Commands.Employees.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public Email Email { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid JobId { get; set; }
        public DateTime HireDate { get; set; }
    }
}
