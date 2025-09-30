using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Trainings.GetTrainingById
{
    public class GetTrainingByIdHandler : IRequestHandler<GetTrainingByIdQuery, TrainingDto>
    {
        private readonly IApplicationDbContext _context;

        public GetTrainingByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TrainingDto> Handle(GetTrainingByIdQuery request, CancellationToken cancellationToken)
        {
            var training = await _context.Trainings.FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            if (training == null)
                return null;

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
