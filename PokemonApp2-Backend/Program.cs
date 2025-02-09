using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Füge den HttpClient-Dienst hinzu
builder.Services.AddHttpClient();

// Füge die Controller-Dienste hinzu
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.Run();


