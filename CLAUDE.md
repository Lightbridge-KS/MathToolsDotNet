# MathTool .NET

## About

This is an educational repo for learning how to structure .NET solutions and projects.

## Architecture

This solution demonstrates proper .NET project organization:

- **MathToolsDotNet.Core** - Class library containing business logic (`Calculator` class)
- **MathToolsDotNet.CLI** - Console application consuming Core library
- **MathToolsDotNet.Api** - Minimal Web API (ASP.NET Core) consuming Core library

The Core library is referenced by both CLI and API projects, demonstrating code reuse and separation of concerns.

## Key Features

- .NET 9.0 target framework
- Nullable reference types enabled
- Implicit usings enabled
- Dependency injection (API project registers Calculator as singleton)
- OpenAPI/Swagger support for API documentation
- HTTP request file (`.http`) for API testing

## Development Notes

When adding new functionality:
1. Add methods to `Calculator.cs` in Core project
2. Update CLI's `Program.cs` to demonstrate console usage
3. Add corresponding API endpoints in Api's `Program.cs`
4. Update `.http` file with test cases
