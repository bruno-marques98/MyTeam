using MediatR;

namespace MyTeam.Application.Commands.Jobs.UpdateJob
{
    public class UpdateJobCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public string EmploymentType { get; set; }
    }
}
