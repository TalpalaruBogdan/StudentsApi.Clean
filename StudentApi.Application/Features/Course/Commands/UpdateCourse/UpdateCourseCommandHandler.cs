using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;
using StudentApi.Application.Exceptions;
using StudentApi.Application.Features.Course.Commands.DTOs;

namespace StudentApi.Application.Features.Course.Commands.UpdateCourse;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Unit>
{
     private readonly ICourseRepository _courseRepository;
     private readonly IMapper _mapper;

     public UpdateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
     {
          _courseRepository = courseRepository;
          _mapper = mapper;
     }
     
     public async Task<Unit> Handle(UpdateCourseCommand command, CancellationToken cancellationToken)
     {
          var checkIfCourseExists = await _courseRepository.GetById(command.Id);

          if (checkIfCourseExists is null)
          {
               throw new CourseNotFoundException(command.UpsertCourseDto.CourseName, command.Id);
          }
          
          await _courseRepository.Update(command.Id, _mapper.Map<StudentsApi.Domain.Entities.Course>(command.UpsertCourseDto));
          return new Unit();
     }
}