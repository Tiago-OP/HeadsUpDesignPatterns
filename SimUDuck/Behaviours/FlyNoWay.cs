using SimUDuck.Wrappers;

namespace SimUDuck.Behaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        private readonly IOutput _output;
        public FlyWithWings(IOutput customOutput)
        {
            _output = customOutput;
        }

        public FlyWithWings()
        {
            _output = new ConsoleWrapper();
        }

        public void Fly()
        {
            _output.Write("I'm flying!!");
        }
    }
}