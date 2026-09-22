using SAAP.Educational.Modules.Courses.Contracts;
using SAAP.Educational.Modules.Courses.Domain.Courses;
using SAAP.Educational.Shared.CQRS;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Modules.Courses.Application.Queries;

internal sealed class GetCourseByIdQueryHandler(IQueryRepository<Course, Guid> courseRepository)
    : IQueryHandler<GetCourseByIdQuery, CourseDto?>
{
    public async Task<CourseDto?> Handle(
        GetCourseByIdQuery request,
        CancellationToken cancellationToken)
    {
        var course = await courseRepository.GetByIdAsync(request.CourseId, cancellationToken);

        return course is null
            ? null
            : new CourseDto(course.Id, course.Title, course.Description);
    }
}
