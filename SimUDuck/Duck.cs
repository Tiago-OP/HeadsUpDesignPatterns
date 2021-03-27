using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public class Duck
    {
        private IFlyBehaviour _flyBehaviour;
        private IQuackBehaviour _quackBehaviour;

        public Duck()
        {
            _flyBehaviour = new FlyWithWings(new ConsoleWrapper());
            _quackBehaviour = new NormalQuack();
        }
        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }
    }
}
