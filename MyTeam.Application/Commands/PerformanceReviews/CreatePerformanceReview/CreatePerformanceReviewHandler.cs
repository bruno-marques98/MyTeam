using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Commands.PerformanceReviews.CreatePerformanceReview
{
    public class CreatePerformanceReviewHandler : IRequestHandler<CreatePerformanceReviewCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreatePerformanceReviewHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePerformanceReviewCommand request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == request.EmployeeId, cancellationToken);

            if (employee == null)
                throw new KeyNotFoundException($"Employee with ID {request.EmployeeId} not found.");

            var review = new PerformanceReview(
                employee,
                request.ReviewDate,
                request.Reviewer,
                request.Comments,
                request.Rating
            );

            _context.PerformanceReviews.Add(review);
            await _context.SaveChangesAsync(cancellationToken);

            return review.Id;
        }
    }
}
