using AutoMapper;
using MyTeam.Application.DTOs;
using MyTeam.Domain.Entities;

namespace MyTeam.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Employee
            CreateMap<Employee, EmployeeDto>().ReverseMap();

            // Department
            CreateMap<Department, DepartmentDto>().ReverseMap();

            // Job
            CreateMap<Job, JobDto>().ReverseMap();

            // Attendance
            CreateMap<Attendance, AttendanceDto>().ReverseMap();

            // LeaveRequest
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();

            // Payroll
            CreateMap<Payroll, PayrollDto>().ReverseMap();

            // Training
            CreateMap<Training, TrainingDto>().ReverseMap();

            // PerformanceReview
            CreateMap<PerformanceReview, PerformanceReviewDto>().ReverseMap();

            // Benefit
            CreateMap<Benefit, BenefitDto>().ReverseMap();
        }
    }
}
