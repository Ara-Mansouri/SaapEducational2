using SAAP.Educational.Modules.Courses.Application.Commands;
using SAAP.Educational.Modules.Courses.Application.Queries;
using SAAP.Educational.Modules.Courses.Contracts;
using SAAP.Educational.Shared.Mediator;

namespace SAAP.Educational.Modules.Courses.Application;

internal sealed class CoursesModule(IApplicationMediator mediator) : ICoursesModule
{
    public Task<IReadOnlyList<CourseDto>> ListAsync(CancellationToken cancellationToken = default)
    {
        return mediator.QueryAsync(new ListCoursesQuery(), cancellationToken);
    }

    public Task<CourseDto?> GetByIdAsync(
        Guid courseId,
        CancellationToken cancellationToken = default)
    {
        return mediator.QueryAsync(new GetCourseByIdQuery(courseId), cancellationToken);
    }

    public Task<CourseDto> CreateAsync(
        CreateCourseRequest request,
        CancellationToken cancellationToken = default)
    {
        return mediator.SendAsync(
            new CreateCourseCommand(request.Title, request.Description),
            cancellationToken);
    }
}
