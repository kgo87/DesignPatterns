using System;
using System.Collections.Generic;

namespace Observer
{
    public class WeatherData: Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            try
            {
                observers.Add(o);
            }
            catch
            {
                observers.Add(o);
            }
            
        }

        public void removeObserver(Observer o)
        {
            try
            {
                observers.Remove(o);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }


        public void notifyObservers()
        {
            try
            {
                foreach (Observer observer in observers)
                {
                    observer.update(temperature, humidity, pressure);
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

    }
}
