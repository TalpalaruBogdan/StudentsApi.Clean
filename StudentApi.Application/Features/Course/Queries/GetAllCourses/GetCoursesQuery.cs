using MediatR;
using StudentApi.Application.Features.Course.Queries.DTOs;

namespace StudentApi.Application.Features.Course.Queries.GetAllCourses;

public class GetCoursesQuery : IRequest<List<CourseDto>>
{
     
}