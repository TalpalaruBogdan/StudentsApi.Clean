using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;
using StudentApi.Application.Features.Course.Queries.DTOs;
using StudentApi.Application.Features.Course.Queries.GetAllCourses;

namespace StudentApi.Application.Features.Course.Queries.GetCourse;

public class GetCourseHandler : IRequestHandler<GetCourseQuery, CourseDto>
{
     private readonly ICourseRepository _courseRepository;
     private readonly IMapper _mapper;
     
     public GetCourseHandler(ICourseRepository courseRepository, IMapper mapper)
     {
          _courseRepository = courseRepository;
          _mapper = mapper;
     }
     
     public async Task<CourseDto> Handle(GetCourseQuery request, CancellationToken cancellationToken)
     {
          // 1. Query db
          // 2. convert to dto
          var result = await _courseRepository.GetById(request.id);
          return _mapper.Map<CourseDto>(result);
     }
}