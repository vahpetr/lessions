using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args).Build();
var config = host.Services.GetService(typeof(IConfiguration)) as IConfiguration;

var firstWord = config!["AppSettings:FirstWord"];
var secondWord = config!["AppSettings:SecondWord"];
var version = config!["AppSettings:Versions:0:Number"];

Console.WriteLine($"{firstWord} {secondWord} {version}");

