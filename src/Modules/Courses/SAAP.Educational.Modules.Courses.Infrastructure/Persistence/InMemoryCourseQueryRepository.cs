using SAAP.Educational.Modules.Courses.Domain.Courses;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Modules.Courses.Infrastructure.Persistence;

internal sealed class InMemoryCourseQueryRepository(CourseStorage storage)
    : IQueryRepository<Course, Guid>
{
    public Task<Course?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(storage.Courses.FirstOrDefault(course => course.Id == id));
    }

    public Task<IReadOnlyList<Course>> ListAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IReadOnlyList<Course>>(storage.Courses);
    }
}
