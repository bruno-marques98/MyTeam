
using MyTeam.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace MyTeam.Domain.Entities
{
    public class Payroll
    {
        public int Id { get; set; }

        // Foreign key to Employee
        public int EmployeeId { get; set; }

        // Navigation property
        public Employee Employee { get; set; }

        // Payroll details
        public decimal GrossSalary { get; set; }
        public decimal NetSalary { get; private set; }
        public decimal Deductions { get; set; }
        public DateTime PaymentDate { get; set; }
        public Payroll(int employeeId, decimal grossSalary, decimal deductions, DateTime paymentDate)
        {
            EmployeeId = employeeId;
            GrossSalary = grossSalary;
            Deductions = deductions;
            PaymentDate = paymentDate;

            CalculateNetSalary();
        }

        // EF Core needs a parameterless constructor
        protected Payroll() { }

        // Method to update Net Salary
        public void UpdateNetSalary(decimal newGrossSalary, decimal newDeductions)
        {
            GrossSalary = newGrossSalary;
            Deductions = newDeductions;
            CalculateNetSalary();
        }

        // Private helper to calculate Net Salary
        private void CalculateNetSalary()
        {
            NetSalary = GrossSalary - Deductions;
            if (NetSalary < 0)
                NetSalary = 0;
        }
    }
}
