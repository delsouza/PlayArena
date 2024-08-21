using Infra.Context;
using Infra.UnitOfWork;
using Business.PlayArena.Interface;
using Business.PlayArena;
using DAO.Interface;
using DAO;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IRequisitoSistemaBusiness, RequisitoSistemaBusiness>();

builder.Services.AddTransient<IImagemJogoBusiness, ImagemJogoBusiness>();

builder.Services.AddTransient<IImagemJogoDAO, ImagemJogoDAO>();

builder.Services.AddTransient<IJogoBusiness, JogoBusiness>();

builder.Services.AddScoped<IClienteBusiness, ClienteBusiness>();
    
builder.Services.AddScoped<IClienteDAO, ClienteDAO>();

builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options =>
{
    options.LoginPath = "/Conta/Login";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(3);
    options.SlidingExpiration = true;
    options.Cookie.Name = "CookiePlayArena";
});


builder.Services.AddAuthorization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
