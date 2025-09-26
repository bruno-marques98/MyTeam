using MediatR;

namespace MyTeam.Application.Commands.Jobs.DeleteJob
{
    public class DeleteJobCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
