using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Departments.GetAllDepartments
{
    public class GetAllDepartmentsQuery : IRequest<List<DepartmentDto>>
    {
    }
}
