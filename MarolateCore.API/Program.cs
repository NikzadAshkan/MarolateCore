using MarolateCore.Infrastructure.DependencyInjection;
using MarolateCore.Application.DependencyInjection;
using MarolateCore.Persistence.DependencyInjection;
using MarolateCore.API.Middlewares;
using MarolateCore.Application.Configuration;

var builder = WebApplication.CreateBuilder(args);

//DependencyInjection
builder.Services.AddInfrastructure();
builder.Services.AddApplication();
builder.Services.AddPersistence();

// Add services to the container.
builder.Services.AddControllers();

// Appsettings configuration
builder.Services.Configure<AppSettings>(
    builder.Configuration.GetSection("AppSettings"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Global Exception Handling Middleware
app.UseMiddleware<GlobalExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
