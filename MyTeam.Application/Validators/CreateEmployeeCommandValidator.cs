using FluentValidation;
using MyTeam.Application.Commands.Employees.CreateEmployee;
using MyTeam.Domain.ValueObjects;

namespace MyTeam.Application.Validators
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100);

            RuleFor(x => x.Email)
                .NotNull().WithMessage("Email is required.")
                .Must(email => email != null && !string.IsNullOrWhiteSpace(email.Value))
                .WithMessage("Email cannot be empty.")
                .Must(email => email != null &&
                    System.Text.RegularExpressions.Regex.IsMatch(email.Value, @"^\S+@\S+\.\S+$"))
                .WithMessage("Invalid email format.");

            RuleFor(x => x.DepartmentId)
                .NotEmpty().WithMessage("Department ID is required.");
        }
    }
}
