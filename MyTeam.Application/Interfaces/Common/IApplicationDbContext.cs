using Microsoft.EntityFrameworkCore;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Interfaces.Common
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Attendance> Attendances { get; set; }
        DbSet<LeaveRequest> LeaveRequests { get; set; }
        DbSet<Payroll> Payrolls { get; set; }
        DbSet<Training> Trainings { get; set; }
        DbSet<PerformanceReview> PerformanceReviews { get; set; }
        DbSet<Benefit> Benefits { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
