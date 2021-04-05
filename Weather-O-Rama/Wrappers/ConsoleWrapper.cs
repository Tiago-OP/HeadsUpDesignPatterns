using System;

namespace Weather_O_Rama.Wrappers
{
    public class ConsoleWrapper : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}