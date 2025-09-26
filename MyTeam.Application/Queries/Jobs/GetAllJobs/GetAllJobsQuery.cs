using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Jobs.GetAllJobs
{
    public class GetAllJobsQuery : IRequest<List<JobDto>>
    {
    }
}
