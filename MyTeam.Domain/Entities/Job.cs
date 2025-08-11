using MyTeam.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam.Domain.Entities
{
    public class Job
    {
        public Guid Id { get; private set; } // Primary Key

        public string Title { get; private set; } // e.g., "Software Engineer"
        public string Description { get; private set; }
        public decimal Salary { get; private set; }
        public string EmploymentType { get; private set; } // e.g., Full-Time, Part-Time, Contract

        // Relationships
        public Guid DepartmentId { get; private set; }
        public Department Department { get; private set; }

        // Optional: Track which employees have this job
        private readonly List<Employee> _employees = new();
        public IReadOnlyCollection<Employee> Employees => _employees.AsReadOnly();

        // Constructor for EF Core
        private Job() { }

        public Job(string title, string description, decimal salary, string employmentType, Guid departmentId)
        {
            Id = Guid.NewGuid();
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description;
            Salary = salary;
            EmploymentType = employmentType;
            DepartmentId = departmentId;
        }

        public void UpdateJob(string title, string description, decimal salary, string employmentType)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description;
            Salary = salary;
            EmploymentType = employmentType;
        }
    }
}
