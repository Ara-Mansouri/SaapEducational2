using SAAP.Educational.Domain.Courses;
using SAAP.Educational.Shared.CQRS;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Application.Features.Courses.Queries;

internal sealed class GetCourseByIdQueryHandler : IQueryHandler<GetCourseByIdQuery, CourseDto?>
{
    private readonly IQueryRepository<Course, Guid> _courseRepository;

    public GetCourseByIdQueryHandler(IQueryRepository<Course, Guid> courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<CourseDto?> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
    {
        var course = await _courseRepository.GetByIdAsync(request.CourseId, cancellationToken);

        return course is null
            ? null
            : new CourseDto(course.Id, course.Title, course.Description);
    }
}
