using MediatR;

namespace MyTeam.Application.Commands.Benefits.UpdateBenefit
{
    public class UpdateBenefitCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string BenefitName { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
