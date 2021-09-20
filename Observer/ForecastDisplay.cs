using System;
namespace Observer
{
    public class ForecastDisplay: Observer, DisplayElement
    {
        private float currentPressure = 29.2f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            };
        }

        public void update(float temp, float humidity, float pressure)
        {
            try
            {
                lastPressure = currentPressure;
                currentPressure = pressure;

                display();
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
