using MediatR;
using MyTeam.Application.DTOs;
namespace MyTeam.Application.Queries.PerformanceReviews.GetAllPerformanceReviews
{
    public class GetAllPerformanceReviewsQuery : IRequest<IEnumerable<PerformanceReviewDto>> { }
}
