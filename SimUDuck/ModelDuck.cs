using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        private readonly IOutput _output;
        public ModelDuck(IOutput output) : base(new FlyWithWings(output), new NormalQuack(output), output)
        {
            _output = output;
        }

        public override void Display()
        {
            _output.Write("I'm a model duck");
        }

        public void SetRocket()
        {
            SetFlyBehaviour(new FlyRocketPowered(_output));
        }
    }
}
