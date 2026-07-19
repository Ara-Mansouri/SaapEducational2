using SAAP.Educational.Shared.CQRS;

namespace SAAP.Educational.Application.Features.Courses.Queries;

public sealed record GetCourseByIdQuery(Guid CourseId) : IQuery<CourseDto?>;
