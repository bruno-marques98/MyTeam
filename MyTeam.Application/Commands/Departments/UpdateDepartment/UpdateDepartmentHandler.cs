using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Departments.UpdateDepartment
{
    public class UpdateDepartmentHandler : IRequestHandler<UpdateDepartmentCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateDepartmentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments
                .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

            if (department == null)
                return false;

            department.Name = request.Name;
            department.Description = request.Description;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
