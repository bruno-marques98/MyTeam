namespace MyTeam.Application.DTOs
{
    public class PayrollDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
    }
}
