using SAAP.Educational.Domain.Common;

namespace SAAP.Educational.Domain.Courses;

public sealed class Course : Entity<Guid>
{
    private Course(Guid id, string title, string description)
        : base(id)
    {
        Title = title;
        Description = description;
    }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public static Course Create(string title, string description)
    {
        return new Course(Guid.NewGuid(), title, description);
    }
}
