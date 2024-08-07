using Business.Interface;
using Business;
using DAO.Interface;
using DAO;
using Infra.Context;
using Infra.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddTransient<IJogoBusiness, JogoBusiness>();

builder.Services.AddTransient<IPlayArenaDAO, PlayArenaDAO>();

builder.Services.AddTransient<IRequisitoSistemaBusiness, RequisitoSistemaBusiness>();

builder.Services.AddTransient<IRequisitoSistemaDAO, RequisitoSistemaDAO>();

builder.Services.AddTransient<IImagemJogoDAO, ImagemJogoDAO>();

builder.Services.AddTransient<IImagemJogoBusiness, ImagemJogoBusiness>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
