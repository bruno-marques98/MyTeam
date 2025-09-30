using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Trainings.GetAllTrainings
{
    public class GetAllTrainingsHandler : IRequestHandler<GetAllTrainingsQuery, List<TrainingDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllTrainingsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TrainingDto>> Handle(GetAllTrainingsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Trainings
                .Select(t => new TrainingDto
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate
                })
                .ToListAsync(cancellationToken);
        }
    }
}
