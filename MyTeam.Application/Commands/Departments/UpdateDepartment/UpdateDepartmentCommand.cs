using MediatR;

namespace MyTeam.Application.Commands.Departments.UpdateDepartment
{
    public class UpdateDepartmentCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
