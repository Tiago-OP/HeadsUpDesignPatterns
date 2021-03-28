using Moq;
using NUnit.Framework;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests.Behaviours
{
    public class FlyWithWingsTests
    {
        [Test]
        public void FlyWithWings()
        {
            var consoleMock = new Mock<IOutput>();
            var flyWithWings = new FlyWithWings(consoleMock.Object);

            flyWithWings.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm flying!!")));
        }
    }
}