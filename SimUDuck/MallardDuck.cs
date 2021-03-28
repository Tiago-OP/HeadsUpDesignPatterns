using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behaviours;
using SimUDuck.Wrappers;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        private IConsole _console;
        public MallardDuck(IConsole console) : base(new FlyWithWings(console), new NormalQuack(console), console)
        {
            _console = console;
        }

        public override void Display()
        {
            _console.Write("I'm a real Mallard duck");
        }
    }
}
