using System;
using Moq;
using NUnit.Framework;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests
{
    public class DuckTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Duck_swings()
        {
            var consoleMock = new Mock<IOutput>();
            var mockDuck = new Mock<Duck>(It.IsAny<IFlyBehaviour>(), It.IsAny<IQuackBehaviour>(), consoleMock.Object)
            {
                CallBase = true
            };

            mockDuck.Object.Swing();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "All ducks float, even decoys!")));
        }
    }
}
