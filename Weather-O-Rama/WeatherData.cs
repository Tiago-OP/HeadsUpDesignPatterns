using System;
using System.Collections.Generic;

namespace Weather_O_Rama
{
    public class WeatherData: ISubject
    {
        private List<IObserver> _observers;
        private float _humidity;
        private float _pressure;
        private float _temp;

        public void UpdateValues(float temperature, float humidity, float pressure)
        {
            _temp = temperature;
            _humidity = humidity;
            _pressure = pressure;
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
            _observers.ForEach(x=>x.Update(_temp, _humidity, _pressure));
        }
    }
}
