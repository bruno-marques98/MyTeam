using System.Text.RegularExpressions;

namespace MyTeam.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\S+@\S+\.\S+$"))
                throw new ArgumentException("Invalid email address", nameof(value));

            Value = value;
        }

        public override string ToString() => Value;
    }
}
