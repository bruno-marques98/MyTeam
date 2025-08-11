namespace MyTeam.Application.DTOs
{
    public class JobDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
    }
}
