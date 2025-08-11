using MyTeam.Domain.Enums;

namespace MyTeam.Domain.Entities
{
    public class LeaveRequest
    {
        public Guid Id { get; private set; }
        public Guid EmployeeId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public LeaveType LeaveType { get; private set; }
        public LeaveStatus Status { get; private set; }
        public string Reason { get; private set; }
        public DateTime RequestedAt { get; private set; }

        // Navigation property
        public Employee Employee { get; private set; }

        private LeaveRequest() { } // EF Core

        public LeaveRequest(Guid employeeId, DateTime startDate, DateTime endDate, LeaveType leaveType, string reason)
        {
            Id = Guid.NewGuid();
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            LeaveType = leaveType;
            Reason = reason;
            Status = LeaveStatus.Pending;
            RequestedAt = DateTime.UtcNow;
        }

        public void Approve()
        {
            Status = LeaveStatus.Approved;
        }

        public void Reject()
        {
            Status = LeaveStatus.Rejected;
        }
    }
}
