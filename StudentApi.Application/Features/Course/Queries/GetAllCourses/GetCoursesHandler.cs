using AutoMapper;
using MediatR;
using StudentApi.Application.Contracts.Persistence;
using StudentApi.Application.Features.Course.Queries.DTOs;

namespace StudentApi.Application.Features.Course.Queries.GetAllCourses;

public class GetCoursesHandler : IRequestHandler<GetCoursesQuery, List<CourseDto>>
{
     private readonly ICourseRepository _courseRepository;
     private readonly IMapper _mapper;

     public GetCoursesHandler(ICourseRepository courseRepository, IMapper mapper)
     {
          _courseRepository = courseRepository;
          _mapper = mapper;
     }
     
     public async Task<List<CourseDto>> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
     {
          var result = await _courseRepository.GetAll();
          return _mapper.Map<List<CourseDto>>(result);
     }
}