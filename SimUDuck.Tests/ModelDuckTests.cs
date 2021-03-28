using NUnit.Framework;
using SimUDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests
{
    [TestFixture()]
    public class ModelDuckTests
    {
        [Test]
        public void DisplayTest()
        {
            var consoleMock = new Mock<IOutput>();
            var duck = new ModelDuck(consoleMock.Object);

            duck.Display();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm a model duck")));
        }

        [Test]
        public void SetRocket()
        {
            var consoleMock = new Mock<IOutput>();
            var duck = new ModelDuck(consoleMock.Object);

            duck.SetRocket();
            duck.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm flying with a rocket!")));
        }
    }
}