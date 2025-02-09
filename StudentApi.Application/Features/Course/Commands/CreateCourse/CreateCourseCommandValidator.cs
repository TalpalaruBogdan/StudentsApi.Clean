using FluentValidation;

namespace StudentApi.Application.Features.Course.Commands.CreateCourse;

public class CreateCourseCommandValidator : AbstractValidator<CreateCourseCommand>
{
     public CreateCourseCommandValidator()
     {
          RuleFor(p => p.courseDto.CourseDescription)
               .NotEmpty().WithMessage("Course Description cannot be empty")
               .MaximumLength(500).WithMessage("Course Description cannot exceed 500 characters");
          RuleFor(p => p.courseDto.CourseName)
               .NotEmpty().WithMessage("Course Name cannot be empty")
               .MaximumLength(100).WithMessage("Course Name cannot exceed 100 characters");
          RuleFor(p => p.courseDto.CoursePrice)
               .GreaterThan(0)
               .WithMessage("Course Price must be greater than 0");
     }
}