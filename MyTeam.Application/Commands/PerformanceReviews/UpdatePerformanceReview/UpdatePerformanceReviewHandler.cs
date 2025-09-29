using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.PerformanceReviews.UpdatePerformanceReview
{
    public class UpdatePerformanceReviewHandler : IRequestHandler<UpdatePerformanceReviewCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePerformanceReviewHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdatePerformanceReviewCommand request, CancellationToken cancellationToken)
        {
            var review = await _context.PerformanceReviews
                .FirstOrDefaultAsync(r => r.Id == request.Id, cancellationToken);

            if (review == null)
                throw new KeyNotFoundException($"Performance review with ID {request.Id} not found.");

            // Direct property updates (if setters allowed) 
            // OR add an Update() method in entity
            review.GetType().GetProperty("ReviewDate")?.SetValue(review, request.ReviewDate);
            review.GetType().GetProperty("Reviewer")?.SetValue(review, request.Reviewer);
            review.GetType().GetProperty("Comments")?.SetValue(review, request.Comments);
            review.GetType().GetProperty("Rating")?.SetValue(review, request.Rating);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
