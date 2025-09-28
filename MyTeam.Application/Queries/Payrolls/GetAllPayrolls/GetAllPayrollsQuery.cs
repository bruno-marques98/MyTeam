using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Queries.Payrolls.GetAllPayrolls
{
    public class GetAllPayrollsQuery : IRequest<IEnumerable<PayrollDto>> { }
}
