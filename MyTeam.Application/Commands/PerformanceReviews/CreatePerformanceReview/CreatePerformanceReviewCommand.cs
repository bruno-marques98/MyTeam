using MediatR;

namespace MyTeam.Application.Commands.PerformanceReviews.CreatePerformanceReview
{
    public class CreatePerformanceReviewCommand : IRequest<Guid>
    {
        public Guid EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Reviewer { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}
