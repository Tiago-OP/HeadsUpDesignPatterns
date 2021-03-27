using System;
using Moq;
using NUnit.Framework;
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
        public void Duck_should_fly()
        {
            var duck = new Duck();

            Assert.DoesNotThrow(() => duck.Fly());
        }

        [Test]
        public void Duck_should_quack()
        {
            var duck = new Duck();

            Assert.DoesNotThrow(() => duck.Quack());
        }
    }
}
