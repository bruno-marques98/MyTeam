using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Commands.Payrolls.UpdatePayroll
{
    public class UpdatePayrollCommand : IRequest<PayrollDto>
    {
        public Guid Id { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Deductions { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
    }
}
