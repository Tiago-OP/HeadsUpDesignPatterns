using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class NormalQuack : IQuackBehaviour
    {
        private readonly IOutput _output;

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