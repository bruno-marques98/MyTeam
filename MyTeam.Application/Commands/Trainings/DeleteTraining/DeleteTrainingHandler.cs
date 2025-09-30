using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Trainings.DeleteTraining
{
    public class DeleteTrainingHandler : IRequestHandler<DeleteTrainingCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteTrainingHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteTrainingCommand request, CancellationToken cancellationToken)
        {
            var training = await _context.Trainings.FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            if (training == null)
                return false;

            _context.Trainings.Remove(training);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
