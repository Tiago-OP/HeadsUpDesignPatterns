using System;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public abstract class Duck
    {
         private IFlyBehaviour _flyBehaviour;
         private readonly IQuackBehaviour _quackBehaviour;
         private readonly IOutput _output;
         private readonly IDuckCallBehaviour _duckCall;

         public abstract void Display();

        protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour, IOutput output)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
            _output = output;
        }

        protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour, IDuckCallBehaviour duckCall, IOutput output)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
            _output = output;
            _duckCall = duckCall;
        }

        protected Duck(IDuckCallBehaviour duckCall)
        {
            _duckCall = duckCall;
            _output = new ConsoleWrapper();
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }
        public void DuckCall()
        {
            _duckCall.DuckCall();
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

        public void Swing()
        {
            _output.Write("All ducks float, even decoys!");
        }

        public void SetFlyBehaviour(IFlyBehaviour behaviour)
        {
            _flyBehaviour = behaviour;
        }
    }
}
