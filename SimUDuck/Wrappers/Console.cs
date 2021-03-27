using System;

namespace SimUDuck.Wrappers
{
    public interface IConsole
    {
        public void Write(string message);
    }

    public class ConsoleWrapper : IConsole
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }


}