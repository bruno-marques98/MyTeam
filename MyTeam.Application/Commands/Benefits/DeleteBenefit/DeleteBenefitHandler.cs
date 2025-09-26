using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Benefits.DeleteBenefit
{
    public class DeleteBenefitHandler : IRequestHandler<DeleteBenefitCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteBenefitHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteBenefitCommand request, CancellationToken cancellationToken)
        {
            var benefit = await _context.Benefits.FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
            if (benefit == null) return false;

            _context.Benefits.Remove(benefit);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
