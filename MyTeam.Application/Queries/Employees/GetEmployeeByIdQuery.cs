using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Employees
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public Guid Id { get; set; }
    }
}
