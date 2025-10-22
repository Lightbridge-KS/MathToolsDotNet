using MathToolsDotNet.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<Calculator>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Calculator API endpoints
app.MapPost("/calculator/add", (CalculatorRequest request, Calculator calculator) =>
{
    var result = calculator.Add(request.A, request.B);
    return new CalculatorResponse(request.A, request.B, result, "addition");
})
.WithName("AddNumbers")
.WithOpenApi();

app.MapPost("/calculator/multiply", (CalculatorRequest request, Calculator calculator) =>
{
    var result = calculator.Multiply(request.A, request.B);
    return new CalculatorResponse(request.A, request.B, result, "multiplication");
})
.WithName("MultiplyNumbers")
.WithOpenApi();

app.Run();

// Request/Response DTOs
record CalculatorRequest(int A, int B);
record CalculatorResponse(int A, int B, int Result, string Operation);
