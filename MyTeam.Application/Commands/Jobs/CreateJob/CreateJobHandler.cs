using MediatR;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Commands.Jobs.CreateJob
{
    public class CreateJobHandler : IRequestHandler<CreateJobCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateJobHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateJobCommand request, CancellationToken cancellationToken)
        {
            var job = new Job(
                request.Title,
                request.Description,
                request.Salary,
                request.EmploymentType,
                request.DepartmentId
            );

            _context.Jobs.Add(job);
            await _context.SaveChangesAsync(cancellationToken);

            return job.Id;
        }
    }
}
