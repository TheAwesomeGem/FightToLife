using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public struct CommandData
    {
        public GameCommand GameCommand { get; }
        public List<string> Arguments { get; }

        public CommandData(GameCommand gameCommand, List<string> arguments)
        {
            GameCommand = gameCommand;
            Arguments = arguments;
        }
    }
}