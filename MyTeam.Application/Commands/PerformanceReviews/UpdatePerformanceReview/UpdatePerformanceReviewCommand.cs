using MediatR;

namespace MyTeam.Application.Commands.PerformanceReviews.UpdatePerformanceReview
{
    public class UpdatePerformanceReviewCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Reviewer { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}
