using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam.Application.Commands.Jobs.UpdateJob
{
    public class UpdateJobHandler : IRequestHandler<UpdateJobCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateJobHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            var job = await _context.Jobs
                .FirstOrDefaultAsync(j => j.Id == request.Id, cancellationToken);

            if (job == null)
                return false;

            job.UpdateJob(
                request.Title,
                request.Description,
                request.Salary,
                request.EmploymentType
            );

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }

}
