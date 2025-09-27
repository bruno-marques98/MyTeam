using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.LeaveRequests.GetAllLeaveRequests
{
    public class GetAllLeaveRequestsQuery : IRequest<List<LeaveRequestDto>>
    {
    }
}
