using MyTeam.Domain.Enums;
using MyTeam.Domain.ValueObjects;

namespace MyTeam.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; } // FK -> Job

        // Personal Info
        public string FullName { get; set; } = string.Empty;
        public required Email Email { get; set; }
        public required PhoneNumber PhoneNumber { get; set; }
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
        public Job? Job { get; set; }
        public ICollection<Attendance>? AttendanceRecords { get; set; }
        public ICollection<LeaveRequest>? LeaveRequests { get; set; }

        // Audit Info
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
    }
}
