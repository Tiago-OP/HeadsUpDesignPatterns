using Moq;
using NUnit.Framework;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests
{
    public class FlyWithWingsTests
    {
        [Test]
        public void FlyWithWings()
        {
            var consoleMock = new Mock<IConsole>();
            var flyWithWings = new FlyWithWings(consoleMock.Object);

            flyWithWings.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm flying!!")));
        }
    }
}