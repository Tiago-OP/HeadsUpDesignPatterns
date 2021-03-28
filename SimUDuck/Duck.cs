using System;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public abstract class Duck
    {
         IFlyBehaviour _flyBehaviour;
         IQuackBehaviour _quackBehaviour;
         IOutput _output;

         public abstract void Display();

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour, IOutput output)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
            _output = output;
        }

        protected Duck()
        {
            _output = new ConsoleWrapper();
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
            _output.Write("All ducks float, even decoys!");
        }
    }
}
