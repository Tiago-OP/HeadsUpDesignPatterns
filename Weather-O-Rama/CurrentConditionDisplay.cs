using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_O_Rama.Wrappers;

namespace Weather_O_Rama
{
    public class CurrentConditionDisplay :IObserver, IDisplayElement
    {
        public float _temp;
        public float _hum;
        private WeatherData _weatherData;
        private IOutput _console;

        public CurrentConditionDisplay(IOutput console, WeatherData weatherData)
        {
            _console = console;
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public CurrentConditionDisplay()
        {
            _console = new ConsoleWrapper();
        }
        public void Update()
        {
            _temp = _weatherData.Temp;
            _hum = _weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            _console.Write($"The temperature is {_temp} and the humidity is {_hum}");
        }
    }
}
