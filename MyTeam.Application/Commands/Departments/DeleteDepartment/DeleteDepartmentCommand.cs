using MediatR;

namespace MyTeam.Application.Commands.Departments.DeleteDepartment
{
    public class DeleteDepartmentCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
