using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Benefits.GetAllBenefits
{
    public class GetAllBenefitsQuery : IRequest<List<BenefitDto>> { }
}
