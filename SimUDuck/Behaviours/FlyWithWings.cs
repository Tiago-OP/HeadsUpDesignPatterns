using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class FlyNoWay : IFlyBehaviour
    {
        private readonly IOutput _output;
        public FlyNoWay(IOutput customOutput)
        {
            _output = customOutput;
        }

        public FlyNoWay()
        {
            _output = new ConsoleWrapper();
        }

        public void Fly()
        {
            _output.Write("I can't fly!!");
        }
    }
}