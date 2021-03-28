using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class FlyNoWay : IFlyBehaviour
    {
        private readonly IOutput _output;
        public FlyNoWay(IOutput customOutput)
        {
            _output = customOutput;
        }

        public void Fly()
        {
            _output.Write("I can't fly!!");
        }
    }
}