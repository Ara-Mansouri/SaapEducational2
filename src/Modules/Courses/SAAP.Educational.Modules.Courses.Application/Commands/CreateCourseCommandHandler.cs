using SAAP.Educational.Modules.Courses.Contracts;
using SAAP.Educational.Modules.Courses.Domain.Courses;
using SAAP.Educational.Shared.CQRS;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Modules.Courses.Application.Commands;

internal sealed class CreateCourseCommandHandler(
    ICommandRepository<Course, Guid> courseRepository)
    : ICommandHandler<CreateCourseCommand, CourseDto>
{
    public async Task<CourseDto> Handle(
        CreateCourseCommand request,
        CancellationToken cancellationToken)
    {
        var course = Course.Create(request.Title, request.Description);

        await courseRepository.AddAsync(course, cancellationToken);
        await courseRepository.SaveChangesAsync(cancellationToken);

        return new CourseDto(course.Id, course.Title, course.Description);
    }
}
