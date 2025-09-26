using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Departments.GetDepartmentById
{
    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByIdQuery, DepartmentDto?>
    {
        private readonly IApplicationDbContext _context;

        public GetDepartmentByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DepartmentDto?> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments
                .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

            if (department == null)
                return null;

            return new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name,
                Description = department.Description
            };
        }
    }
}
