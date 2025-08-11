namespace MyTeam.Application.DTOs
{
    public class BenefitDto
    {
        public Guid Id { get; set; }
        public string BenefitName { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
