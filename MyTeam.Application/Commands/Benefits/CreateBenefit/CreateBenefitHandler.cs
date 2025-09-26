using MediatR;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Commands.Benefits.CreateBenefit
{
    public class CreateBenefitHandler : IRequestHandler<CreateBenefitCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateBenefitHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateBenefitCommand request, CancellationToken cancellationToken)
        {
            var benefit = new Benefit(request.BenefitName, request.Description, request.Value);

            _context.Benefits.Add(benefit);
            await _context.SaveChangesAsync(cancellationToken);

            return benefit.Id;
        }
    }
}
