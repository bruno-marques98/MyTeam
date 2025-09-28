using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Payrolls.GetAllPayrolls
{
    public class GetAllPayrollsHandler : IRequestHandler<GetAllPayrollsQuery, IEnumerable<PayrollDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllPayrollsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PayrollDto>> Handle(GetAllPayrollsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Payrolls
                .Select(payroll => new PayrollDto
                {
                    Id = payroll.Id,
                    EmployeeId = payroll.EmployeeId,
                    GrossPay = payroll.GrossPay,
                    Deductions = payroll.Deductions,
                    NetPay = payroll.NetPay,
                    PayPeriodStart = payroll.PayPeriodStart,
                    PayPeriodEnd = payroll.PayPeriodEnd
                })
                .ToListAsync(cancellationToken);
        }
    }
}
