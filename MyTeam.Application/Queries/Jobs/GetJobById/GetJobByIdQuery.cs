using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Jobs.GetJobById
{
    public class GetJobByIdQuery : IRequest<JobDto?>
    {
        public Guid Id { get; set; }
    }
}
