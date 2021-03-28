using Moq;
using NUnit.Framework;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests
{
    public class MuteQuackTests
    {
        [Test]
        public void MuteQuack()
        {
            var consoleMock = new Mock<IConsole>();
            var muteQuack = new MuteQuack(consoleMock.Object);

            muteQuack.Quack();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "<< Silence >>")));
        }
    }
}