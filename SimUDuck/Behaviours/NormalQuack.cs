using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        private readonly IOutput _output;

        public MuteQuack()
        {
            _output = new ConsoleWrapper();
        }
        public MuteQuack(IOutput output)
        {
            _output = output;
        }
        public void Quack()
        {
            _output.Write("<< Silence >>");
        }
    }
}