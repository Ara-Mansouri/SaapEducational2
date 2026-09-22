using SAAP.Educational.Modules.Courses.Contracts;
using SAAP.Educational.Shared.CQRS;

namespace SAAP.Educational.Modules.Courses.Application.Commands;

internal sealed record CreateCourseCommand(string Title, string Description) : ICommand<CourseDto>;
