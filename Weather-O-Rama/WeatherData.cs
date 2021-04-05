using System;
using System.Collections.Generic;

namespace Weather_O_Rama
{
    public class WeatherData: ISubject
    {
        private List<IObserver> _observers;
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        public float Temp { get; private set; }

        public void UpdateValues(float temperature, float humidity, float pressure)
        {
            Temp = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
        public void NotifyObserver()
        {
            _observers.ForEach(x=>x.Update());
        }
    }
}
