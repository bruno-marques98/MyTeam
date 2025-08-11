
namespace MyTeam.Domain.Entities
{
    internal class Benefit
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }

        protected Benefit() { }

        public Benefit(string name, string description, decimal amount)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Amount = amount;
        }
    }
}
