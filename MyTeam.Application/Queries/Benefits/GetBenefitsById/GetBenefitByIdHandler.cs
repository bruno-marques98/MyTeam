using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Benefits.GetBenefitsById
{
    public class GetBenefitByIdHandler : IRequestHandler<GetBenefitByIdQuery, BenefitDto>
    {
        private readonly IApplicationDbContext _context;

        public GetBenefitByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BenefitDto> Handle(GetBenefitByIdQuery request, CancellationToken cancellationToken)
        {
            var benefit = await _context.Benefits.FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
            if (benefit == null) return null;

            return new BenefitDto
            {
                Id = benefit.Id,
                BenefitName = benefit.Name,
                Description = benefit.Description,
                Value = benefit.Amount
            };
        }
    }
}
