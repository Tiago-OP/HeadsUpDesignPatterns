using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        private readonly IOutput _output;
        public FlyRocketPowered(IOutput customOutput)
        {
            _output = customOutput;
        }

        public FlyRocketPowered()
        {
            _output = new ConsoleWrapper();
        }

        public void Fly()
        {
            _output.Write("I'm flying with a rocket!");
        }
    }
}