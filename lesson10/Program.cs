using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOptions<AppSettings>().BindConfiguration(nameof(AppSettings));
    })
    .Build();

var options = host.Services.GetRequiredService<IOptions<AppSettings>>();

Console.WriteLine($"{options.Value.FirstWord} {options.Value.SecondWord} {options.Value.Versions[0].Number}");
