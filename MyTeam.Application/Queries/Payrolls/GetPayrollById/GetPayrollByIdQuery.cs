using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Payrolls.GetPayrollById
{
    public class GetPayrollByIdQuery : IRequest<PayrollDto>
    {
        public Guid Id { get; set; }
    }
}
