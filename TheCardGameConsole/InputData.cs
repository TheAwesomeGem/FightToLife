using System.Collections.Generic;

namespace TheCardGameConsole
{
    public struct InputData
    {
        public string Command { get; }
        public List<string> Arguments { get; }
        public string FullCommand { get; }

        public InputData(string command, List<string> arguments, string fullCommand)
        {
            Command = command;
            Arguments = arguments;
            FullCommand = fullCommand;
        }

        public override string ToString()
        {
            return FullCommand;
        }
    }
}