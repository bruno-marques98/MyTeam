
namespace MyTeam.Domain.ValueObjects
{
    public class TrainingSchedule
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public TrainingSchedule(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new ArgumentException("End date cannot be earlier than start date.");

            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
