using SAAP.Educational.Modules.Courses.Application;
using SAAP.Educational.Modules.Courses.Infrastructure;
using SAAP.Educational.Modules.Courses.Presentation;
using SAAP.Educational.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSharedKernel();
builder.Services.AddCoursesApplication();
builder.Services.AddCoursesInfrastructure();
builder.Services
    .AddControllers()
    .AddApplicationPart(typeof(CoursesController).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
