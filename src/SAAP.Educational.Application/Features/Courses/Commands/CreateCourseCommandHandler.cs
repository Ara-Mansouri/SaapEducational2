using SAAP.Educational.Domain.Courses;
using SAAP.Educational.Shared.CQRS;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Application.Features.Courses.Commands;

internal sealed class CreateCourseCommandHandler : ICommandHandler<CreateCourseCommand, CourseDto>
{
    private readonly ICommandRepository<Course, Guid> _courseRepository;

    public CreateCourseCommandHandler(ICommandRepository<Course, Guid> courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<CourseDto> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = Course.Create(request.Title, request.Description);

        await _courseRepository.AddAsync(course, cancellationToken);
        await _courseRepository.SaveChangesAsync(cancellationToken);

        return new CourseDto(course.Id, course.Title, course.Description);
    }
}
