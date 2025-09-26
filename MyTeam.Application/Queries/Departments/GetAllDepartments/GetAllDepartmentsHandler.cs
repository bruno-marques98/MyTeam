using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
namespace MyTeam.Application.Queries.Departments.GetAllDepartments
{
    public class GetAllDepartmentsHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllDepartmentsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Departments
                .Select(d => new DepartmentDto
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description
                })
                .ToListAsync(cancellationToken);
        }
    }
}
