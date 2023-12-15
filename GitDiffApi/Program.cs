using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FS Dev Git-Diff API",
        Version = "1.0.0",
        Description = "A mini REST API over Git data. It allows to query repository commit diffs."
    });
});
//

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "myCorsPolicy",
                      builder =>
                          builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod()
                          );
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("myCorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();


