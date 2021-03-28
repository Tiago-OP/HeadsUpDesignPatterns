﻿using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class FlyNoWay : IFlyBehaviour
    {
        private readonly IConsole _console;
        public FlyNoWay(IConsole customConsole)
        {
            _console = customConsole;
        }

        public FlyNoWay()
        {
            _console = new ConsoleWrapper();
        }

        public void Fly()
        {
            _console.Write("I can't fly!!");
        }
    }
}