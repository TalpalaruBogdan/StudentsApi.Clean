using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;
using StudentApi.Application.Exceptions;

namespace StudentApi.Application.Features.Course.Commands.DeleteCourse;

public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand>
{
     private readonly ICourseRepository _courseRepository;

     public DeleteCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
     {
          _courseRepository = courseRepository;
     }
     
     public async Task Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
     {
          var course = await _courseRepository.GetById(request.Id);

          if (course is null)
          {
               throw new CourseNotFoundException(course.CourseName, request.Id);
          }
          
          await _courseRepository.Delete(request.Id);
     }
}