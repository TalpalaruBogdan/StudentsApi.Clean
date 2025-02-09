using MediatR;
using StudentApi.Application.Features.Course.Commands.DTOs;

namespace StudentApi.Application.Features.Course.Commands.UpdateCourse;

public class UpdateCourseCommand : IRequest<Unit>
{
     public Guid Id { get; set; }
     public UpsertCourseDto UpsertCourseDto { get; set; }
}