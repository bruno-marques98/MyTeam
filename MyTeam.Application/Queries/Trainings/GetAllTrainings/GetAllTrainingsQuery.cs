using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Trainings.GetAllTrainings
{
    public class GetAllTrainingsQuery : IRequest<List<TrainingDto>> { }
}
