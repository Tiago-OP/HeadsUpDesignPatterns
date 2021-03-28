using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class NormalQuack : IQuackBehaviour
    {
        private readonly IConsole _console;

        public NormalQuack()
        {
            _console = new ConsoleWrapper();
        }
        public NormalQuack(IConsole console)
        {
            _console = console;
        }
        public void Quack()
        {
            _console.Write("Quack!");
        }
    }
}