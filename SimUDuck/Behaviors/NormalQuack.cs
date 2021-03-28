using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class MuteQuack : IQuackBehaviour
    {
        private readonly IOutput _output;

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