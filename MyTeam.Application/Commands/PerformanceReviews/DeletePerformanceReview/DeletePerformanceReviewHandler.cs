using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.PerformanceReviews.DeletePerformanceReview
{
    public class DeletePerformanceReviewHandler : IRequestHandler<DeletePerformanceReviewCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public DeletePerformanceReviewHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePerformanceReviewCommand request, CancellationToken cancellationToken)
        {
            var review = await _context.PerformanceReviews
                .FirstOrDefaultAsync(r => r.Id == request.Id, cancellationToken);

            if (review == null)
                throw new KeyNotFoundException($"Performance review with ID {request.Id} not found.");

            _context.PerformanceReviews.Remove(review);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
