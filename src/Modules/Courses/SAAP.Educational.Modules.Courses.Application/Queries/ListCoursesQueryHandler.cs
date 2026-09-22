using SAAP.Educational.Modules.Courses.Contracts;
using SAAP.Educational.Modules.Courses.Domain.Courses;
using SAAP.Educational.Shared.CQRS;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Modules.Courses.Application.Queries;

internal sealed class ListCoursesQueryHandler(IQueryRepository<Course, Guid> courseRepository)
    : IQueryHandler<ListCoursesQuery, IReadOnlyList<CourseDto>>
{
    public async Task<IReadOnlyList<CourseDto>> Handle(
        ListCoursesQuery request,
        CancellationToken cancellationToken)
    {
        var courses = await courseRepository.ListAsync(cancellationToken);

        return courses
            .Select(course => new CourseDto(course.Id, course.Title, course.Description))
            .ToList();
    }
}
