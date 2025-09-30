using MediatR;

namespace MyTeam.Application.Commands.Trainings.DeleteTraining
{
    public class DeleteTrainingCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

}
