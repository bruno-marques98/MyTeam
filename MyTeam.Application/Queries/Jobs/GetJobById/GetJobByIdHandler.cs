using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Jobs.GetJobById
{
    public class GetJobByIdHandler : IRequestHandler<GetJobByIdQuery, JobDto?>
    {
        private readonly IApplicationDbContext _context;

        public GetJobByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<JobDto?> Handle(GetJobByIdQuery request, CancellationToken cancellationToken)
        {
            var job = await _context.Jobs
                .FirstOrDefaultAsync(j => j.Id == request.Id, cancellationToken);

            if (job == null)
                return null;

            return new JobDto
            {
                Id = job.Id,
                Title = job.Title,
                MinSalary = job.Salary,
                MaxSalary = job.Salary
            };
        }
    }
}
