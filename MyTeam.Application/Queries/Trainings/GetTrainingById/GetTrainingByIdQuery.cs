using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Trainings.GetTrainingById
{
    public class GetTrainingByIdQuery : IRequest<TrainingDto>
    {
        public Guid Id { get; set; }
    }
}
