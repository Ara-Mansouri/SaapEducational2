using Microsoft.AspNetCore.Mvc;
using SAAP.Educational.Modules.Courses.Contracts;

namespace SAAP.Educational.Modules.Courses.Presentation;

[ApiController]
[Route("api/courses")]
public sealed class CoursesController(ICoursesModule coursesModule) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<CourseDto>>> List(
        CancellationToken cancellationToken)
    {
        return Ok(await coursesModule.ListAsync(cancellationToken));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<CourseDto>> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var course = await coursesModule.GetByIdAsync(id, cancellationToken);
        return course is null ? NotFound() : Ok(course);
    }

    [HttpPost]
    public async Task<ActionResult<CourseDto>> Create(
        CreateCourseRequest request,
        CancellationToken cancellationToken)
    {
        var course = await coursesModule.CreateAsync(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = course.Id }, course);
    }
}
