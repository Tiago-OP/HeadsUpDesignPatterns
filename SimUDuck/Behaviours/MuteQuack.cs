using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class NormalQuack : IQuackBehaviour
    {
        private readonly IOutput _output;

        public NormalQuack()
        {
            _output = new ConsoleWrapper();
        }
        public NormalQuack(IOutput output)
        {
            _output = output;
        }
        public void Quack()
        {
            _output.Write("Quack!");
        }
    }
}