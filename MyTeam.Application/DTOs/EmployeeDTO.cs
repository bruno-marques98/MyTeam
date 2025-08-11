﻿namespace MyTeam.Application.DTOs
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid JobId { get; set; }
        public DateTime HireDate { get; set; }
    }
}
