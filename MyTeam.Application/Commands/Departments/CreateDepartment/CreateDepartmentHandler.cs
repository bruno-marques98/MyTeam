using MediatR;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Commands.Departments.CreateDepartment
{
    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateDepartmentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description
            };

            _context.Departments.Add(department);
            await _context.SaveChangesAsync(cancellationToken);

            return department.Id;
        }
    }
}
