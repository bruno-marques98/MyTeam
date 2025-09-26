using MediatR;

namespace MyTeam.Application.Commands.Benefits.DeleteBenefit
{
    public class DeleteBenefitCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
