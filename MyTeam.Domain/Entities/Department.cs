
namespace MyTeam.Domain.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        // Navigation properties
        public ICollection<Employee>? Employees { get; set;}
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
