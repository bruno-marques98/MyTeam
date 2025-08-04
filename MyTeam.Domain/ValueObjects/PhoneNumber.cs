using System.Text.RegularExpressions;

namespace MyTeam.Domain.ValueObjects
{
    public class PhoneNumber
    {
        public string Value { get; }

        public PhoneNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\+?[0-9]{7,15}$"))
                throw new ArgumentException("Invalid phone number", nameof(value));

            Value = value;
        }

        public override string ToString() => Value;
    }
}
