using Moq;
using NUnit.Framework;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests
{
    public class FlyNoWayTests
    {
        [Test]
        public void FlyNoWay()
        {
            var consoleMock = new Mock<IConsole>();
            var flyNoWay = new FlyNoWay(consoleMock.Object);

            flyNoWay.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I can't fly!!")));
        }
    }
}