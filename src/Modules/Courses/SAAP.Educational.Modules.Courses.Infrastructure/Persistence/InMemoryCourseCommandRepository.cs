using SAAP.Educational.Modules.Courses.Domain.Courses;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Modules.Courses.Infrastructure.Persistence;

internal sealed class InMemoryCourseCommandRepository(CourseStorage storage)
    : ICommandRepository<Course, Guid>
{
    public Task AddAsync(Course entity, CancellationToken cancellationToken = default)
    {
        storage.Courses.Add(entity);
        return Task.CompletedTask;
    }

    public void Update(Course entity)
    {
        var index = storage.Courses.FindIndex(course => course.Id == entity.Id);
        if (index >= 0)
        {
            storage.Courses[index] = entity;
        }
    }

    public void Remove(Course entity)
    {
        storage.Courses.RemoveAll(course => course.Id == entity.Id);
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(1);
    }
}
