using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.LeaveRequests.GetLeaveRequestById
{
    public class GetLeaveRequestByIdQuery : IRequest<LeaveRequestDto?>
    {
        public Guid Id { get; set; }
    }
}
