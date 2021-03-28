using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class Squeak : IQuackBehaviour
    {
        private readonly IOutput _output;

        public Squeak()
        {
            _output = new ConsoleWrapper();
        }
        public Squeak(IOutput output)
        {
            _output = output;
        }
        public void Quack()
        {
            _output.Write("Squeak");
        }
    }
}