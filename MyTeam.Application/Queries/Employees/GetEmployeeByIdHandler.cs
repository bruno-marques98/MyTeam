using AutoMapper;
using MediatR;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.Application.Queries.Employees
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeeByIdHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Job)
                .FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

            return _mapper.Map<EmployeeDto>(employee);
        }
    }
}
