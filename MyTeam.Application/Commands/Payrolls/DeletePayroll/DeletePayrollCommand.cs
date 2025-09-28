using MediatR;

namespace MyTeam.Application.Commands.Payrolls.DeletePayroll
{
    public class DeletePayrollCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
