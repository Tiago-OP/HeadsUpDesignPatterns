using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        private readonly IConsole _console;
        public FlyWithWings(IConsole customConsole)
        {
            _console = customConsole;
        }

        public FlyWithWings()
        {
            _console = new ConsoleWrapper();
        }

        public void Fly()
        {
            _console.Write("I'm flying!!");
        }
    }
}