using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args).Build();
var config = host.Services.GetService(typeof(IConfiguration)) as IConfiguration;

var settings = new AppSettings();
config!.GetSection(nameof(AppSettings)).Bind(settings);

Console.WriteLine($"{settings.FirstWord} {settings.SecondWord} {settings.Versions[0].Number}");
