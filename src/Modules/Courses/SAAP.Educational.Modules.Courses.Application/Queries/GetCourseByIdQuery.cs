using SAAP.Educational.Modules.Courses.Contracts;
using SAAP.Educational.Shared.CQRS;

namespace SAAP.Educational.Modules.Courses.Application.Queries;

internal sealed record GetCourseByIdQuery(Guid CourseId) : IQuery<CourseDto?>;
