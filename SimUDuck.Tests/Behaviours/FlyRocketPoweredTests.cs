using NUnit.Framework;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace SimUDuck.Behaviours.Tests
{
    [TestFixture()]
    public class FlyRocketPoweredTests
    {
        [Test()]
        public void FlyTest()
        {
            var consoleMock = new Mock<IOutput>();
            var flyWithWings = new FlyRocketPowered(consoleMock.Object);

            flyWithWings.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm flying with a rocket!")));

        }
    }
}