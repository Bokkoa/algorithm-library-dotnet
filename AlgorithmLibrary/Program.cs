using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Services.ManipulationHashing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
builder.Services.AddScoped<ITwoSumService, TwoSumService>();
builder.Services.AddScoped<IContainsDuplicateService, ContainsDuplicateService>();
builder.Services.AddScoped<IValidAnagramService, ValidAnagramService>();
builder.Services.AddScoped<IGroupAnagramsService, GroupAnagramService>();


var app = builder.Build();

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
