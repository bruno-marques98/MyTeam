using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Queries.Payrolls.GetPayrollById
{
    public class GetPayrollByIdHandler : IRequestHandler<GetPayrollByIdQuery, PayrollDto>
    {
        private readonly IApplicationDbContext _context;

        public GetPayrollByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PayrollDto> Handle(GetPayrollByIdQuery request, CancellationToken cancellationToken)
        {
            var payroll = await _context.Payrolls
                .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (payroll == null)
                throw new KeyNotFoundException($"Payroll with Id {request.Id} not found");

            return new PayrollDto
            {
                Id = payroll.Id,
                EmployeeId = payroll.EmployeeId,
                GrossPay = payroll.GrossPay,
                Deductions = payroll.Deductions,
                NetPay = payroll.NetPay,
                PayPeriodStart = payroll.PayPeriodStart,
                PayPeriodEnd = payroll.PayPeriodEnd
            };
        }
    }
}
