using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.PerformanceReviews.GetPerformanceReviewById
{
    public class GetPerformanceReviewByIdHandler : IRequestHandler<GetPerformanceReviewByIdQuery, PerformanceReviewDto>
    {
        private readonly IApplicationDbContext _context;

        public GetPerformanceReviewByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PerformanceReviewDto> Handle(GetPerformanceReviewByIdQuery request, CancellationToken cancellationToken)
        {
            var review = await _context.PerformanceReviews
                .FirstOrDefaultAsync(r => r.Id == request.Id, cancellationToken);

            if (review == null)
                throw new KeyNotFoundException($"Performance review with ID {request.Id} not found.");

            return new PerformanceReviewDto
            {
                Id = review.Id,
                EmployeeId = review.EmployeeId,
                ReviewDate = review.ReviewDate,
                Reviewer = review.Reviewer,
                Comments = review.Comments,
                Rating = review.Rating
            };
        }
    }
}
