using Moq;
using NUnit.Framework;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests.Behaviours
{
    public class MuteQuackTests
    {
        [Test]
        public void MuteQuack()
        {
            var consoleMock = new Mock<IOutput>();
            var muteQuack = new MuteQuack(consoleMock.Object);

            muteQuack.Quack();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "<< Silence >>")));
        }
    }
}