using CPrimer;

// Part 1

List<int> numbers = new List<int>();
bool codeRunning = true;

do
{
    Console.WriteLine("Please enter a whole number. When finished press enter to exit.");

    string? input = Console.ReadLine();
    
    if (input == "")
    {
        codeRunning = false;
    } else if (int.TryParse(input, out int inputInt))
    {
        numbers.Add(inputInt);
    }
    else
    {
        Console.WriteLine("Incorrect input. Please enter a whole number.");
    }
}
while (codeRunning);

if (numbers.Count != 0)
{
    Console.WriteLine($"The largest number is: {numbers.Max()}");
    Console.WriteLine($"The smallest number is: {numbers.Min()}");
}


// Part 2
// Scale should be set before Temperature, so it will be in the correct range

WeatherData currentWeather = new WeatherData();

currentWeather.Scale = 'F';
currentWeather.Temperature = 100;
currentWeather.Humidity = "30%";
currentWeather.Convert();

currentWeather.ShowWeatherData();