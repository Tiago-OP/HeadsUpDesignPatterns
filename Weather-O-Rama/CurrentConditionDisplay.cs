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

        private IOutput _console;

        public CurrentConditionDisplay(IOutput console)
        {
            _console = console;
        }
        public CurrentConditionDisplay()
        {
            _console = new ConsoleWrapper();
        }
        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _hum = humidity;
            Display();
        }

        public void Display()
        {
            _console.Write($"The temperature is {_temp} and the humidity is {_hum}");
        }
    }
}
