using SAAP.Educational.Modules.Courses.Domain.Courses;

namespace SAAP.Educational.Modules.Courses.Infrastructure.Persistence;

internal sealed class CourseStorage
{
    public CourseStorage()
    {
        Courses =
        [
            Course.Create("Onion Architecture", "Layered architecture sample for SAAP Educational."),
            Course.Create("CQRS with MediatR", "Command and query separation with shared abstractions.")
        ];
    }

    public List<Course> Courses { get; }
}
