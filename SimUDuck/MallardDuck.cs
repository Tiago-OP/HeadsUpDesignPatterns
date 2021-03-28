using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        private IOutput _output;
        public MallardDuck(IOutput output) : base(new FlyWithWings(output), new NormalQuack(output), new MallardDuckCall(output), output)
        {
            _output = output;
        }

        public override void Display()
        {
            _output.Write("I'm a real Mallard duck");
        }
    }
}
