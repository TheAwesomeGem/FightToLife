using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandGeneratorImpl : CommandGenerator
    {
        public Dictionary<string, GameCommand> GenerateCommands()
        {
            return new Dictionary<string, GameCommand>
            {
                {"shutdown", GameCommandFactory.GetShutdownCommand()}
            };
        }
    }
}