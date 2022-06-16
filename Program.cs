// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using ef_core_specification_pattern;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services
            .AddScoped<IDbRepository, DbRepository>()
            .AddScoped<EFContext>();
    })
    .Build();
    


Console.WriteLine("Hello, World!");

var dbRepository = host.Services.GetService<IDbRepository>();
var users = await dbRepository.Find(new IsAdultSpecification());
var a = 123;
