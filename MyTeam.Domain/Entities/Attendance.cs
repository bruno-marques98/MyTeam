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
        public Guid Id { get; private set; }
        public Guid EmployeeId { get; private set; }
        public DateTime Date { get; private set; }
        public TimeSpan? CheckInTime { get; private set; }
        public TimeSpan? CheckOutTime { get; private set; }
        public string Status { get; private set; } // Present, Absent, Late, etc.

        // Navigation
        public Employee Employee { get; private set; }

        // Required by EF
        private Attendance() { }

        public Attendance(Guid employeeId, DateTime date, string status)
        {
            if (employeeId == Guid.Empty)
                throw new ArgumentException("Employee ID is required.", nameof(employeeId));

            Id = Guid.NewGuid();
            EmployeeId = employeeId;
            Date = date.Date; // Ensure date has no time
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        public void CheckIn(TimeSpan checkInTime)
        {
            if (CheckInTime.HasValue)
                throw new InvalidOperationException("Check-in already recorded.");

            CheckInTime = checkInTime;
        }

        public void CheckOut(TimeSpan checkOutTime)
        {
            if (!CheckInTime.HasValue)
                throw new InvalidOperationException("Cannot check out without checking in first.");

            if (CheckOutTime.HasValue)
                throw new InvalidOperationException("Check-out already recorded.");

            if (checkOutTime < CheckInTime.Value)
                throw new ArgumentException("Check-out time cannot be before check-in time.");

            CheckOutTime = checkOutTime;
        }

        public void UpdateStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("Status cannot be empty.");

            Status = status;
        }
    }
}
