using System;
namespace Observer
{
    public class CurrentConditionsDisplay: Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current weather conditions: temperature = " + temperature + "F; humidity = "
                + humidity + "%; pressure = " + pressure + "in");
        }

        public void update(float temp, float humidity, float pressure)
        {
            try
            {
                this.temperature = temp;
                this.humidity = humidity;
                this.pressure = pressure;
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
