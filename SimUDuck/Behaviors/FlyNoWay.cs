using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class FlyWithWings : IFlyBehaviour
    {
        private readonly IOutput _output;
        public FlyWithWings(IOutput customOutput)
        {
            _output = customOutput;
        }

        public void Fly()
        { 
            _output.Write("I'm flying!!");
        }
    }
}