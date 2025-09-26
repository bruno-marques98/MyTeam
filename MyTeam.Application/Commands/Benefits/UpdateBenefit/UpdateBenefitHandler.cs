using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Benefits.UpdateBenefit
{
    public class UpdateBenefitHandler : IRequestHandler<UpdateBenefitCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateBenefitHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateBenefitCommand request, CancellationToken cancellationToken)
        {
            var benefit = await _context.Benefits.FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
            if (benefit == null) return false;

            // EF Core tracks the entity — we can update properties directly
            typeof(MyTeam.Domain.Entities.Benefit)
                .GetProperty("Name")?.SetValue(benefit, request.BenefitName);
            typeof(MyTeam.Domain.Entities.Benefit)
                .GetProperty("Description")?.SetValue(benefit, request.Description);
            typeof(MyTeam.Domain.Entities.Benefit)
                .GetProperty("Amount")?.SetValue(benefit, request.Value);

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
