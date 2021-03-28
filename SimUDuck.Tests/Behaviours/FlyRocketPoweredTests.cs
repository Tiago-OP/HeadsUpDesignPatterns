using Moq;
using NUnit.Framework;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests.Behaviours
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