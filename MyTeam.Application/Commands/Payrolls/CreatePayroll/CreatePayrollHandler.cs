using MediatR;
using MyTeam.Application.DTOs;
using MyTeam.Application.Interfaces.Common;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Commands.Payrolls.CreatePayroll
{
    public class CreatePayrollHandler : IRequestHandler<CreatePayrollCommand, PayrollDto>
    {
        private readonly IApplicationDbContext _context;

        public CreatePayrollHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PayrollDto> Handle(CreatePayrollCommand request, CancellationToken cancellationToken)
        {
            var payroll = new Payroll(
                request.EmployeeId,
                request.GrossPay,
                request.Deductions,
                request.PayPeriodStart,
                request.PayPeriodEnd
            );

            _context.Payrolls.Add(payroll);
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
