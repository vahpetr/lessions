using Microsoft.Extensions.Configuration;

var env = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
var config = new ConfigurationBuilder()
  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
  .AddJsonFile($"appsettings.{env}.json", true, true)
  .AddEnvironmentVariables()
  .AddCommandLine(args)
  .Build();

var firstWord = config["AppSettings:FirstWord"];
var secondWord = config["AppSettings:SecondWord"];
var version = config["AppSettings:Versions:0:Number"];

Console.WriteLine($"{firstWord} {secondWord} {version}");
