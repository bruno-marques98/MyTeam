
namespace MyTeam.Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        private Money() { } // EF Core

        public Money(decimal amount, string currency)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
            if (string.IsNullOrWhiteSpace(currency)) throw new ArgumentException("Currency is required.");

            Amount = amount;
            Currency = currency.ToUpper();
        }

        public Money Add(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Currencies must match to add amounts.");

            return new Money(Amount + other.Amount, Currency);
        }

        public Money Subtract(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Currencies must match to subtract amounts.");

            return new Money(Amount - other.Amount, Currency);
        }

        public override bool Equals(object obj)
        {
            if (obj is Money other)
                return Amount == other.Amount && Currency == other.Currency;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Amount, Currency);
    }
}
