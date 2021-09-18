using System;

namespace Observer
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Weather Station");
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 30.4f);

        }
    }
}
