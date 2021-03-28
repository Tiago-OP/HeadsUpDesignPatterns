using System;
using SimUDuck.Wrappers;

namespace SimUDuck.Behaviors
{
    public class MallardDuckCall : IDuckCallBehaviour
    {
        private readonly IOutput _output;

        public MallardDuckCall(IOutput output)
        {
            _output = output;
        }
        public void DuckCall()
        {
            _output.Write("Mallard Mallard Mallard");
        }
    }
}
