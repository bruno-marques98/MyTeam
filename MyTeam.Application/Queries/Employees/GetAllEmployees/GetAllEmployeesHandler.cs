using AutoMapper;
using MediatR;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Application.Queries.Employees.GetAllEmployees;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.Application.Queries.Employees
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, List<EmployeeDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllEmployeesHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Job)
                .ToListAsync(cancellationToken);

            return _mapper.Map<List<EmployeeDto>>(employees);
        }
    }
}
