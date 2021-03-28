using System;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public abstract class Duck
    {
         IFlyBehaviour _flyBehaviour;
         IQuackBehaviour _quackBehaviour;
         IConsole _console;

         public abstract void Display();

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour, IConsole console)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
            _console = console;
        }

        protected Duck()
        {
            _console = new ConsoleWrapper();
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

        public void Swing()
        {
            _console.Write("All ducks float, even decoys!");
        }
    }
}
