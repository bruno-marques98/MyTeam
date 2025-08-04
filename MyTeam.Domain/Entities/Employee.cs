using MyTeam.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        // Personal Info
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        // Job Info 
        public DateTime HireDate { get; set; }
        public Guid DepartmentId { get; set; } // FK for Department
        public string JobTitle { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        // Status
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public Department? Department { get; set; }
        public ICollection<Attendance>? AttendanceRecords { get; set; }
        public ICollection<LeaveRequest>? LeaveRequests { get; set; }

        // Audit Info
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
    }
}
