
namespace MyTeam.Domain.Entities
{
    internal class Recruitment
    {
        public Guid Id { get; private set; }
        public string PositionTitle { get; private set; }
        public DateTime PostingDate { get; private set; }
        public DateTime ClosingDate { get; private set; }
        public List<string> Requirements { get; private set; }
        public string Status { get; private set; } // Open, Closed, In Progress

        protected Recruitment() { }

        public Recruitment(string positionTitle, DateTime postingDate, DateTime closingDate, List<string> requirements)
        {
            Id = Guid.NewGuid();
            PositionTitle = positionTitle;
            PostingDate = postingDate;
            ClosingDate = closingDate;
            Requirements = requirements ?? new List<string>();
            Status = "Open";
        }

        public void CloseRecruitment()
        {
            Status = "Closed";
        }
    }
}
