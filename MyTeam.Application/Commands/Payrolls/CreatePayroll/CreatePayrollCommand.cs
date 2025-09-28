using MediatR;
using MyTeam.Application.DTOs;

namespace MyTeam.Application.Commands.Payrolls.CreatePayroll
{
    public class CreatePayrollCommand : IRequest<PayrollDto>
    {
        public Guid EmployeeId { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Deductions { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
    }
}
