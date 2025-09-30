using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Commands.Trainings.CreateTraining
{
    public class CreateTrainingCommand : IRequest<TrainingDto>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
