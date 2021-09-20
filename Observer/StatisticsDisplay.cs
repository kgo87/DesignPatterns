using System;
namespace Observer
{
    public class StatisticsDisplay: Observer, DisplayElement
    {
        private float maxTemp;
        private float minTemp = 200.0f;
        private float tempSum;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature values: " + (tempSum / numReadings) + "F /"
                + maxTemp + "F /" + minTemp + "F");
        }

        public void update(float temp, float humidity, float pressure)
        {
            try
            {
                tempSum += temp;
                numReadings++;
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                }
                display();
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
