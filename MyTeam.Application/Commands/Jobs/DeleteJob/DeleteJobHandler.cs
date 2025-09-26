using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;
namespace MyTeam.Application.Commands.Jobs.DeleteJob
{
    public class DeleteJobHandler : IRequestHandler<DeleteJobCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteJobHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteJobCommand request, CancellationToken cancellationToken)
        {
            var job = await _context.Jobs
                .FirstOrDefaultAsync(j => j.Id == request.Id, cancellationToken);

            if (job == null)
                return false;

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
