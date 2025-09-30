using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Trainings.UpdateTraining
{
    public class UpdateTrainingHandler : IRequestHandler<UpdateTrainingCommand, TrainingDto>
    {
        private readonly IApplicationDbContext _context;

        public UpdateTrainingHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TrainingDto> Handle(UpdateTrainingCommand request, CancellationToken cancellationToken)
        {
            var training = await _context.Trainings.FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            if (training == null)
                return null;

            training.GetType().GetProperty("Title")!.SetValue(training, request.Title);
            training.GetType().GetProperty("Description")!.SetValue(training, request.Description);
            training.GetType().GetProperty("StartDate")!.SetValue(training, request.StartDate);
            training.GetType().GetProperty("EndDate")!.SetValue(training, request.EndDate);

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
