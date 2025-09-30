using MediatR;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Commands.Trainings.CreateTraining
{
    public class CreateTrainingHandler : IRequestHandler<CreateTrainingCommand, TrainingDto>
    {
        private readonly IApplicationDbContext _context;

        public CreateTrainingHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TrainingDto> Handle(CreateTrainingCommand request, CancellationToken cancellationToken)
        {
            var training = new Training(
                request.Title,
                request.Description,
                request.StartDate,
                request.EndDate
            );

            _context.Trainings.Add(training);
            await _context.SaveChangesAsync(cancellationToken);

            return new TrainingDto
            {
                Id = training.Id,
                Title = training.Title,
                Description = training.Description,
                StartDate = training.StartDate,
                EndDate = training.EndDate
            };
        }
    }
}
