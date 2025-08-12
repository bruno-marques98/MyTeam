
namespace MyTeam.Domain.ValueObjects
{
    public class PayPeriod
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        private PayPeriod() { } // EF Core

        public PayPeriod(DateTime startDate, DateTime endDate)
        {
            if (endDate <= startDate)
                throw new ArgumentException("End date must be after start date.");

            StartDate = startDate;
            EndDate = endDate;
        }

        public bool IncludesDate(DateTime date)
        {
            return date >= StartDate && date <= EndDate;
        }

        public override bool Equals(object obj)
        {
            if (obj is PayPeriod other)
                return StartDate == other.StartDate && EndDate == other.EndDate;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(StartDate, EndDate);
    }
}
