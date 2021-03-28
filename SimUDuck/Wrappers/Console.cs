using System;

namespace SimUDuck.Wrappers
{
    public interface IOutput
    {
        public void Write(string message);
    }

    public class ConsoleWrapper : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }


}