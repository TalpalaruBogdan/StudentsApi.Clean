using MediatR;
using StudentApi.Application.Features.Course.Commands.DTOs;

namespace StudentApi.Application.Features.Course.Commands.CreateCourse;

public class CreateCourseCommand : IRequest<Guid>
{
     public UpsertCourseDto courseDto;
}