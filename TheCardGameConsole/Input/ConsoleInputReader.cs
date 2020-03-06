using System;
using System.Linq;

namespace TheCardGameConsole
{
    public class ConsoleInputReader : InputReader
    {
        private readonly UIInput UIInput;

        public ConsoleInputReader(UIInput uiInput)
        {
            UIInput = uiInput;
        }

        public InputData ReadCurrentInput()
        {
            string line = UIInput.ReadLine();
            string[] arguments = line?.Split(' ') ?? Array.Empty<string>();
            string command = arguments[0];
            var argumentCollection = arguments.Where(arg => arg != null).ToList();
            argumentCollection.RemoveAt(0);

            return new InputData(command, argumentCollection, line);
        }
    }
}