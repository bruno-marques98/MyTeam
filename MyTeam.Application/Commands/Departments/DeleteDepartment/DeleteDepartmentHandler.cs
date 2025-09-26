using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Departments.DeleteDepartment
{
    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteDepartmentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments
                .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

            if (department == null)
                return false;

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
