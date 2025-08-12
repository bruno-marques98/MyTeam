
namespace MyTeam.Domain.Entities
{
    public class Training
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public ICollection<Employee> Participants { get; private set; }

        protected Training() { }

        public Training(string title, string description, DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Participants = new List<Employee>();
        }

        public void AddParticipant(Employee employee)
        {
            if (!Participants.Contains(employee))
                Participants.Add(employee);
        }
    }
}
