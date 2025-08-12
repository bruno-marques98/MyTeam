using MyTeam.Application.DTOs;

namespace MyTeam.Application.Interfaces.Payroll
{
    public interface IPayrollService
    {
        Task<IEnumerable<PayrollDto>> GetAllAsync();
        Task<PayrollDto?> GetByIdAsync(Guid id);
        Task<PayrollDto> ProcessPayrollAsync(PayrollDto payroll);
    }
}
