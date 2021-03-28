using NUnit.Framework;
using SimUDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests
{
    [TestFixture()]
    public class MallardDuckTests
    {
        [Test()]
        public void DisplayTest()
        {
            var consoleMock = new Mock<IOutput>();
            var duck = new MallardDuck(consoleMock.Object);
            
            duck.Display();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm a real Mallard duck")));

        }
        [Test]
        public void Quack()
        {
            var consoleMock = new Mock<IOutput>();
            var duck = new MallardDuck(consoleMock.Object);

            duck.Quack();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "Quack!")));
        }

        [Test]
        public void FlyWithWings()
        {
            var consoleMock = new Mock<IOutput>();
            var duck= new MallardDuck(consoleMock.Object);

            duck.Fly();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "I'm flying!!")));
        }

        [Test]
        public void DuckCall()
        {
            var consoleMock = new Mock<IOutput>();
            var duck= new MallardDuck(consoleMock.Object);

            duck.DuckCall();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "Mallard Mallard Mallard")));
        }
    }
}