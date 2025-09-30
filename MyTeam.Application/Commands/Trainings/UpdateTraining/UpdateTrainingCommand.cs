using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Commands.Trainings.UpdateTraining
{
    public class UpdateTrainingCommand : IRequest<TrainingDto>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
