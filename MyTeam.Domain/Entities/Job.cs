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
        public Guid Id { get; set; }

        // Job Info
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public JobType JobType { get; set; }
        public ContractType ContractType { get; set; }
        public decimal BaseSalary { get; set; }
        public string? Requirements { get; set; }

        // Navigation properties
        public ICollection<Employee>? Employees { get; set; }
    }
}
