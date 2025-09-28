using MediatR;
using Microsoft.EntityFrameworkCore;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;

namespace MyTeam.Application.Commands.Payrolls.UpdatePayroll
{
    public class UpdatePayrollHandler : IRequestHandler<UpdatePayrollCommand, PayrollDto>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePayrollHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PayrollDto> Handle(UpdatePayrollCommand request, CancellationToken cancellationToken)
        {
            var payroll = await _context.Payrolls
                .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (payroll == null)
                throw new KeyNotFoundException($"Payroll with Id {request.Id} not found");

            payroll.UpdatePayroll(
                request.GrossPay,
                request.Deductions,
                request.PayPeriodStart,
                request.PayPeriodEnd
            );

            await _context.SaveChangesAsync(cancellationToken);

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
