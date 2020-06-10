using System.Collections.Generic;

namespace TheCardGameConsole
{
    public struct InputData
    {
        public string Command { get; }
        public List<string> Arguments { get; }

        public InputData(string command, List<string> arguments)
        {
            Command = command;
            Arguments = arguments;
        }

        public override string ToString()
        {
            return $"{Command} {string.Join(" ", Arguments)}";
        }
    }
}