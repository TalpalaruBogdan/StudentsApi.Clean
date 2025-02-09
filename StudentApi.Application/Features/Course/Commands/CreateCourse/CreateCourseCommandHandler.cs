using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;
using StudentApi.Application.Exceptions;
using ValidationException = FluentValidation.ValidationException;

namespace StudentApi.Application.Features.Course.Commands.CreateCourse;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
{
     private readonly ICourseRepository _courseRepository;
     private readonly IMapper _mapper;
     
     public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
     {
          var createCourseCommanValidator = new CreateCourseCommandValidator();
          var validationResult = await createCourseCommanValidator.ValidateAsync(request);

          if (!validationResult.IsValid)
          {
               throw new ValidationException(validationResult.Errors);
          }
          
          Guid courseId = Guid.NewGuid();

          var checkIfCourseExists = await _courseRepository.GetCourseByName(request.courseDto.CourseName);

          if (checkIfCourseExists is not null)
          {
               throw new CourseAlreadyExistsException(checkIfCourseExists.CourseName, checkIfCourseExists.Id);
          }
          
          var courseToAdd = _mapper.Map<StudentsApi.Domain.Entities.Course>(request);
          courseToAdd.Id = courseId;
          await _courseRepository.Add(courseToAdd);
          return courseId;
     }
}