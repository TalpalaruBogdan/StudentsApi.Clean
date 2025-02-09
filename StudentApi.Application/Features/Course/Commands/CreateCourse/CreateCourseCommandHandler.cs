using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;

namespace StudentApi.Application.Features.Course.Commands.CreateCourse;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
{
     private readonly ICourseRepository _courseRepository;
     private readonly IMapper _mapper;
     
     public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
     {
          Guid courseId = Guid.NewGuid();
          var courseToAdd = _mapper.Map<StudentsApi.Domain.Entities.Course>(request);
          courseToAdd.Id = courseId;
          await _courseRepository.Add(courseToAdd);
          return courseId;
     }
}