
using MyTeam.Domain.ValueObjects;

namespace MyTeam.Domain.Entities
{
    public class Payroll
    {
        public Guid Id { get; private set; }
        public Guid EmployeeId { get; private set; }
        public PayPeriod Period { get; private set; }
        public Money GrossSalary { get; private set; }
        public Money NetSalary { get; private set; }

        private Payroll() { } // EF Core

        public Payroll(Guid employeeId, PayPeriod period, Money grossSalary, Money netSalary)
        {
            Id = Guid.NewGuid();
            EmployeeId = employeeId;
            Period = period ?? throw new ArgumentNullException(nameof(period));
            GrossSalary = grossSalary ?? throw new ArgumentNullException(nameof(grossSalary));
            NetSalary = netSalary ?? throw new ArgumentNullException(nameof(netSalary));
        }

        public void UpdateNetSalary(Money newNetSalary)
        {
            NetSalary = newNetSalary ?? throw new ArgumentNullException(nameof(newNetSalary));
        }
    }
}
