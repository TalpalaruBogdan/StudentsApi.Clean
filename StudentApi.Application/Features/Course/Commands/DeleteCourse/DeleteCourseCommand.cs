using MediatR;

namespace StudentApi.Application.Features.Course.Commands.DeleteCourse;

public class DeleteCourseCommand : IRequest
{
     public Guid Id;
}