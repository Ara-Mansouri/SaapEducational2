# SAAP Educational

.NET 8 Web API scaffolded with Onion Architecture and CQRS.

## Project Structure

- `src/SAAP.Educational.Domain`: enterprise/domain entities and domain rules.
- `src/SAAP.Educational.Application`: use cases, CQRS handlers, DTOs, and application services.
- `src/SAAP.Educational.Shared`: shared CQRS, mediator, and repository abstractions.
- `src/SAAP.Educational.Infrastructure`: persistence and external service implementations.
- `src/SAAP.Educational.Api`: HTTP API, controllers, and host configuration.

## Dependency Flow

- `Domain` has no project dependencies.
- `Shared` contains reusable abstractions.
- `Application` depends on `Domain` and `Shared`.
- `Infrastructure` depends on `Application`, `Domain`, and `Shared`.
- `Api` composes `Application` and `Infrastructure`.

## Local Build Note

The current folder name contains a literal `%20`. MSBuild may decode it as a space when resolving `obj` files.
Use a path without `%` for builds, or map the folder temporarily:

```powershell
subst S: "C:\Users\60179\source\repos\SAAP%20Educational"
dotnet build S:\SAAP.Educational.sln
```
