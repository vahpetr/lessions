using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

var mySetting = config["MySetting"];

if (string.IsNullOrEmpty(mySetting))
    Console.WriteLine("Setting not found in appsettings.json.");
else
    Console.WriteLine($"Setting value: {mySetting}");
