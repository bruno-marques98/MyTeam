using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Employees.GetAllEmployees
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeDto>>
    {
    }
}
