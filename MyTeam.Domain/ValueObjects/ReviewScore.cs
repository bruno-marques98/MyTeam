namespace MyTeam.Domain.ValueObjects
{
    public class ReviewScore
    {
        public int Value { get; }

        public ReviewScore(int value)
        {
            if (value < 1 || value > 5)
                throw new ArgumentException("Score must be between 1 and 5.");

            Value = value;
        }
    }
}
