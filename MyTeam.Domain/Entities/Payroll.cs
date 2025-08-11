
namespace MyTeam.Domain.Entities
{
    internal class Payroll
    {
        public Guid Id { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Employee Employee { get; private set; }

        public decimal BasicSalary { get; private set; }
        public decimal Bonuses { get; private set; }
        public decimal Deductions { get; private set; }
        public decimal NetPay => BasicSalary + Bonuses - Deductions;

        public DateTime PayPeriodStart { get; private set; }
        public DateTime PayPeriodEnd { get; private set; }
        public DateTime PaymentDate { get; private set; }

        public string PaymentMethod { get; private set; } // Bank Transfer, Cash, etc.
        public string Notes { get; private set; }

        private Payroll() { } // EF Core

        public Payroll(Guid employeeId, decimal basicSalary, decimal bonuses, decimal deductions,
                       DateTime payPeriodStart, DateTime payPeriodEnd, DateTime paymentDate,
                       string paymentMethod, string notes)
        {
            Id = Guid.NewGuid();
            EmployeeId = employeeId;
            BasicSalary = basicSalary;
            Bonuses = bonuses;
            Deductions = deductions;
            PayPeriodStart = payPeriodStart;
            PayPeriodEnd = payPeriodEnd;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
            Notes = notes;
        }

        // Method: Update Payroll
        public void UpdatePayroll(decimal basicSalary, decimal bonuses, decimal deductions,
                                   string paymentMethod, string notes)
        {
            BasicSalary = basicSalary;
            Bonuses = bonuses;
            Deductions = deductions;
            PaymentMethod = paymentMethod;
            Notes = notes;
        }
    }
}
