using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.PerformanceReviews.GetPerformanceReviewById
{
    public class GetPerformanceReviewByIdQuery : IRequest<PerformanceReviewDto>
    {
        public Guid Id { get; set; }
    }
}
