﻿using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        private readonly IConsole _console;

        public MuteQuack()
        {
            _console = new ConsoleWrapper();
        }
        public MuteQuack(IConsole console)
        {
            _console = console;
        }
        public void Quack()
        {
            _console.Write("<< Silence >>");
        }
    }
}