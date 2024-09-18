namespace CPrimer;

public class WeatherData
{
    private double _temperature;
    public double Temperature
    {
        get
        {
            return _temperature;
        }
        
        set
        {
            if (Scale == 'C')
            {
                if (value >= -60.0 && value <= 60.0)
                {
                    _temperature = value;
                }
                else
                {
                    Console.WriteLine("Temperature out of range");
                }
            } else if (Scale == 'F')
            {
                if (value >= -76.0 && value <= 140.0)
                {
                    _temperature = value;
                }
                else
                {
                    Console.WriteLine("Temperature out of range");
                }
            }
        }
    }
    
    // To show humidity with %, humidity is put in and retrieved with string
    private int _humidity;
    public string Humidity
    {
        get
        {
            return $"{_humidity}%";
        }
        set
        {
            if (value.EndsWith("%"))
            {
                string valueToConvert = value.Remove(value.Length - 1);
                if (int.TryParse(valueToConvert, out int valueToInt))
                {
                    if (valueToInt >= 0 && valueToInt <= 100)
                    {
                        _humidity = valueToInt;
                    }
                    else
                    {
                        Console.WriteLine("Humidity out of range");
                    }
                }
                else
                {
                    Console.WriteLine("Humidity is not a whole number");
                }
            }
            else
            {
                Console.WriteLine("Humidity is not a percentage");
            }
        }
    }

    private char _scale = 'C';
    public char Scale
    {
        get
        {
          return _scale;  
        }
        set
        {
            if (value == 'C' || value == 'F')
            {
                _scale = value;
            }
            else
            {
                Console.WriteLine("Incorrect value. Please select C or F");
            }
        }
    }

    public void Convert()
    {
        if (Scale == 'C')
        {
            Scale = 'F';
            _temperature = (_temperature * 9 / 5) + 32;
        } else if (Scale == 'F')
        {
            Scale = 'C';
            _temperature = (_temperature - 32) * 5 / 9;
        }
        else
        {
            Console.WriteLine("Something went wrong");
        }
    }

    // Added ShowWeatherData for comfort
    public void ShowWeatherData()
    {
        Console.WriteLine($"Temperature: {_temperature} {_scale}°, Humidity: {_humidity}%");
    }
}