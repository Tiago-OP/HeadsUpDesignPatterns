using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        private readonly IOutput _output;
        public FlyRocketPowered(IOutput customOutput)
        {
            _output = customOutput;
        }

        public void Fly()
        {
            _output.Write("I'm flying with a rocket!");
        }
    }
}