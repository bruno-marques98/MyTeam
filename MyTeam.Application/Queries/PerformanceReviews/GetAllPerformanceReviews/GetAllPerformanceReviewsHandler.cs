using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.PerformanceReviews.GetAllPerformanceReviews
{
    public class GetAllPerformanceReviewsHandler : IRequestHandler<GetAllPerformanceReviewsQuery, IEnumerable<PerformanceReviewDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllPerformanceReviewsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PerformanceReviewDto>> Handle(GetAllPerformanceReviewsQuery request, CancellationToken cancellationToken)
        {
            return await _context.PerformanceReviews
                .Select(r => new PerformanceReviewDto
                {
                    Id = r.Id,
                    EmployeeId = r.EmployeeId,
                    ReviewDate = r.ReviewDate,
                    Reviewer = r.Reviewer,
                    Comments = r.Comments,
                    Rating = r.Rating
                })
                .ToListAsync(cancellationToken);
        }
    }
}
