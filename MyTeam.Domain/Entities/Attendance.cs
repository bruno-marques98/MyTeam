using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam.Domain.Entities
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public TimeSpan CheckIn { get; set; }
        public TimeSpan? CheckOut { get; set; }

        // Navigation Properties
        public Employee? Employee { get; set; }
    }
}
