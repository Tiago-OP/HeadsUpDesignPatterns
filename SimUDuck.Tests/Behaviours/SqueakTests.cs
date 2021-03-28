using Moq;
using NUnit.Framework;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests.Behaviours
{
    public class SqueakTests
    {
        [Test]
        public void Squeak()
        {
            var consoleMock = new Mock<IOutput>();
            var squeack = new Squeak(consoleMock.Object);

            squeack.Quack();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "Squeak")));
        }
    }
}