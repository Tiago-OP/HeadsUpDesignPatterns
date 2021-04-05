using NUnit.Framework;
using Weather_O_Rama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_O_Rama.Wrappers;
using Moq;

namespace Weather_O_Rama.Tests
{
    [TestFixture()]
    public class WeatherDataTests
    {
        [Test()]
        public void UpdateValuesTest()
        {
            var weather = new WeatherData();
            var consoleMock = new Mock<IOutput>();

            var display = new CurrentConditionDisplay(consoleMock.Object);
            weather.RegisterObserver(display);
            weather.UpdateValues(1,12,123);
            
            weather.NotifyObserver();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == $"The temperature is 1 and the humidity is 12")));

        }
    }
}