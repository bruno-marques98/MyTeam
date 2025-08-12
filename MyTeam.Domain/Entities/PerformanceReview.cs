
namespace MyTeam.Domain.Entities
{
    public class PerformanceReview
    {
        public Guid Id { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Employee Employee { get; private set; }
        public DateTime ReviewDate { get; private set; }
        public string Reviewer { get; private set; }
        public string Comments { get; private set; }
        public int Rating { get; private set; } // Example: 1-5 scale

        protected PerformanceReview() { }

        public PerformanceReview(Employee employee, DateTime reviewDate, string reviewer, string comments, int rating)
        {
            Id = Guid.NewGuid();
            Employee = employee;
            EmployeeId = employee.Id;
            ReviewDate = reviewDate;
            Reviewer = reviewer;
            Comments = comments;
            Rating = rating;
        }
    }
}
