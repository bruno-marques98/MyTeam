namespace MyTeam.Domain.Entities
{
    public class Payroll
    {
        public Guid Id { get; private set; }

        // Foreign key to Employee
        public Guid EmployeeId { get; private set; }

        // Navigation property
        public Employee Employee { get; private set; }

        // Payroll details
        public decimal GrossPay { get; private set; }
        public decimal NetPay { get; private set; }
        public decimal Deductions { get; private set; }
        public DateTime PayPeriodStart { get; private set; }
        public DateTime PayPeriodEnd { get; private set; }

        private Payroll() { } // EF Core

        public Payroll(Guid employeeId, decimal grossPay, decimal deductions, DateTime payPeriodStart, DateTime payPeriodEnd)
        {
            Id = Guid.NewGuid();
            EmployeeId = employeeId;
            GrossPay = grossPay;
            Deductions = deductions;
            PayPeriodStart = payPeriodStart;
            PayPeriodEnd = payPeriodEnd;

            CalculateNetPay();
        }

        public void UpdatePayroll(decimal newGrossPay, decimal newDeductions, DateTime newPayPeriodStart, DateTime newPayPeriodEnd)
        {
            GrossPay = newGrossPay;
            Deductions = newDeductions;
            PayPeriodStart = newPayPeriodStart;
            PayPeriodEnd = newPayPeriodEnd;

            CalculateNetPay();
        }

        private void CalculateNetPay()
        {
            NetPay = GrossPay - Deductions;
            if (NetPay < 0)
                NetPay = 0;
        }
    }
}
