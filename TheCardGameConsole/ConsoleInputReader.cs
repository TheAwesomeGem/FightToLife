using System;
using System.Linq;

namespace TheCardGameConsole
{
    public class ConsoleInputReader : InputReader
    {
        public InputData GetInputDataFromLine(string line)
        {
            string[] arguments = line?.Split(' ') ?? Array.Empty<string>();
            string command = arguments[0];
            var argumentCollection = arguments.Where(arg => arg != null).ToList();
            argumentCollection.RemoveAt(0);

            return new InputData(command, argumentCollection, line);;
        }
    }
}