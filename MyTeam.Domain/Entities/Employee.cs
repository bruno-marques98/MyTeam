using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime HiredDate { get; set; }
        public Department Department { get; set; }
        public Job Job { get; set; }
        public decimal Salary { get; set; }
        public ICollection<Attendance> AttendanceRecords { get; set; }

    }
}
