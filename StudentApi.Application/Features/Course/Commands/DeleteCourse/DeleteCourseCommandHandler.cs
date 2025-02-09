using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;

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
          await _courseRepository.Delete(request.Id);
     }
}