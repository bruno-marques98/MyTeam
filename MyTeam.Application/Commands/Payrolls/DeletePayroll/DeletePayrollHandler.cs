using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Payrolls.DeletePayroll
{
    public class DeletePayrollHandler : IRequestHandler<DeletePayrollCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public DeletePayrollHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePayrollCommand request, CancellationToken cancellationToken)
        {
            var payroll = await _context.Payrolls
                .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (payroll == null)
                throw new KeyNotFoundException($"Payroll with ID {request.Id} not found.");

            _context.Payrolls.Remove(payroll);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value; // ✅ matches IRequest<Unit>
        }
    }
}
