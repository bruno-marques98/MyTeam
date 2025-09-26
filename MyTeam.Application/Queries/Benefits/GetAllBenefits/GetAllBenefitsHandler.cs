using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Benefits.GetAllBenefits
{
    public class GetAllBenefitsHandler : IRequestHandler<GetAllBenefitsQuery, List<BenefitDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllBenefitsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BenefitDto>> Handle(GetAllBenefitsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Benefits
                .Select(b => new BenefitDto
                {
                    Id = b.Id,
                    BenefitName = b.Name,
                    Description = b.Description,
                    Value = b.Amount
                })
                .ToListAsync(cancellationToken);
        }
    }
}
