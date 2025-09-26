using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Departments.GetDepartmentById
{
    public class GetDepartmentByIdQuery : IRequest<DepartmentDto?>
    {
        public Guid Id { get; set; }
    }
}
