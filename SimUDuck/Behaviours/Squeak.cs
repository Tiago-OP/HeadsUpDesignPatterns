using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class Squeak : IQuackBehaviour
    {
        private readonly IConsole _console;

        public Squeak()
        {
            _console = new ConsoleWrapper();
        }
        public Squeak(IConsole console)
        {
            _console = console;
        }
        public void Quack()
        {
            _console.Write("Squeak");
        }
    }
}