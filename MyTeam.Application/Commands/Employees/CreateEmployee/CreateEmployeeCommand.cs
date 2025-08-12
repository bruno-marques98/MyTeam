using MediatR;
using MyTeam.Domain.ValueObjects;

namespace MyTeam.Application.Commands.Employees.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<Guid>
    {
        public string FullName { get; set; }
        public Email Email { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid JobId { get; set; }
        public DateTime HireDate { get; set; }
    }
}
