# MathTool .NET

> Educational repo demonstrating .NET solution structure with shared class library consumed by CLI and Web API projects.

## Project Structure

```
MathToolsDotNet/
├── MathToolsDotNet.Core/       # Class library with Calculator
├── MathToolsDotNet.CLI/        # Console application
└── MathToolsDotNet.Api/        # Minimal Web API
```

## Usage

**Run CLI:**
```bash
dotnet run --project MathToolsDotNet.CLI
```

**Run API:**
```bash
dotnet run --project MathToolsDotNet.Api
```

**Test API:**
- Use `MathToolsDotNet.Api/MathToolsDotNet.Api.http` with REST Client extension
- OpenAPI available at `/openapi/v1.json` in development mode

## Build

```bash
dotnet build
```
