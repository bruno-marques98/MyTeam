using MediatR;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Employees.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateEmployeeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Employees.FindAsync(new object[] { request.Id }, cancellationToken);
            if (entity == null) return false;

            entity.FullName = request.FullName;
            entity.Email = request.Email;
            entity.DepartmentId = request.DepartmentId;
            entity.JobId = request.JobId;
            entity.HireDate = request.HireDate;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
