namespace SAAP.Educational.Modules.Courses.Contracts;

public interface ICoursesModule
{
    Task<IReadOnlyList<CourseDto>> ListAsync(CancellationToken cancellationToken = default);

    Task<CourseDto?> GetByIdAsync(Guid courseId, CancellationToken cancellationToken = default);

    Task<CourseDto> CreateAsync(
        CreateCourseRequest request,
        CancellationToken cancellationToken = default);
}
