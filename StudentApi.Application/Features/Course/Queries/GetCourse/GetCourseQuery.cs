using MediatR;
using StudentApi.Application.Features.Course.Queries.DTOs;

namespace StudentApi.Application.Features.Course.Queries.GetCourse;

public class GetCourseQuery : IRequest<CourseDto>
{
     public Guid id;
}