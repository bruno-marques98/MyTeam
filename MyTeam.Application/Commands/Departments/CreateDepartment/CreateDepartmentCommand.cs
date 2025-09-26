using MediatR;

namespace MyTeam.Application.Commands.Departments.CreateDepartment
{
    public class CreateDepartmentCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
