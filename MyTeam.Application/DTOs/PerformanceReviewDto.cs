namespace MyTeam.Application.DTOs
{
    public class PerformanceReviewDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Reviewer { get; set; } 
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}
