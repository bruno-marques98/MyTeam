using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Jobs.GetAllJobs
{
    public class GetAllJobsHandler : IRequestHandler<GetAllJobsQuery, List<JobDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllJobsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<JobDto>> Handle(GetAllJobsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Jobs
                .Select(j => new JobDto
                {
                    Id = j.Id,
                    Title = j.Title,
                    // Adapt DTO: use Salary from entity
                    MinSalary = j.Salary,
                    MaxSalary = j.Salary
                })
                .ToListAsync(cancellationToken);
        }
    }
}
