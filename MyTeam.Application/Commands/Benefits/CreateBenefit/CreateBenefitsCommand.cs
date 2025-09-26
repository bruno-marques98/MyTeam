using MediatR;

namespace MyTeam.Application.Commands.Benefits.CreateBenefit
{
    public class CreateBenefitCommand : IRequest<Guid>
    {
        public string BenefitName { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
