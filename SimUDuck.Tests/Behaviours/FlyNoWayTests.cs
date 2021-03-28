using Moq;
using NUnit.Framework;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests.Behaviours
{
    public class FlyNoWayTests
    {
        [Test]
        public void FlyNoWay()
        {
            var consoleMock = new Mock<IOutput>();
            var flyNoWay = new FlyNoWay(consoleMock.Object);

            flyNoWay.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I can't fly!!")));
        }
    }
}