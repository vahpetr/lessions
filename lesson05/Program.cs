var myVariable = Environment.GetEnvironmentVariable("MY_VARIABLE");
if (string.IsNullOrEmpty(myVariable))
	Console.WriteLine("Environment variable not set.");
else
	Console.WriteLine($"Environment variable value: {myVariable}");
