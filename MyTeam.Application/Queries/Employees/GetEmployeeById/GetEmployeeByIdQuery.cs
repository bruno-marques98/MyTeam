using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Employees.GetEmployeeById
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public Guid Id { get; set; }
    }
}
