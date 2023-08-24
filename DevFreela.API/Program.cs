using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Services.Implementation;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.Validators;
using DevFreela.Infrastructure.Persistence;
using FluentValidation.AspNetCore;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DevFreela.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();

builder.Services.AddMediatR(typeof(CreateProjectCommand));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DevFreelaCs");

builder.Services.AddDbContext<DevFreelaDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IProjectService, ProjectService>();


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
