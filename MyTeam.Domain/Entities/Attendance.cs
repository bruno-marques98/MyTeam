using MyTeam.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam.Domain.Entities
{
    public class Attendance
    {
        public Guid Id { get; set; }
        
        // Foreign Keys
        public Guid EmployeeId { get; set; } // FK -> Employee
       
        // Attendance Information
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public TimeSpan CheckIn { get; set; }
        public TimeSpan? CheckOut { get; set; }
        public string? Notes { get; set; }
        public AttendanceStatus Status { get; set; } = AttendanceStatus.Present;

        // Navigation Properties
        public Employee? Employee { get; set; }
    }
}
