using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Benefits.GetBenefitsById
{
    public class GetBenefitByIdQuery : IRequest<BenefitDto>
    {
        public Guid Id { get; set; }
    }
}
