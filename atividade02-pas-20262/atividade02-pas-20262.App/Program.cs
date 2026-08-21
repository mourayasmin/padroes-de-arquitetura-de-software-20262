using atividade02_pas_20261.App;
using atividade02_pas_20261.Domain;
using atividade02_pas_20261.Infra;
using atividade02_pas_20261.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDbContext<Database>(options =>
    options.UseSqlite("Data Source=banco.db"));

builder.Services.AddScoped<IContaRepository, ContaRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IAgenciaRepository, AgenciaRepository>();
builder.Services.AddScoped<ContaService>();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Database>();
    db.Database.EnsureCreated();
}

host.Run();