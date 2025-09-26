using MediatR;

namespace MyTeam.Application.Commands.Jobs.CreateJob
{
    public class CreateJobCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public string EmploymentType { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
