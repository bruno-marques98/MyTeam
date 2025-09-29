using MediatR;

namespace MyTeam.Application.Commands.PerformanceReviews.DeletePerformanceReview
{
    public class DeletePerformanceReviewCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
